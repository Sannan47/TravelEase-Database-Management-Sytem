using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelEase
{
    public partial class Admin_Platform_Analytics : Form
    {

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public Admin_Platform_Analytics()
        {
            InitializeComponent();
            lstUserTraffic.Columns.Add("Date", 150);
            lstUserTraffic.Columns.Add("Visitors", 150);
            LoadDataFromDatabase();
        }

        private void PlatformAnalyticsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDataFromDatabase()
        {
            dgvBookingTrends.Rows.Clear();
            dgvRevenue.Rows.Clear();
            lstUserTraffic.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdBookingTrends = new SqlCommand(@"
                SELECT 
                    DATENAME(MONTH, BookingDate) AS Month, 
                    COUNT(*) AS Bookings 
                FROM Booking 
                GROUP BY DATENAME(MONTH, BookingDate), MONTH(BookingDate) 
                ORDER BY MONTH(BookingDate);", conn);

                using (SqlDataReader reader = cmdBookingTrends.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvBookingTrends.Rows.Add(
                            reader["Month"].ToString(),
                            reader["Bookings"].ToString()
                        );
                    }
                }

                SqlCommand cmdRevenue = new SqlCommand(@"
                SELECT 
                    DATENAME(MONTH, PaymentDate) AS Month, 
                    SUM(Amount) AS Revenue 
                FROM Payment 
                WHERE Status = 'Success' 
                GROUP BY DATENAME(MONTH, PaymentDate), MONTH(PaymentDate) 
                ORDER BY MONTH(PaymentDate);", conn);

                using (SqlDataReader reader = cmdRevenue.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvRevenue.Rows.Add(
                            reader["Month"].ToString(),
                            $"${reader["Revenue"]:N2}"
                        );
                    }
                }

                SqlCommand cmdUserTraffic = new SqlCommand(@"
                SELECT 
                    CAST(StartTime AS DATE) AS Date, 
                    COUNT(*) AS SessionCount 
                FROM BookingSession 
                GROUP BY CAST(StartTime AS DATE) 
                ORDER BY Date DESC;", conn);

                using (SqlDataReader reader = cmdUserTraffic.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstUserTraffic.Items.Add(new ListViewItem(new[] {
                    reader["Date"].ToString(),
                    reader["SessionCount"].ToString() + " Visitors"
                }));
                    }
                }
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
