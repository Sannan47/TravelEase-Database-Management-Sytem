using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelEase
{
    public partial class AdminUserOperatorForm : Form
    {

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public AdminUserOperatorForm()
        {
            InitializeComponent();

            LoadDataFromDatabase();

            dgvUsersOperators.SelectionChanged += dgvUsersOperators_SelectionChanged;

        }

        private void LoadDataFromDatabase()
        {
            dgvUsersOperators.Rows.Clear();
            dgvUsersOperators.Columns.Clear();

            dgvUsersOperators.Columns.Add("ID", "ID");
            dgvUsersOperators.Columns.Add("Name", "Name");
            dgvUsersOperators.Columns.Add("Role", "Role");
            dgvUsersOperators.Columns.Add("Status", "Status");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdTravelers = new SqlCommand("SELECT TravelerID AS ID, CONCAT(Fname, ' ', Lname) AS Name, 'Traveler' AS Role, Status FROM Traveler WHERE Status IN ('Pending', 'Blocked', 'Rejected')", conn);
                SqlDataReader reader = cmdTravelers.ExecuteReader();

                while (reader.Read())
                {
                    dgvUsersOperators.Rows.Add(
                        reader["ID"],
                        reader["Name"],
                        reader["Role"],
                        reader["Status"]
                    );
                }
                reader.Close();

                SqlCommand cmdOperators = new SqlCommand("SELECT OperatorID AS ID, CompanyName AS Name, 'Operator' AS Role, Status FROM TourOperator WHERE Status IN ('Pending', 'Blocked', 'Rejected')", conn);
                reader = cmdOperators.ExecuteReader();

                while (reader.Read())
                {
                    dgvUsersOperators.Rows.Add(
                        reader["ID"],
                        reader["Name"],
                        reader["Role"],
                        reader["Status"]
                    );
                }
                reader.Close();
            }
        }


        private void UpdateUserStatus(string newStatus)
        {
            if (dgvUsersOperators.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user or operator.");
                return;
            }

            string id = dgvUsersOperators.SelectedRows[0].Cells["ID"].Value.ToString();
            string role = dgvUsersOperators.SelectedRows[0].Cells["Role"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery;

                if (role == "Traveler")
                {
                    updateQuery = "UPDATE Traveler SET Status = @status WHERE TravelerID = @id";
                }
                else if (role == "Operator")
                {
                    updateQuery = "UPDATE TourOperator SET Status = @status WHERE OperatorID = @id";
                }
                else
                {
                    MessageBox.Show("Invalid role type.");
                    return;
                }

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show($"{role} status updated to '{newStatus}'.");
            LoadDataFromDatabase();
        }

        private void dgvUsersOperators_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvUsersOperators.SelectedRows.Count > 0;
            btnApprove.Enabled = hasSelection;
            btnReject.Enabled = hasSelection;
            btnBlock.Enabled = hasSelection;
            btnUnblock.Enabled = hasSelection;
        }


        private void AdminUserOperatorForm_Load(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Rejected");
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Blocked");
        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {
            UpdateUserStatus("Approved");
        }
    }
}
