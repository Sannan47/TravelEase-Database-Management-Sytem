using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static TravelEase.BookingForm;
namespace TravelEase
{
    public partial class Traveler_Payment : Form
    {
        private int bookingId;
        private decimal amount;
        private TemporaryBooking tempBooking;
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";


        public Traveler_Payment(TemporaryBooking booking, int amount)
        {
            InitializeComponent();
            if (booking == null)
            {
                MessageBox.Show("Booking information is missing. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.tempBooking = booking;



            this.amount = amount;

            lblHeading.Text = $"Payment - Amount: ${amount:N2}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Processed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            if (tempBooking == null)
            {
                MessageBox.Show("Booking information is not available. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string cardNumber = txtCardNumber.Text.Trim();
            string paymentMethod = txtPaymentMethod.Text.Trim();

            if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(paymentMethod))
            {
                MessageBox.Show("Please fill all payment fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
            {
                MessageBox.Show("Card number must be exactly 16 digits.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getIdCmd = new SqlCommand("SELECT ISNULL(MAX(BookingID), 0) + 1 FROM Booking", conn);
                int bookingId = (int)getIdCmd.ExecuteScalar();

                SqlCommand insertBooking = new SqlCommand(@"
            INSERT INTO Booking (BookingID, TravelerID, TripID, BookingDate, Status, TotalCost, CancellationPolicy)
            VALUES (@bookingId, @travelerId, @tripId, @date, 'Confirmed', @total, 'Standard policy')", conn);

                insertBooking.Parameters.AddWithValue("@bookingId", bookingId);
                insertBooking.Parameters.AddWithValue("@travelerId", tempBooking.TravelerID);
                insertBooking.Parameters.AddWithValue("@tripId", tempBooking.TripID);
                insertBooking.Parameters.AddWithValue("@date", DateTime.Now);
                insertBooking.Parameters.AddWithValue("@total", tempBooking.TotalCost);

                insertBooking.ExecuteNonQuery();

                for (int i = 0; i < tempBooking.NumTravelers; i++)
                {
                    SqlCommand getRoomIdCmd = new SqlCommand("SELECT ISNULL(MAX(RoomBookingID), 0) + 1 FROM RoomBooking", conn);
                    int roomBookingId = (int)getRoomIdCmd.ExecuteScalar();

                    SqlCommand insertRoom = new SqlCommand(@"
            INSERT INTO RoomBooking (RoomBookingID, BookingID, RoomTypeID, RoomNumber, CheckInDate, CheckOutDate)
            VALUES (@roomBookingId, @bookingId, @roomTypeId, @roomNumber, @checkIn, @checkOut)", conn);

                    insertRoom.Parameters.AddWithValue("@roomBookingId", roomBookingId);
                    insertRoom.Parameters.AddWithValue("@bookingId", bookingId);
                    insertRoom.Parameters.AddWithValue("@roomTypeId", tempBooking.RoomTypeID);
                    insertRoom.Parameters.AddWithValue("@roomNumber", "R" + (100 + i));
                    insertRoom.Parameters.AddWithValue("@checkIn", tempBooking.CheckIn);
                    insertRoom.Parameters.AddWithValue("@checkOut", tempBooking.CheckOut);

                    insertRoom.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Payment Processed Successfully! Booking Confirmed.");
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
