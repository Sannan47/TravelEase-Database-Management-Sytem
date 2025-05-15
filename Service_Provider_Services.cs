using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelEase
{
    public partial class ServiceProviderServicesForm : Form
    {
        private int providerId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public ServiceProviderServicesForm(int providerId)
        {
            InitializeComponent();
            this.providerId = providerId;
            LoadHotelData();
        }

        private void LoadHotelData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            H.HotelName,
                            H.Address
                        FROM Hotel H
                        JOIN ServiceProvider SP ON H.ProviderID = SP.ProviderID
                        WHERE SP.ProviderID = @ProviderID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProviderID", providerId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox1.Text = reader["HotelName"].ToString();
                        textBox2.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hotel information found for this provider.", "Information",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading hotel data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in both hotel name and address.", "Validation",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string checkQuery = "SELECT COUNT(*) FROM Hotel WHERE ProviderID = @ProviderID";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction);
                        checkCmd.Parameters.AddWithValue("@ProviderID", providerId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            string updateQuery = @"
                                UPDATE Hotel 
                                SET HotelName = @HotelName, 
                                    Address = @Address
                                WHERE ProviderID = @ProviderID";

                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                            updateCmd.Parameters.AddWithValue("@HotelName", textBox1.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@Address", textBox2.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@ProviderID", providerId);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string insertQuery = @"
                                INSERT INTO Hotel (HotelID, ProviderID, HotelName, Address)
                                VALUES (
                                    (SELECT ISNULL(MAX(HotelID), 0) + 1 FROM Hotel),
                                    @ProviderID,
                                    @HotelName,
                                    @Address)";

                            SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                            insertCmd.Parameters.AddWithValue("@ProviderID", providerId);
                            insertCmd.Parameters.AddWithValue("@HotelName", textBox1.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@Address", textBox2.Text.Trim());
                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Hotel information saved successfully.", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to save hotel information: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving hotel information: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm(providerId);
            dashboardForm.Show();
        }
    }
}