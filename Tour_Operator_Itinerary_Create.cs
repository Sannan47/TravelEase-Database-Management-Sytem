using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ItineraryForm : Form
    {
        private int tripId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public ItineraryForm(int tripId)
        {
            InitializeComponent();
            this.tripId = tripId;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itinerary details saved.");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDayNumber.Text, out int dayNumber))
            {
                MessageBox.Show("Please enter a valid numeric day number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = textBoxDescription.Text.Trim();
            string location = textBoxLocation.Text.Trim();
            string activity = textBoxActivity.Text.Trim();

            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(activity))
            {
                MessageBox.Show("All fields must be filled in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = @"
                INSERT INTO Itinerary (TripID, DayNumber, Description, Location, Activity)
                VALUES (@TripID, @Day, @Description, @Location, @Activity)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@TripID", tripId);
                cmd.Parameters.AddWithValue("@Day", dayNumber);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@Activity", activity);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Itinerary added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewItineraryForm viewItineraryForm = new ViewItineraryForm(tripId);
                    viewItineraryForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save itinerary:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewItineraryForm form = new ViewItineraryForm(tripId);
            form.ShowDialog();

        }
    }
}
