using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class TourOperatorSignUpForm : Form
    {

        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        public TourOperatorSignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string getIDQuery = "SELECT ISNULL(MAX(OperatorID), 0) + 1 FROM TourOperator";
                string checkEmailQuery = "SELECT COUNT(*) FROM TourOperator WHERE Email = @Email";
                string insertQuery = @"INSERT INTO TourOperator (OperatorID, CompanyName, Email, Phone, Password, Rating)
                                       VALUES (@OperatorID, @Name, @Email, @Phone, @PasswordHash, 0)";

                try
                {
                    conn.Open();

                    SqlCommand getIDCmd = new SqlCommand(getIDQuery, conn);
                    int newID = (int)getIDCmd.ExecuteScalar();
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@OperatorID", newID); 
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@PasswordHash", password); 

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OperatorDashboardForm operatorDashboardForm = new OperatorDashboardForm(newID);
                    operatorDashboardForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
