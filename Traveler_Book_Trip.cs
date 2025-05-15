using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelEase
{
    public partial class BookingForm : Form
    {
        private Dictionary<string, (int roomTypeId, decimal price)> roomOptions = new Dictionary<string, (int, decimal)>();


        private decimal tripPrice = 0;

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";


        private int travelerId;
        private string tripTitle;

        public BookingForm(int travelerId, string tripTitle)
        {
            InitializeComponent();
            this.travelerId = travelerId;
            this.tripTitle = tripTitle;
            LoadRoomTypes();
            
            txtTrip.Text = tripTitle;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Price FROM Trip WHERE Title = @title", conn);
                cmd.Parameters.AddWithValue("@title", tripTitle);
                object priceObj = cmd.ExecuteScalar();
                if (priceObj != null)
                    tripPrice = Convert.ToDecimal(priceObj);
            }

            UpdateTotalCost();


            cmbRoomType.SelectedIndexChanged += (s, e) => UpdateTotalCost();
            nudTravelers.ValueChanged += (s, e) => UpdateTotalCost();
        }

        public class TemporaryBooking
        {
            public int TravelerID { get; set; }
            public int TripID { get; set; }
            public decimal TotalCost { get; set; }
            public int RoomTypeID { get; set; }
            public int NumTravelers { get; set; }
            public DateTime CheckIn { get; set; }
            public DateTime CheckOut { get; set; }
        }


        private void LoadRoomTypes()
        {
            roomOptions.Clear();
            cmbRoomType.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                SELECT TypeName, MIN(RoomTypeID) AS RoomTypeID, MIN(Price) AS Price
                FROM RoomType
                GROUP BY TypeName", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["TypeName"].ToString();
                    int id = Convert.ToInt32(reader["RoomTypeID"]);
                    decimal price = Convert.ToDecimal(reader["Price"]);

                    roomOptions[name] = (id, price);
                    cmbRoomType.Items.Add(name);
                }

                reader.Close();
            }

            if (cmbRoomType.Items.Count > 0)
                cmbRoomType.SelectedIndex = 0;
        }


        private decimal UpdateTotalCost()
        {
            if (cmbRoomType.SelectedItem != null)
            {
                string selectedRoom = cmbRoomType.SelectedItem.ToString();
                int quantity = (int)nudTravelers.Value;
                decimal roomPrice = roomOptions[selectedRoom].price;

                decimal total = (tripPrice + roomPrice) * quantity;

                lblCostAmount.Text = $"${total:N2}";
                return total;
            }

            return 0;
        }



        private void lblRoomType_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Fname, Lname, Email FROM Traveler WHERE TravelerID = @id", conn);
                cmd.Parameters.AddWithValue("@id", travelerId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["Fname"].ToString() + " " + reader["Lname"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                }
                txtFullName.ReadOnly = true;
                txtEmail.ReadOnly = true;
            }
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedItem == null)
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getTripCmd = new SqlCommand("SELECT TripID, Price FROM Trip WHERE Title = @title", conn);
                getTripCmd.Parameters.AddWithValue("@title", txtTrip.Text.Trim());

                int tripId = 0;
                decimal tripPrice = 0;
                using (SqlDataReader reader = getTripCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tripId = Convert.ToInt32(reader["TripID"]);
                        tripPrice = Convert.ToDecimal(reader["Price"]);
                    }
                    else
                    {
                        MessageBox.Show("Trip not found.");
                        return;
                    }
                }

                string selectedRoom = cmbRoomType.SelectedItem.ToString();
                var (roomTypeId, roomPrice) = roomOptions[selectedRoom];
                int numTravelers = (int)nudTravelers.Value;

                roomPrice = roomPrice * numTravelers;

                decimal totalCost = (tripPrice + roomPrice);

                TemporaryBooking tempBooking = new TemporaryBooking
                {
                    TravelerID = travelerId,
                    TripID = tripId,
                    TotalCost = totalCost,
                    RoomTypeID = roomTypeId,
                    NumTravelers = numTravelers,
                    CheckIn = DateTime.Today,
                    CheckOut = DateTime.Today.AddDays(7)
                };

                int totalamount = (int)tempBooking.TotalCost;
                Traveler_Payment paymentForm = new Traveler_Payment(tempBooking, totalamount);
                paymentForm.Show();
                this.Hide();
            }
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
