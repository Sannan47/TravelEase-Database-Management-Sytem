using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Tour_Operator_Trip_Inclusions_Create : Form
    {
        private int tripId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public Tour_Operator_Trip_Inclusions_Create(int tripId)
        {
            InitializeComponent();
            this.tripId = tripId;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inclusion details saved.");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text.Trim();

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter a description for the inclusion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "INSERT INTO TripInclusion (InclusionID, TripID, Description) VALUES (@InclusionID, @TripID, @Description)";

                using (SqlCommand command = new SqlCommand(query, connection))
                { 
                    try
                    {
                        connection.Open();
                        string getIDQuery = "SELECT ISNULL(MAX(InclusionID), 0) + 1 FROM TripInclusion";
                        SqlCommand getIDCmd = new SqlCommand(getIDQuery, connection);
                        int inclusionId = (int)getIDCmd.ExecuteScalar();

                        command.Parameters.AddWithValue("@InclusionID", inclusionId);
                        command.Parameters.AddWithValue("@TripID", tripId);
                        command.Parameters.AddWithValue("@Description", description);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inclusion added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            ViewInclusionsForm form = new ViewInclusionsForm(tripId);
                            form.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add inclusion. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the inclusion:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInclusionsForm form = new ViewInclusionsForm(tripId);
            form.ShowDialog();

        }

    }
}
