using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ViewItineraryForm : Form
    {

        private int tripId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public ViewItineraryForm(int tripId)
        {
            InitializeComponent();
            this.tripId = tripId;
        }

        private void ViewItineraryForm_Load(object sender, EventArgs e)
        {
            LoadItineraries();
        }

        private void LoadItineraries()
        {
            flowLayoutPanel.Controls.Clear();

            string query = @"
            SELECT DayNumber, Description, Location, Activity
            FROM Itinerary
            WHERE TripID = @TripID
            ORDER BY DayNumber";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TripID", tripId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int day = reader.GetInt32(0);
                            string description = reader.GetString(1);
                            string location = reader.GetString(2);
                            string activity = reader.GetString(3);

                            var label = new Label
                            {
                                AutoSize = true,
                                Margin = new Padding(5),
                                Text = $"Day Number: {day}\nDescription: {description}\nLocation: {location}\nActivity: {activity}"
                            };

                            flowLayoutPanel.Controls.Add(label);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading itineraries: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItinerary_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItineraryForm form = new ItineraryForm(tripId);
            form.ShowDialog();

        }
    }
}
