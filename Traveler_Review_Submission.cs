using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Traveler_Review_Submission : Form
    {
        private int travelerId;
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";


        public Traveler_Review_Submission(int travelerId)
        {
            InitializeComponent();
            this.travelerId = travelerId;
            LoadTrips();
        }

        private void LoadTrips()
        {
            cbTrips.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT DISTINCT T.TripID, T.Title
                FROM Trip T
                INNER JOIN Booking B ON T.TripID = B.TripID
                WHERE B.TravelerID = @travelerId
                  AND NOT EXISTS (
                      SELECT 1 FROM Review R
                      WHERE R.TravelerID = @travelerId AND R.TripID = T.TripID
                  )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@travelerId", travelerId);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tripId = reader["TripID"].ToString();
                    string title = reader["Title"].ToString();
                    cbTrips.Items.Add(new ComboBoxItem(title, tripId));
                }
            }
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (cbTrips.SelectedItem == null || cbRating.SelectedItem == null || string.IsNullOrWhiteSpace(txtComments.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var selectedTrip = cbTrips.SelectedItem as ComboBoxItem;
            int tripId = int.Parse(selectedTrip.Value);
            int rating = int.Parse(cbRating.SelectedItem.ToString());
            string comment = txtComments.Text.Trim();
            int adminId = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getIdCmd = new SqlCommand("SELECT ISNULL(MAX(ReviewID), 0) + 1 FROM Review", conn);
                int reviewId = (int)getIdCmd.ExecuteScalar();

                SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO Review (ReviewID, TravelerID, TripID, AdminID, Rating, Comment, ReviewDate, Status)
                    VALUES (@reviewId, @travelerId, @tripId, @adminId, @rating, @comment, GETDATE(), 'Pending')", conn);

                insertCmd.Parameters.AddWithValue("@reviewId", reviewId);
                insertCmd.Parameters.AddWithValue("@travelerId", travelerId);
                insertCmd.Parameters.AddWithValue("@tripId", tripId);
                insertCmd.Parameters.AddWithValue("@adminId", adminId);
                insertCmd.Parameters.AddWithValue("@rating", rating);
                insertCmd.Parameters.AddWithValue("@comment", comment);
                insertCmd.ExecuteNonQuery();

                SqlCommand getOperatorCmd = new SqlCommand("SELECT OperatorID FROM Trip WHERE TripID = @tripId", conn);
                getOperatorCmd.Parameters.AddWithValue("@tripId", tripId);
                object opObj = getOperatorCmd.ExecuteScalar();
                if (opObj != null)
                {
                    int operatorId = (int)opObj;

                    SqlCommand updateOperatorRating = new SqlCommand(@"
                        UPDATE TourOperator
                        SET Rating = (
                            SELECT AVG(CAST(R.Rating AS FLOAT))
                            FROM Review R
                            JOIN Trip T ON R.TripID = T.TripID
                            WHERE T.OperatorID = @operatorId 
                                AND R.Status IN ('Pending', 'Approved') 
                                AND R.Rating IS NOT NULL
                        )
                        WHERE OperatorID = @operatorId", conn);
                    updateOperatorRating.Parameters.AddWithValue("@operatorId", operatorId);
                    updateOperatorRating.ExecuteNonQuery();
                }

                SqlCommand getProviderCmd = new SqlCommand(@"
                    SELECT TOP 1 SP.ProviderID
                    FROM Service S
                    JOIN ServiceProvider SP ON S.ProviderID = SP.ProviderID
                    WHERE S.TripID = @tripId", conn);
                getProviderCmd.Parameters.AddWithValue("@tripId", tripId);
                object provObj = getProviderCmd.ExecuteScalar();
                if (provObj != null)
                {
                    int providerId = (int)provObj;

                    SqlCommand updateProviderRating = new SqlCommand(@"
                        UPDATE ServiceProvider
                        SET Rating = (
                            SELECT AVG(CAST(R.Rating AS FLOAT))
                            FROM Review R
                            JOIN Trip T ON R.TripID = T.TripID
                            JOIN Service S ON T.TripID = S.TripID
                            WHERE S.ProviderID = @providerId 
                                AND R.Status IN ('Pending', 'Approved') 
                                AND R.Rating IS NOT NULL
                        )
                        WHERE ProviderID = @providerId", conn);
                    updateProviderRating.Parameters.AddWithValue("@providerId", providerId);
                    updateProviderRating.ExecuteNonQuery();
                }

                MessageBox.Show("Review submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cbTrips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString() => Text;
    }
}
