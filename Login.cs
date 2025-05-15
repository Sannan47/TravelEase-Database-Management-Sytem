using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string selectedRole = cmbRole.SelectedItem.ToString();
            if (selectedRole == "Traveler")
            {
                Traveler_SignUp Signup = new Traveler_SignUp();
                Signup.Show();
                this.Hide();
            }
            else if (selectedRole == "Tour Operator")
            {
                TourOperatorSignUpForm tourOperatorSignup = new TourOperatorSignUpForm();
                tourOperatorSignup.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sign up is only available for Traveler and Tour Operator roles.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRound_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string selectedRole = cmbRole.SelectedItem.ToString();

            string tableName = "";
            string idColumn = "";
            bool requiresStatusCheck = false;

            if (selectedRole == "Traveler")
            {
                tableName = "Traveler";
                idColumn = "TravelerID";
                requiresStatusCheck = true;
            }
            else if (selectedRole == "Admin")
            {
                tableName = "Admin";
                idColumn = "AdminID";
            }
            else if (selectedRole == "Tour Operator")
            {
                tableName = "TourOperator";
                idColumn = "OperatorID";
                requiresStatusCheck = true;
            }
            else if (selectedRole == "Service Provider")
            {
                tableName = "ServiceProvider";
                idColumn = "ProviderID";
            }
            else
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = $"SELECT {idColumn}" +
                               (requiresStatusCheck ? ", Status" : "") +
                               $" FROM {tableName} WHERE Email = @Email AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader[idColumn]);

                            if (requiresStatusCheck)
                            {
                                string status = reader["Status"].ToString();
                                if (status == "Pending")
                                {
                                    MessageBox.Show("Your account is pending approval. Please wait for admin review.");
                                    return;
                                }
                                else if (status == "Blocked")
                                {
                                    MessageBox.Show("Your account has been blocked. Please contact support.");
                                    return;
                                }
                                else if (status == "Rejected")
                                {
                                    MessageBox.Show("Your registration was rejected. Please contact admin.");
                                    return;
                                }
                            }

                            MessageBox.Show($"Welcome {selectedRole}!");

                            if (selectedRole == "Traveler")
                                new Traveler_Dashboard(userId).Show();
                            else if (selectedRole == "Admin")
                                new AdminDashboardForm().Show();
                            else if (selectedRole == "Tour Operator")
                                new OperatorDashboardForm(userId).Show();
                            else if (selectedRole == "Service Provider")
                                new DashboardForm(userId).Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials.");
                        }
                    }
                }
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports_View reportsForm = new Reports_View();
            reportsForm.Show();
        }
    }
}
