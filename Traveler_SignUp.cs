using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Traveler_SignUp : Form
    {
        public Traveler_SignUp()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRound_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide(); 

        }

        private void btnRound_Click_1(object sender, EventArgs e)
        {
            string fname = txtFName.Text.Trim();
            string lname = txtLName.Text.Trim();
            DateTime dob = dtpDOB.Value;
            string nationality = txtNationality.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;


            if (fname == "" || lname == "" || email == "" || password == "" || nationality == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (dob == DateTime.Today)
            {
                MessageBox.Show("Please select a valid Date of Birth.");
                return;
            }

            if (age < 18)
            {
                MessageBox.Show("Traveler must be at least 18 years old.");
                return;
            }


            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand getIdCmd = new SqlCommand("SELECT ISNULL(MAX(TravelerID), 0) + 1 FROM Traveler", con);
                    int newId = (int)getIdCmd.ExecuteScalar();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Traveler (TravelerID, Fname, Lname, DOB, Nationality, Email, Password) " +
                                                    "VALUES (@id, @fn, @ln, @dob, @nat, @em, @pw)", con);

                    cmd.Parameters.AddWithValue("@id", newId);
                    cmd.Parameters.AddWithValue("@fn", fname);
                    cmd.Parameters.AddWithValue("@ln", lname);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@nat", nationality);
                    cmd.Parameters.AddWithValue("@em", email);
                    cmd.Parameters.AddWithValue("@pw", password); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Traveler registered successfully!");

                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
