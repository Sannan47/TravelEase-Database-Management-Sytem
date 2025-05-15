using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEase;

namespace WindowsFormsApp1
{
    public partial class Traveler_Trip_Search : Form
    {


        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        private int travelerId;
        public Traveler_Trip_Search(int travelerId)
        {
            InitializeComponent();
            this.travelerId = travelerId;
            AddViewDetailsButton();

        }

        private void LoadTripsFromDatabase()
        {
            dgvTrips.Columns.Clear();
            dgvTrips.Rows.Clear();

            dgvTrips.Columns.Add("TripTitle", "Trip Title");
            dgvTrips.Columns.Add("Destination", "Destination");
            dgvTrips.Columns.Add("Price", "Price");
            AddViewDetailsButton(); 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                StringBuilder query = new StringBuilder(@"
            SELECT Title AS TripTitle, Destination, Price
            FROM Trip
            WHERE 1=1");

                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrWhiteSpace(txtDestination.Text))
                {
                    query.Append(" AND Destination LIKE @dest");
                    cmd.Parameters.AddWithValue("@dest", "%" + txtDestination.Text + "%");
                }

                if (nudMinPrice.Value > 0)
                {
                    query.Append(" AND Price >= @minPrice");
                    cmd.Parameters.AddWithValue("@minPrice", nudMinPrice.Value);
                }

                if (nudMaxPrice.Value > 0)
                {
                    query.Append(" AND Price <= @maxPrice");
                    cmd.Parameters.AddWithValue("@maxPrice", nudMaxPrice.Value);
                }

                query.Append(" AND StartDate >= @start");
                cmd.Parameters.AddWithValue("@start", dtpStartDate.Value.Date);

                query.Append(" AND EndDate <= @end");
                cmd.Parameters.AddWithValue("@end", dtpEndDate.Value.Date);

                if (chkWheelchair.Checked)
                    query.Append(" AND IsWheelchairFriendly = 1");

                if (chkSignLanguage.Checked)
                    query.Append(" AND HasSignLanguageGuide = 1");

                if (chkDietary.Checked)
                    query.Append(" AND HasDietaryOptions = 1");

                if (nudEcoScore.Value > 0)
                {
                    query.Append(" AND EcoScore >= @eco");
                    cmd.Parameters.AddWithValue("@eco", nudEcoScore.Value);
                }

                cmd.CommandText = query.ToString();
                cmd.Connection = conn;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvTrips.Rows.Add(reader["TripTitle"], reader["Destination"], "$" + Convert.ToDecimal(reader["Price"]).ToString("F2"));
                }
            }
        }




        private void AddViewDetailsButton()
        {
            DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn();
            btnDetails.HeaderText = "Action";
            btnDetails.Text = "View Details";
            btnDetails.UseColumnTextForButtonValue = true;
            btnDetails.Name = "btnDetails";
            dgvTrips.Columns.Add(btnDetails);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrips.Columns[e.ColumnIndex].Name == "btnDetails" && e.RowIndex >= 0)
            {
                string selectedTrip = dgvTrips.Rows[e.RowIndex].Cells["TripTitle"].Value.ToString();

                TripDetailsForm detailsForm = new TripDetailsForm(travelerId, selectedTrip);
                detailsForm.Show();

                this.Hide();
            }
        }


        private void grpFilters_Enter(object sender, EventArgs e)
        {

        }

        private void Traveler_Trip_Search_Load(object sender, EventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTripsFromDatabase();
        }
    }
}
