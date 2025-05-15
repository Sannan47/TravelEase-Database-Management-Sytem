using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TravelEase;

namespace WindowsFormsApp1
{
    public partial class BookingManagementForm : Form
    {
        private int providerId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public BookingManagementForm(int providerId)
        {
            InitializeComponent();
            this.providerId = providerId;
        }

        private void LoadBookings()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            B.BookingID,
                            B.BookingDate,
                            B.Status AS BookingStatus,
                            ISNULL(P.Amount, 0) AS PaymentAmount,
                            ISNULL(P.Status, 'Unpaid') AS PaymentStatus
                        FROM Booking B
                        JOIN Trip T ON B.TripID = T.TripID
                        JOIN Service S ON T.TripID = S.TripID
                        LEFT JOIN Payment P ON B.BookingID = P.BookingID
                        WHERE S.ProviderID = @ProviderID
                          AND (B.Status = 'Pending' OR P.Status = 'Pending' OR P.Status IS NULL)";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProviderID", providerId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }



        private void InitializeBookingGrid()
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.Columns.Clear();

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBookingID",
                DataPropertyName = "BookingID",
                HeaderText = "Booking ID",
                ReadOnly = true
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBookingDate",
                DataPropertyName = "BookingDate",
                HeaderText = "Booking Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" },
                ReadOnly = true
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAmount",
                DataPropertyName = "PaymentAmount",
                HeaderText = "Amount",
                ReadOnly = true
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                DataPropertyName = "BookingStatus",
                HeaderText = "Status"
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPayment",
                DataPropertyName = "PaymentStatus",
                HeaderText = "Payment"
            });

            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void BookingManagementForm_Load(object sender, EventArgs e)
        {
            InitializeBookingGrid();
            LoadBookings();
        }

        private void UpdateBookingStatus(string newStatus)
        {
            foreach (DataGridViewRow row in dgvBookings.SelectedRows)
            {
                int bookingId = Convert.ToInt32(row.Cells["colBookingID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Booking SET Status = @Status WHERE BookingID = @BookingID", conn);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.ExecuteNonQuery();
                }

                row.Cells["colStatus"].Value = newStatus;
            }
            LoadBookings();
        }

        private void UpdatePaymentStatus(string newStatus)
        {
            foreach (DataGridViewRow row in dgvBookings.SelectedRows)
            {
                int bookingId = Convert.ToInt32(row.Cells["colBookingID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Payment SET Status = @Status WHERE BookingID = @BookingID", conn);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.ExecuteNonQuery();
                }

                row.Cells["colPayment"].Value = newStatus;
            }
            LoadBookings();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("Confirmed");
        }

        private void btnRejectBooking_Click(object sender, EventArgs e)
        {
            UpdateBookingStatus("Cancelled");
        }

        private void btnMarkAsPaid_Click(object sender, EventArgs e)
        {
            UpdatePaymentStatus("Success");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(providerId);
            dashboardForm.Show();
        }
    }
}
