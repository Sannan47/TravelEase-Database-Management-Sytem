using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class OperatorDashboardForm : Form
    {
        private int operatorId;
        private int bookingId;
        private int tripId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Trust Server Certificate=True";


        public OperatorDashboardForm(int userId)
        {
            InitializeComponent();
            this.operatorId = userId;
            this.tripId = 0;
        }

        private void OperatorDashboardForm_Load(object sender, EventArgs e)
        {

            LoadBookings();
            LoadUpcomingTrips();
            LoadTotalTripsAndRevenue();
            dgvBookings.CellDoubleClick += dgvBookings_CellDoubleClick;
        }

        private void btnManageTrips_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create Trip clicked.");
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Customers clicked.");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generate Report clicked.");
        }

        private void LoadBookings()
        {
            string query = @"
                SELECT 
                    B.BookingID AS BookingID,
                    T.Fname AS Customer,
                    B.Status AS Status,
                    TR.Title AS Trip,
                    TR.Startdate AS Date,
                    B.TotalCost AS Amount
                FROM Booking B
                JOIN Traveler T ON B.TravelerID = T.TravelerID
                JOIN Trip TR ON B.TripID = TR.TripID
                WHERE TR.OperatorID = @OperatorId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@OperatorId", operatorId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    this.bookingId = Convert.ToInt32(dt.Rows[0]["BookingID"]);

                    dgvBookings.AutoGenerateColumns = false;


                    dgvBookings.Columns.Clear();

                    dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Visible = false,
                        DataPropertyName = "BookingID",
                        Name = "BookingID"
                    });

                    dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Customer",
                        HeaderText = "Customer"
                    });
                    dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Status",
                        HeaderText = "Status"
                    });
                    dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Trip",
                        HeaderText = "Trip"
                    });
                    dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Date",
                        HeaderText = "Date"
                    });
                    dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Amount",
                        HeaderText = "Amount",
                        DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
                    });

                    dgvBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUpcomingTrips()
        {
            lstUpcomingTrips.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TripID, Title, StartDate
                    FROM Trip
                    WHERE OperatorID = @OperatorID AND StartDate >= GETDATE()
                    ORDER BY StartDate";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OperatorID", operatorId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int tripId = Convert.ToInt32(reader["TripID"]);
                        string title = reader["Title"].ToString();
                        DateTime startDate = Convert.ToDateTime(reader["StartDate"]);
                        lstUpcomingTrips.Items.Add(new TripListItem
                        {
                            TripID = tripId,
                            DisplayText = $"{title} - {startDate:MMM dd, yyyy}"
                        });
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading upcoming trips: " + ex.Message);
                }
            }
        }

        private void LoadTotalTripsAndRevenue()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        (SELECT COUNT(*) FROM Trip WHERE OperatorID = @OperatorID) AS TotalTrips,
                        (SELECT ISNULL(SUM(B.TotalCost), 0)
                         FROM Booking B
                         JOIN Trip T ON B.TripID = T.TripID
                         WHERE T.OperatorID = @OperatorID) AS TotalRevenue";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OperatorID", operatorId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblTotalTrips.Text = reader["TotalTrips"].ToString();
                        decimal revenue = Convert.ToDecimal(reader["TotalRevenue"]);
                        lblTotalRevenue.Text = $"${revenue:N2}";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading totals: " + ex.Message);
                }
            }
        }


        private void dgvBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBookings.Rows[e.RowIndex];
                this.bookingId = Convert.ToInt32(selectedRow.Cells["BookingID"].Value);

                BookingDetailsForm detailsForm = new BookingDetailsForm(bookingId);
                detailsForm.Show();
            }
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateTrip_Click(object sender, EventArgs e)
        {
            TripCreationForm tripCreationForm = new TripCreationForm(operatorId);
            tripCreationForm.Show();
            this.Hide();
        }

        private void lstUpcomingTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUpcomingTrips.SelectedItem is TripListItem selectedTrip)
            {
                this.tripId = selectedTrip.TripID;
                TripCreationForm tripCreationForm = new TripCreationForm(operatorId, tripId);
                tripCreationForm.Show();
                this.Hide();
            }
        }

        private void btnSendReminder_Click(object sender, EventArgs e)
        {
            SendReminderForm sendReminderForm = new SendReminderForm(operatorId);
            sendReminderForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancellationRequestsForm cancellationRequestsForm = new CancellationRequestsForm(operatorId);
            cancellationRequestsForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}

public class TripListItem
{
    public int TripID { get; set; }
    public string DisplayText { get; set; }

    public override string ToString()
    {
        return DisplayText;
    }
}
