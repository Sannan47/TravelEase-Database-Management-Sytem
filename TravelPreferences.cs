using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class TravelerPreferencesForm : Form
    {
        public int TravelerId { get; set; }

        public TravelerPreferencesForm()
        {
            InitializeComponent();
        }

        public TravelerPreferencesForm(int travelerId)
        {
            InitializeComponent();
            TravelerId = travelerId;
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            List<string> savedPrefs = Database.GetPreferencesForTraveler(TravelerId);

            for (int i = 0; i < clbPreferences.Items.Count; i++)
            {
                if (savedPrefs.Contains(clbPreferences.Items[i].ToString()))
                {
                    clbPreferences.SetItemChecked(i, true);
                }
            }
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(0, 100, 210);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(0, 123, 255);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(200, 45, 60);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(220, 53, 69);
        }



        private void TravelerPreferencesForm_Load(object sender, EventArgs e)
        {

            clbPreferences.Items.Clear();
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Description FROM Preferences";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        clbPreferences.Items.Add(reader["Description"].ToString());
                    }
                }
            }

            LoadPreferences();
        }


        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clbPreferences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            List<string> selectedPrefs = new List<string>();

            foreach (string item in clbPreferences.CheckedItems)
            {
                selectedPrefs.Add(item);
            }
            Database.SaveTravelerPreferences(TravelerId, selectedPrefs);

            MessageBox.Show("Preferences saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public static class Database
    {
        public static List<string> GetPreferencesForTraveler(int travelerId)
        {
            List<string> preferences = new List<string>();
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT P.Description
                         FROM Preferences P
                         INNER JOIN TravelerPreferences TP ON P.PreferenceID = TP.PreferenceID
                         WHERE TP.TravelerID = @travelerId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@travelerId", travelerId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            preferences.Add(reader["Description"].ToString());
                        }
                    }
                }
            }
            return preferences;
        }


        public static void SaveTravelerPreferences(int travelerId, List<string> preferences)
        {

          

            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM TravelerPreferences WHERE TravelerID = @TravelerID", conn))
                {
                    deleteCmd.Parameters.AddWithValue("@TravelerID", travelerId);
                    deleteCmd.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO TravelerPreferences (TravelerID, PreferenceID) VALUES (@TravelerID, @PreferenceID)";

                foreach (var pref in preferences.Distinct())
                {
                    string getIdQuery = "SELECT PreferenceID FROM Preferences WHERE Description = @desc";
                    using (SqlCommand getIdCmd = new SqlCommand(getIdQuery, conn))
                    {
                        getIdCmd.Parameters.AddWithValue("@desc", pref);
                        object prefIdObj = getIdCmd.ExecuteScalar();

                        if (prefIdObj != null)
                        {
                            int prefId = Convert.ToInt32(prefIdObj);

                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.Add("@TravelerID", System.Data.SqlDbType.Int).Value = travelerId;
                                insertCmd.Parameters.Add("@PreferenceID", System.Data.SqlDbType.Int).Value = prefId;
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

            }
        }


    }
}
