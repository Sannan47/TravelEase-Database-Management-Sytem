using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class EditTravelerProfileForm : Form
    {
        private int travelerId;
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";



        public EditTravelerProfileForm(int travelerId)
        {
            InitializeComponent();
            this.Load += EditTravelerProfileForm_Load;
            this.travelerId = travelerId;

        }

        private void EditTravelerProfileForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Fname, Lname, Email, Password, DOB, Nationality FROM Traveler WHERE TravelerID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", travelerId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFirstName.Text = reader["Fname"].ToString();
                    txtLastName.Text = reader["Lname"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(reader["DOB"]);
                    txtNationality.Text = reader["Nationality"].ToString();
                }
            }
        }


        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
        string.IsNullOrWhiteSpace(txtLastName.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string updateQuery = @"
            UPDATE Traveler
            SET Fname = @fname,
                Lname = @lname,
                Email = @email,
                Password = @password,
                DOB = @dob,
                Nationality = @nationality
            WHERE TravelerID = @id";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@nationality", txtNationality.Text.Trim());
                cmd.Parameters.AddWithValue("@id", travelerId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
