using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CancellationRequestsForm : Form
    {
        private int operatorId;
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public CancellationRequestsForm(int operatorId)
        {
            InitializeComponent();
            this.operatorId = operatorId;
            InitializeDataGridViewColumns();
            this.Load += CancellationRequestsForm_Load;
        }

        private void InitializeDataGridViewColumns()
        {
            dgvCancellationRequests.AutoGenerateColumns = false;
            dgvCancellationRequests.Columns.Clear();

            dgvCancellationRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Visible = false,
                DataPropertyName = "RequestID",
                Name = "RequestID"
            });

            dgvCancellationRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Customer",
                HeaderText = "Customer"
            });

            dgvCancellationRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Trip",
                HeaderText = "Trip"
            });

            dgvCancellationRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RequestDate",  
                HeaderText = "Request Date",      
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            dgvCancellationRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Reason",
                HeaderText = "Reason",
                Name = "Reason"
            });

            dgvCancellationRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
            });

            dgvCancellationRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCancellationRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCancellationRequests.MultiSelect = false;
        }

        private void LoadRequests()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            CR.RequestID,
                            T.Fname + ' ' + T.Lname AS Customer,
                            TR.Title AS Trip,
                            CR.RequestDate,
                            CR.Reason,
                            CR.Status
                        FROM CancellationRequest CR
                        JOIN Booking B ON CR.BookingID = B.BookingID
                        JOIN Traveler T ON B.TravelerID = T.TravelerID
                        JOIN Trip TR ON B.TripID = TR.TripID
                        WHERE TR.OperatorID = @OperatorId AND CR.Status IN ('Pending')
                        ORDER BY CR.RequestDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@OperatorId", operatorId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCancellationRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cancellation requests: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCancellationRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCancellationRequests.Rows.Count)
            {
                var row = dgvCancellationRequests.Rows[e.RowIndex];
                txtReason.Text = row.Cells["Reason"].Value?.ToString() ?? string.Empty;
            }
        }

        private void UpdateRequestStatus(string newStatus)
        {
            if (dgvCancellationRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request to update.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvCancellationRequests.SelectedRows[0];
            if (selectedRow.Cells["RequestID"].Value == null)
            {
                MessageBox.Show("Invalid request selected.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int requestId = Convert.ToInt32(selectedRow.Cells["RequestID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string updateRequestQuery = @"
                            UPDATE CancellationRequest 
                            SET Status = @Status 
                            WHERE RequestID = @RequestID";

                        SqlCommand updateRequestCmd = new SqlCommand(updateRequestQuery, conn, transaction);
                        updateRequestCmd.Parameters.AddWithValue("@Status", newStatus);
                        updateRequestCmd.Parameters.AddWithValue("@RequestID", requestId);
                        updateRequestCmd.ExecuteNonQuery();

                        if (newStatus == "Approved")
                        {
                            string updateBookingQuery = @"
                                UPDATE Booking 
                                SET Status = 'Cancelled' 
                                WHERE BookingID = (
                                    SELECT BookingID 
                                    FROM CancellationRequest 
                                    WHERE RequestID = @RequestID
                                )";

                            SqlCommand updateBookingCmd = new SqlCommand(updateBookingQuery, conn, transaction);
                            updateBookingCmd.Parameters.AddWithValue("@RequestID", requestId);
                            updateBookingCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        LoadRequests();
                        MessageBox.Show($"Request {newStatus.ToLower()} successfully.", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update request: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating request: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancellationRequestsForm_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus("Rejected");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}