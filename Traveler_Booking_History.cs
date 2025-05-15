using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BookingHistoryForm : Form
    {

        private int travelerId;
        public BookingHistoryForm(int travelerId)
        {
            InitializeComponent();
            this.travelerId = travelerId;
            LoadBookingHistory();
        }


        private void LoadBookingHistory()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        B.BookingID AS [Booking ID],
                        T.Title AS [Trip Name],
                        T.StartDate AS [Date],
                        B.Status,
                        CONCAT(FORMAT(B.TotalCost, 'N0'), ' PKR') AS [Amount Paid]
                    FROM Booking B
                    JOIN Trip T ON B.TripID = T.TripID
                    WHERE B.TravelerID = @travelerId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@travelerId", travelerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBookingHistory.DataSource = dt;
            }
        }


        private void BookingHistoryForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBookingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
