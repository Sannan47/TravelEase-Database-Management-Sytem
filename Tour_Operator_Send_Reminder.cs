using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SendReminderForm : Form
    {
        private int operatorId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public SendReminderForm(int operatorId)
        {
            InitializeComponent();
            this.operatorId = operatorId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SendReminderForm_Load(object sender, EventArgs e)
        {
            LoadTravelerEmails();
        }



        private void LoadTravelerEmails()
        {
            string query = @"
                SELECT DISTINCT T.Email 
                FROM Traveler T
                JOIN Booking B ON T.TravelerID = B.TravelerID
                JOIN Trip TR ON B.TripID = TR.TripID
                WHERE TR.OperatorId = @OperatorId
                ORDER BY T.Email";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OperatorId", operatorId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbTo.Items.Clear();

                        while (reader.Read())
                        {
                            cmbTo.Items.Add(reader["Email"].ToString());
                        }

                        if (cmbTo.Items.Count > 0)
                        {
                            cmbTo.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading traveler emails: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Reminder sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
