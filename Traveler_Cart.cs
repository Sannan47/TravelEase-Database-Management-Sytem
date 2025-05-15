using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelEase
{
    public partial class CartForm : Form
    {
        private DataTable cartTable;

        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";

        private int travelerId;
        private int sessionId;

        public CartForm(int travelerId, int sessionId)
        {
            InitializeComponent();
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click_1);
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click_1);
            this.travelerId = travelerId;
            this.sessionId = sessionId;
            LoadCartDataFromDB();
        }

        private void LoadCartDataFromDB()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("Trip Title");
            cartTable.Columns.Add("Destination");
            cartTable.Columns.Add("Price Per Person", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Subtotal", typeof(decimal), "[Price Per Person] * Quantity");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand getCartItems = new SqlCommand(@"
                SELECT T.Title, T.Destination, T.Price, C.Quantity
                FROM CartItem C
                JOIN Trip T ON C.TripID = T.TripID
                WHERE C.SessionID = @sid", conn);
                getCartItems.Parameters.AddWithValue("@sid", sessionId);

                SqlDataReader reader = getCartItems.ExecuteReader();
                while (reader.Read())
                {
                    cartTable.Rows.Add(
                        reader["Title"].ToString(),
                        reader["Destination"].ToString(),
                        Convert.ToDecimal(reader["Price"]),
                        Convert.ToInt32(reader["Quantity"])
                    );
                }
                reader.Close();
            }

            dgvCart.DataSource = cartTable;
            UpdateTotalLabel();
        }


        private void UpdateTotalLabel()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
                total += (decimal)row["Subtotal"];

            lblTotal.Text = $"Total: ${total:N2}";
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCart.SelectedRows)
            {
                dgvCart.Rows.RemoveAt(row.Index);
            }
            UpdateTotalLabel();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cartTable.Clear();
            UpdateTotalLabel();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProceedToBooking_Click_1(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                string selectedTrip = dgvCart.SelectedRows[0].Cells["Trip Title"].Value.ToString();
                BookingForm bookingForm = new BookingForm(travelerId, selectedTrip);
                bookingForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a trip from the cart to book.");
            }
        }


        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnClearCart_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand clearCmd = new SqlCommand(
                    "DELETE FROM CartItem WHERE SessionID = @sid", conn);
                clearCmd.Parameters.AddWithValue("@sid", sessionId);

                clearCmd.ExecuteNonQuery();
            }

            cartTable.Clear();
            UpdateTotalLabel();
            MessageBox.Show("Cart cleared.");
        }

        private void btnRemoveSelected_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvCart.SelectedRows)
                {
                    string tripTitleToRemove = row.Cells["Trip Title"].Value.ToString();

                    SqlCommand getTripIdCmd = new SqlCommand(
                        "SELECT TripID FROM Trip WHERE Title = @title", conn);
                    getTripIdCmd.Parameters.AddWithValue("@title", tripTitleToRemove);
                    int tripId = (int)getTripIdCmd.ExecuteScalar();

                    SqlCommand deleteCmd = new SqlCommand(
                        "DELETE FROM CartItem WHERE SessionID = @sid AND TripID = @tid", conn);
                    deleteCmd.Parameters.AddWithValue("@sid", sessionId);
                    deleteCmd.Parameters.AddWithValue("@tid", tripId);

                    deleteCmd.ExecuteNonQuery();

                    dgvCart.Rows.RemoveAt(row.Index);
                }
            }

            UpdateTotalLabel();
            MessageBox.Show("Selected item(s) removed.");
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
