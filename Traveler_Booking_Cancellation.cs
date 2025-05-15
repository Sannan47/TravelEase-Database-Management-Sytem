using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class CancellationRequestForm : Form
    {

        private int travelerId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public CancellationRequestForm(int travelerId)
        {
            InitializeComponent();
            this.travelerId = travelerId;
            LoadBookingIDs();
        }

        private void LoadBookingIDs()
        {
            cbBookingID.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT BookingID 
                         FROM Booking 
                         WHERE TravelerID = @travelerId AND Status = 'Confirmed'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@travelerId", travelerId);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbBookingID.Items.Add(reader["BookingID"].ToString());
                }
            }
        }



        private void CancellationRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void lblBookingID_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (cbBookingID.SelectedItem == null || string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please select a booking and provide a reason.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingId = Convert.ToInt32(cbBookingID.SelectedItem);
            string reason = txtReason.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string getIdQuery = "SELECT ISNULL(MAX(RequestID), 0) + 1 FROM CancellationRequest";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, conn);
                int newRequestId = (int)getIdCmd.ExecuteScalar();

                string insertQuery = @"INSERT INTO CancellationRequest (RequestID, BookingID, RequestDate, Reason, Status)
                       VALUES (@requestId, @bookingId, GETDATE(), @reason, 'Pending')";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@requestId", newRequestId);
                insertCmd.Parameters.AddWithValue("@bookingId", bookingId);
                insertCmd.Parameters.AddWithValue("@reason", reason);
                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cancellation request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Submission failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
