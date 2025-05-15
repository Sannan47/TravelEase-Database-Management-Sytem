using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TravelEase;

namespace WindowsFormsApp1
{
    public partial class ServiceApprovalForm : Form
    {
        private int providerId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public ServiceApprovalForm(int providerId)
        {
            InitializeComponent();
            this.providerId = providerId;
            InitializeDataGridView();
            this.Load += ServiceApprovalForm_Load;
        }

        private void InitializeDataGridView()
        {
            dgvServiceAssignments.AutoGenerateColumns = false;
            dgvServiceAssignments.Columns.Clear();

            dgvServiceAssignments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTripID",
                DataPropertyName = "TripID",
                HeaderText = "Trip ID",
                Visible = false
            });

            dgvServiceAssignments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTitle",
                DataPropertyName = "Title",
                HeaderText = "Trip Title"
            });

            dgvServiceAssignments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDestination",
                DataPropertyName = "Destination",
                HeaderText = "Destination"
            });

            dgvServiceAssignments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStartDate",
                DataPropertyName = "StartDate",
                HeaderText = "Start Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            dgvServiceAssignments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCompanyName",
                DataPropertyName = "CompanyName",
                HeaderText = "Tour Operator"
            });

            dgvServiceAssignments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAssignmentStatus",
                DataPropertyName = "AssignmentStatus",
                HeaderText = "Status"
            });

            dgvServiceAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceAssignments.MultiSelect = false;
        }

        private void LoadServiceAssignments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            S.TripID,
                            T.Title,
                            T.Destination,
                            T.StartDate,
                            TOpr.CompanyName,
                            S.AssignmentStatus
                        FROM Service S
                        INNER JOIN Trip T ON S.TripID = T.TripID
                        INNER JOIN TourOperator TOpr ON T.OperatorID = TOpr.OperatorID
                        WHERE S.ProviderID = @ProviderID AND S.AssignmentStatus = 'Pending'
                        ORDER BY T.StartDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProviderID", providerId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvServiceAssignments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading service assignments: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServiceAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateAssignmentStatus("Accepted");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateAssignmentStatus("Rejected");
        }

        private void UpdateAssignmentStatus(string newStatus)
        {
            if (dgvServiceAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment first.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvServiceAssignments.SelectedRows[0];
            int tripId = Convert.ToInt32(selectedRow.Cells["colTripID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string updateQuery = @"
                            UPDATE Service 
                            SET AssignmentStatus = @Status 
                            WHERE ProviderID = @ProviderID AND TripID = @TripID";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@ProviderID", providerId);
                        cmd.Parameters.AddWithValue("@TripID", tripId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            transaction.Commit();
                            LoadServiceAssignments();
                            MessageBox.Show($"Assignment {newStatus.ToLower()} successfully.", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("No assignment was updated. Please try again.", "Warning",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update assignment: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating assignment: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(providerId);
            dashboardForm.Show();
        }

        private void ServiceApprovalForm_Load(object sender, EventArgs e)
        {
            LoadServiceAssignments();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadServiceAssignments();
        }
    }
}