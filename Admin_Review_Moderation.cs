using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelEase
{
    public partial class Admin_Review_Moderation : Form
    {

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public Admin_Review_Moderation()
        {
            InitializeComponent();
            LoadPendingReviews();
        }

        private void LoadPendingReviews()
        {
            dgvReviews.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                SELECT R.ReviewID, 
                       CONCAT(T.Fname, ' ', T.Lname) AS Reviewer, 
                       R.Rating, 
                       R.Comment, 
                       R.Status
                FROM Review R
                JOIN Traveler T ON R.TravelerID = T.TravelerID
                WHERE R.Status = 'Pending'", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvReviews.Rows.Add(
                        reader["ReviewID"],
                        reader["Reviewer"],
                        reader["Rating"],
                        reader["Comment"],
                        reader["Status"]
                    );
                }

                reader.Close();
            }
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Approve logic will be added in Milestone 3.");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reject logic will be added in Milestone 3.");
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to approve.");
                return;
            }

            this.dataGridViewTextBoxColumn1.HeaderText = "Review ID";
            this.dataGridViewTextBoxColumn1.Name = "ReviewID";

            int reviewId = Convert.ToInt32(dgvReviews.SelectedRows[0].Cells["ReviewID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Review SET Status = 'Approved' WHERE ReviewID = @id", conn);
                cmd.Parameters.AddWithValue("@id", reviewId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Review approved successfully.");
            LoadPendingReviews();
        }

        private void btnReject_Click_1(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to reject.");
                return;
            }

            this.dataGridViewTextBoxColumn1.HeaderText = "Review ID";
            this.dataGridViewTextBoxColumn1.Name = "ReviewID";

            int reviewId = Convert.ToInt32(dgvReviews.SelectedRows[0].Cells["ReviewID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Review SET Status = 'Rejected' WHERE ReviewID = @id", conn);
                cmd.Parameters.AddWithValue("@id", reviewId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Review rejected successfully.");
            LoadPendingReviews();
        }
    }
}
