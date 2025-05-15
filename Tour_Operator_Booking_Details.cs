using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class BookingDetailsForm : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        private int bookingId;

        public BookingDetailsForm(int bookingId)
        {
            InitializeComponent();
            this.bookingId = bookingId;
        }

        private void BookingDetailsForm_Load(object sender, EventArgs e)
        {
            LoadBookingDetails();
            LoadRoomBookings();
        }

        private void LoadBookingDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        b.BookingID,
                        t.FName AS CustomerName,
                        t.Email,
                        tr.Title,
                        b.BookingDate,
                        b.Status,
                        b.TotalCost
                    FROM Booking b
                    JOIN Traveler t ON b.TravelerID = t.TravelerID
                    JOIN Trip tr ON b.TripID = tr.TripID
                    WHERE b.BookingID = @BookingID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblCustomer.Text = reader["CustomerName"].ToString();
                    lblContactInfo.Text = reader["Email"].ToString();
                    lblTripName.Text = reader["Title"].ToString();
                    lblBookingDate.Text = Convert.ToDateTime(reader["BookingDate"]).ToString("dd MMM yyyy");
                    lblStatus.Text = reader["Status"].ToString();
                    lblAmount.Text = reader["TotalCost"].ToString();
                }

                reader.Close();

            }
        }

        private void LoadRoomBookings()
        {
            string query = @"
                SELECT 
                    RB.RoomNumber,
                    RT.TypeName AS RoomType,
                    RT.Price,
                    H.HotelName AS Hotel,
                    RB.CheckInDate,
                    RB.CheckOutDate
                FROM RoomBooking RB
                JOIN RoomType RT ON RB.RoomTypeID = RT.RoomTypeID
                JOIN Hotel H ON RT.HotelID = H.HotelID
                WHERE RB.BookingID = @BookingID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRoomBookings.DataSource = dt;

                    dgvRoomBookings.Columns["Price"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room bookings: " + ex.Message);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking cancelled.");
        }

        private void btnViewPaymentHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying payment history...");
        }

        private void btnViewAddRefunds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing/adding refunds...");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}