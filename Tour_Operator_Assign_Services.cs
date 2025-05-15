using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class AssignServicesForm : Form
    {
        private int tripId;
        private int operatorId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public AssignServicesForm(int tripId, int operatorId)
        {
            InitializeComponent();
            this.tripId = tripId;
            this.operatorId = operatorId;
        }

        private void LoadHotelProviders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ProviderID, FName 
                                 FROM ServiceProvider 
                                 WHERE Type = 'Hotel'";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBoxHotel.DisplayMember = "FName";
                    comboBoxHotel.ValueMember = "ProviderID";
                    comboBoxHotel.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading hotels: {ex.Message}");
                }
            }
        }

        private void AssignServicesForm_Load(object sender, EventArgs e)
        {
            LoadHotelProviders();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Please select a hotel provider first.");
                return;
            }

            int providerId = (int)comboBoxHotel.SelectedValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = @"SELECT COUNT(*) FROM Service 
                            WHERE TripID = @TripID AND ProviderID = @ProviderID";

                string insertQuery = @"INSERT INTO Service (TripID, ProviderID, AssignmentStatus) 
                              VALUES (@TripID, @ProviderID, 'Pending')";

                try
                {
                    conn.Open();

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@TripID", tripId);
                    checkCmd.Parameters.AddWithValue("@ProviderID", providerId);

                    int existingAssignments = (int)checkCmd.ExecuteScalar();

                    if (existingAssignments > 0)
                    {
                        MessageBox.Show("This provider is already assigned to this trip.");
                        return;
                    }

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@TripID", tripId);
                    insertCmd.Parameters.AddWithValue("@ProviderID", providerId);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hotel provider assigned successfully!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign hotel provider.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error assigning service: {ex.Message}");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
