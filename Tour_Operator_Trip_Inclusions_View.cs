using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ViewInclusionsForm : Form
    {

        private int tripId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public ViewInclusionsForm(int tripId)
        {
            InitializeComponent();
            this.tripId = tripId;
        }

        private void ViewInclusionsForm_Load(object sender, EventArgs e)
        {
            LoadInclusions();
        }

        private void LoadInclusions()
        {
            flowLayoutPanel.Controls.Clear();

            string query = "SELECT Description FROM TripInclusion WHERE TripID = @TripID";

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
                            string inclusion = reader["Description"].ToString();

                            var label = new Label
                            {
                                AutoSize = true,
                                Margin = new Padding(5),
                                Text = $"- {inclusion}"
                            };
                            flowLayoutPanel.Controls.Add(label);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inclusions: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddInclusion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tour_Operator_Trip_Inclusions_Create tour_Operator_Trip_Inclusions_Create = new Tour_Operator_Trip_Inclusions_Create(tripId);
            tour_Operator_Trip_Inclusions_Create.ShowDialog();
        }
    }
}
