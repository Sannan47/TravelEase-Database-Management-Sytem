using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApp1;

namespace TravelEase
{
    public partial class DigitalTravelPassForm : Form
    {
        private int travelerId;
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";


        public DigitalTravelPassForm(int travelerId)
        {
            InitializeComponent();
            this.travelerId = travelerId;

            cbBooking.SelectedIndexChanged += cbBooking_SelectedIndexChanged;

            LoadBookingOptions();

        }

        private void LoadBookingOptions()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT DISTINCT BookingID, Title
            FROM DigitalTravelPass
            WHERE TravelerID = @travelerId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@travelerId", travelerId);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string bookingId = reader["BookingID"].ToString();
                    string title = reader["Title"].ToString();
                    cbBooking.Items.Add(new ComboBoxItem(title + " [Booking #" + bookingId + "]", bookingId));
                }
            }

            if (cbBooking.Items.Count > 0)
                cbBooking.SelectedIndex = 0; 
        }



        private void LoadDTP(string bookingId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT * 
            FROM DigitalTravelPass
            WHERE TravelerID = @travelerId AND BookingID = @bookingId
            ORDER BY DayNumber";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@travelerId", travelerId);
                cmd.Parameters.AddWithValue("@bookingId", bookingId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    lblTripTitle.Text = "Trip: " + row["Title"];
                    lblDestination.Text = "Destination: " + row["Destination"];
                    lblDates.Text = "Dates: " + Convert.ToDateTime(row["StartDate"]).ToShortDateString() +
                                    " to " + Convert.ToDateTime(row["EndDate"]).ToShortDateString();

                    lblHotelName.Text = "Hotel: " + (row["HotelName"] == DBNull.Value ? "N/A" : row["HotelName"].ToString());
                    lblRoomType.Text = "Room: " + (row["RoomType"] == DBNull.Value ? "N/A" : row["RoomType"].ToString());

                    if (!Convert.IsDBNull(row["CheckInDate"]) && !Convert.IsDBNull(row["CheckOutDate"]))
                    {
                        lblCheckInOut.Text = "Check-In: " + Convert.ToDateTime(row["CheckInDate"]).ToShortDateString()
                                           + " - Check-Out: " + Convert.ToDateTime(row["CheckOutDate"]).ToShortDateString();
                    }
                    else
                    {
                        lblCheckInOut.Text = "Check-In/Out: N/A";
                    }

                    var itineraryTable = dt.DefaultView.ToTable(true, "DayNumber", "ItineraryDesc", "Activity");
                    dgvItinerary.DataSource = itineraryTable;

                    var inclusions = dt.AsEnumerable()
                                       .Select(r => r["Inclusion"].ToString())
                                       .Where(i => !string.IsNullOrWhiteSpace(i))
                                       .Distinct();

                    listInclusions.Items.Clear();
                    foreach (var item in inclusions)
                    {
                        listInclusions.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No travel pass data found for this booking.");
                }
            }
        }
        private void cbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBooking.SelectedItem is ComboBoxItem selected)
            {
                LoadDTP(selected.Value);
            }
        }


        private void DigitalTravelPassForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

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
}
