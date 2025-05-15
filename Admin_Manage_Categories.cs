using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelEase
{
    public partial class Admin_Manage_Categories : Form
    {

        private string connectionString = @"Data Source=\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";
        public Admin_Manage_Categories()
        {
            InitializeComponent();
            dgvCategories.CellClick += dgvCategories_CellClick;

            txtCategoryName.TextChanged += txtCategoryName_TextChanged;
            txtCategoryDescription.TextChanged += txtCategoryDescription_TextChanged;

            btnAdd.Enabled = false;

            LoadCategories();
            
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCategoryName.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCategoryDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }


        private void LoadCategories()
        {
            dgvCategories.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CategoryID, Name, Description FROM TourCategory", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvCategories.Rows.Add(
                            reader["CategoryID"],
                            reader["Name"],
                            reader["Description"]
                        );
                    }
                }
            }
        }


        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtCategoryName.Text) && !string.IsNullOrWhiteSpace(txtCategoryDescription.Text);
        }

        private void txtCategoryDescription_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtCategoryName.Text) && !string.IsNullOrWhiteSpace(txtCategoryDescription.Text);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Category logic will be implemented in Milestone 3.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Category logic will be implemented in Milestone 3.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Category logic will be implemented in Milestone 3.");
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Category Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoryDescription.Text))
            {
                MessageBox.Show("Category Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getIdCmd = new SqlCommand("SELECT ISNULL(MAX(CategoryID), 0) + 1 FROM TourCategory", conn);
                int newCategoryId = (int)getIdCmd.ExecuteScalar();

                SqlCommand cmd = new SqlCommand(@"
                INSERT INTO TourCategory (CategoryID, Name, Description) 
                VALUES (@id, @name, @desc)", conn);

                cmd.Parameters.AddWithValue("@id", newCategoryId);
                cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", txtCategoryDescription.Text.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category added successfully!");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to add category.");
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to update.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                UPDATE TourCategory 
                SET Name = @name, Description = @desc 
                WHERE CategoryID = @id", conn);

                cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                cmd.Parameters.AddWithValue("@desc", txtCategoryDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@id", categoryId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category updated successfully!");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to update category.");
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM TourCategory WHERE CategoryID = @id", conn);
                cmd.Parameters.AddWithValue("@id", categoryId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category deleted successfully!");
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to delete category.");
                }
            }
        }
    }
}
