using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TravelEase
{


    public partial class TripDetailsForm : Form
    {

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        private int travelerId;
        private string tripTitle;

        public TripDetailsForm(int travelerId, string tripTitle)
        {
            InitializeComponent();

            this.travelerId = travelerId;
            this.tripTitle = tripTitle;

            LoadTripDetails();

        }

        private void LoadTripDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdTrip = new SqlCommand(@"
                SELECT TOP 1 TripID, Destination, Price, StartDate, EndDate,
                             EcoScore, IsWheelchairFriendly, HasSignLanguageGuide, HasDietaryOptions
                FROM Trip WHERE Title = @title", conn);
                cmdTrip.Parameters.AddWithValue("@title", tripTitle);

                SqlDataReader reader = cmdTrip.ExecuteReader();
                int tripId = -1;

                if (reader.Read())
                {
                    tripId = Convert.ToInt32(reader["TripID"]);

                    lblTitle.Text = "Trip to: " + reader["Destination"].ToString();

                    lblDestination.Text = reader["Destination"].ToString();

                    lblPrice.Text = "$" + Convert.ToDecimal(reader["Price"]).ToString("F2");

                    DateTime startDate = Convert.ToDateTime(reader["StartDate"]);
                    DateTime endDate = Convert.ToDateTime(reader["EndDate"]);
                    lblDates.Text = $"Dates: {startDate:MM/dd/yyyy} - {endDate:MM/dd/yyyy}";

                    string accessibility = "";
                    if ((bool)reader["IsWheelchairFriendly"]) accessibility += "♿ ";
                    if ((bool)reader["HasDietaryOptions"]) accessibility += "🍽️ ";
                    if ((bool)reader["HasSignLanguageGuide"]) accessibility += "👂 ";
                    accessibility += "E:" + reader["EcoScore"].ToString();
                    lblAccessibility.Text = accessibility;
                }
                reader.Close();

                if (tripId == -1) return;

                SqlCommand cmdItinerary = new SqlCommand(@"
                SELECT DayNumber, Description, Location
                FROM Itinerary
                WHERE TripID = @tripId
                ORDER BY DayNumber", conn);
                cmdItinerary.Parameters.AddWithValue("@tripId", tripId);

                reader = cmdItinerary.ExecuteReader();
                dgvItinerary.Rows.Clear();
                while (reader.Read())
                {
                    dgvItinerary.Rows.Add(
                        "Day " + reader["DayNumber"],
                        reader["Description"].ToString(),
                        reader["Location"].ToString()
                    );
                }
                reader.Close();

                SqlCommand cmdInclusions = new SqlCommand(@"
                SELECT Description FROM TripInclusion
                WHERE TripID = @tripId", conn);
                cmdInclusions.Parameters.AddWithValue("@tripId", tripId);

                reader = cmdInclusions.ExecuteReader();
                lstInclusions.Items.Clear();
                while (reader.Read())
                {
                    lstInclusions.Items.Add(reader["Description"].ToString());
                }
                reader.Close();
                SqlCommand cmdHotel = new SqlCommand(@"
                SELECT H.HotelName, H.Address
                FROM Service S
                JOIN ServiceProvider SP ON S.ProviderID = SP.ProviderID
                JOIN Hotel H ON H.ProviderID = SP.ProviderID
                WHERE S.TripID = @tripId AND S.AssignmentStatus = 'Accepted'", conn);
                cmdHotel.Parameters.AddWithValue("@tripId", tripId);

                reader = cmdHotel.ExecuteReader();
                if (reader.Read())
                {
                    lblHotelInfo.Text = $"Hotel: {reader["HotelName"]}\nAddress: {reader["Address"]}";
                }
                else
                {
                    lblHotelInfo.Text = "No hotel assigned for this trip.";
                }


                reader.Close();
            }
        }





        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trip added to cart!");

            
        }


        private void TripDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                int sessionId = GetOrCreateBookingSession(travelerId, conn);

                CartForm cartForm = new CartForm(travelerId, sessionId);
                cartForm.Show();
                this.Hide();
            }
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getIdCmd = new SqlCommand("SELECT TripID FROM Trip WHERE Title = @title", conn);
                getIdCmd.Parameters.AddWithValue("@title", tripTitle);
                int tripId = (int)getIdCmd.ExecuteScalar();

                int sessionId = GetOrCreateBookingSession(travelerId, conn);

                SqlCommand insertCart = new SqlCommand(@"
                INSERT INTO CartItem (SessionID, TripID, Quantity)
                VALUES (@sessionId, @tripId, 1)", conn);
                insertCart.Parameters.AddWithValue("@sessionId", sessionId);
                insertCart.Parameters.AddWithValue("@tripId", tripId);

                try
                {
                    insertCart.ExecuteNonQuery();
                    MessageBox.Show("Trip added to cart!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Already in cart or error: " + ex.Message);
                }
            }
        }

        private int GetOrCreateBookingSession(int travelerId, SqlConnection conn)
        {
            SqlCommand check = new SqlCommand(@"
            SELECT TOP 1 SessionID FROM BookingSession
            WHERE TravelerID = @tid AND Status = 'Active'", conn);
            check.Parameters.AddWithValue("@tid", travelerId);
            object result = check.ExecuteScalar();

            if (result != null) return (int)result;

            SqlCommand create = new SqlCommand(@"
            INSERT INTO BookingSession (TravelerID, StartTime, Status)
            OUTPUT INSERTED.SessionID
            VALUES (@tid, @start, 'Active')", conn);
            create.Parameters.AddWithValue("@tid", travelerId);
            create.Parameters.AddWithValue("@start", DateTime.Now);

            return (int)create.ExecuteScalar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Traveler_Trip_Search traveler_Trip_Search = new Traveler_Trip_Search(travelerId);
            traveler_Trip_Search.Show();
            this.Hide();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblAccessibility_Click(object sender, EventArgs e)
        {

        }
    }
}
