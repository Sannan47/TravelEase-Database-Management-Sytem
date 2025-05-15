using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class TripCreationForm : Form
    {
        private int operatorId;
        private int? tripId = null;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public TripCreationForm(int operatorId, int? tripId = null)
        {
            InitializeComponent();
            this.operatorId = operatorId;
            this.tripId = tripId;
        }

        private void loadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CategoryID, Name FROM TourCategory", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryID";
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text) ||
                !decimal.TryParse(txtPrice.Text, out _) ||
                !int.TryParse(txtEcoScore.Text, out int score) || score < 0 || score > 5 ||
                dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                MessageBox.Show("Please enter valid trip details.");
                return false;
            }
            return true;
        }

        private void TripCreationForm_Load_1(object sender, EventArgs e)
        {
            loadCategories();
            if (tripId.HasValue)
            {
                LoadTripDetails(tripId.Value);
                btnSave.Text = "Update Trip";
            }
        }
        private void LoadTripDetails(int tripId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Trip WHERE TripID = @TripID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TripID", tripId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmbCategory.SelectedValue = reader["CategoryID"];
                            txtTitle.Text = reader["Title"].ToString();
                            txtDestination.Text = reader["Destination"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                            dtpStartDate.Value = Convert.ToDateTime(reader["StartDate"]);
                            dtpEndDate.Value = Convert.ToDateTime(reader["EndDate"]);
                            chkWheelchair.Checked = Convert.ToBoolean(reader["IsWheelchairFriendly"]);
                            chkSignLanguage.Checked = Convert.ToBoolean(reader["HasSignLanguageGuide"]);
                            chkDietary.Checked = Convert.ToBoolean(reader["HasDietaryOptions"]);
                            txtEcoScore.Text = reader["EcoScore"].ToString();
                        }
                    }
                }
            }
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query;

                    if (tripId.HasValue) // Update existing
                    {
                        query = @"UPDATE Trip SET CategoryID = @CategoryID, Title = @Title, Destination = @Destination,
                          Price = @Price, StartDate = @StartDate, EndDate = @EndDate,
                          IsWheelchairFriendly = @Wheelchair, HasSignLanguageGuide = @SignLang,
                          HasDietaryOptions = @Dietary, EcoScore = @EcoScore
                          WHERE TripID = @TripID";
                    }
                    else // Insert new
                    {
                        string getIDQuery = "SELECT ISNULL(MAX(TripID), 0) + 1 FROM Trip";
                        SqlCommand getIDCmd = new SqlCommand(getIDQuery, conn);
                        tripId = (int)getIDCmd.ExecuteScalar();

                        query = @"INSERT INTO Trip (TripID, OperatorID, CategoryID, Title, Destination, Price, StartDate, EndDate,
                          IsWheelchairFriendly, HasSignLanguageGuide, HasDietaryOptions, EcoScore)
                          VALUES (@TripID, @OperatorID, @CategoryID, @Title, @Destination, @Price, @StartDate, @EndDate,
                          @Wheelchair, @SignLang, @Dietary, @EcoScore)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TripID", tripId.Value);
                        cmd.Parameters.AddWithValue("@OperatorID", operatorId);
                        cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@Destination", txtDestination.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Wheelchair", chkWheelchair.Checked);
                        cmd.Parameters.AddWithValue("@SignLang", chkSignLanguage.Checked);
                        cmd.Parameters.AddWithValue("@Dietary", chkDietary.Checked);
                        cmd.Parameters.AddWithValue("@EcoScore", int.Parse(txtEcoScore.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show(tripId.HasValue ? "Trip updated successfully!" : "Trip created successfully!");
                    }
                }
            }

        }

        private void btnManageItinerary_Click(object sender, EventArgs e)
        {
            if (tripId == null)
            {
                MessageBox.Show("Please create a trip first.");
                return;
            }
            else
            {
                ViewItineraryForm viewItineraryForm = new ViewItineraryForm((int)tripId);
                viewItineraryForm.ShowDialog();

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            OperatorDashboardForm f = new OperatorDashboardForm(operatorId);
            f.Show();
            this.Hide();
        }

        private void btnManageInclusions_Click(object sender, EventArgs e)
        {
            if (tripId == null)
            {
                MessageBox.Show("Please create a trip first.");
                return;
            }
            else
            {
                ViewInclusionsForm viewInclusionsForm = new ViewInclusionsForm((int)tripId);
                viewInclusionsForm.ShowDialog();
            }
        }

        private void btnAssignServices_Click(object sender, EventArgs e)
        {
            if (tripId == null)
            {
                MessageBox.Show("Please create a trip first.");
                return;
            }
            else
            {
                AssignServicesForm AssignServicesForm = new AssignServicesForm((int)tripId, operatorId);
                AssignServicesForm.ShowDialog();
            }

        }
    }
}
