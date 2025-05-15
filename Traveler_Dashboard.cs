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
using TravelEase;

namespace WindowsFormsApp1
{
    public partial class Traveler_Dashboard : Form
    {
        private int travelerId;
        private int sessionId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public Traveler_Dashboard(int travelerId)
        {
            InitializeComponent();
            this.travelerId = travelerId;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                sessionId = GetOrCreateBookingSession(travelerId, conn);
            }



            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);

            this.pictureBox7.MouseEnter += new System.EventHandler(this.pictureBox7_MouseEnter);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox7_MouseLeave);

            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);

        }

        private int GetOrCreateBookingSession(int travelerId, SqlConnection conn)
        {
            SqlCommand check = new SqlCommand(@"
            SELECT TOP 1 SessionID FROM BookingSession
            WHERE TravelerID = @tid AND Status = 'Active'", conn);
            check.Parameters.AddWithValue("@tid", travelerId);
            object result = check.ExecuteScalar();

            if (result != null) return (int)result;

            SqlCommand create = new SqlCommand(@"
            INSERT INTO BookingSession (TravelerID, StartTime, Status)
            OUTPUT INSERTED.SessionID
            VALUES (@tid, @start, 'Active')", conn);
            create.Parameters.AddWithValue("@tid", travelerId);
            create.Parameters.AddWithValue("@start", DateTime.Now);

            return (int)create.ExecuteScalar();
        }

        private void Traveler_Dashboard_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string tripQuery = @"SELECT Title, Destination, StartDate 
                             FROM Trip 
                             INNER JOIN Booking ON Trip.TripID = Booking.TripID 
                             WHERE Booking.TravelerID = @travelerId AND StartDate >= GETDATE()";

                SqlCommand cmdTrips = new SqlCommand(tripQuery, conn);
                cmdTrips.Parameters.AddWithValue("@travelerId", travelerId);

                SqlDataAdapter adapterTrips = new SqlDataAdapter(cmdTrips);
                DataTable dtTrips = new DataTable();
                adapterTrips.Fill(dtTrips);
                dataGridView1.DataSource = dtTrips;


                string bookingQuery = @"SELECT TripID, Status, TotalCost 
                                FROM Booking 
                                WHERE TravelerID = @travelerId";

                SqlCommand cmdBookings = new SqlCommand(bookingQuery, conn);
                cmdBookings.Parameters.AddWithValue("@travelerId", travelerId);

                SqlDataAdapter adapterBookings = new SqlDataAdapter(cmdBookings);
                DataTable dtBookings = new DataTable();
                adapterBookings.Fill(dtBookings);
                dataGridView2.DataSource = dtBookings;


                string prefQuery = @"SELECT P.Description 
                             FROM Preferences P 
                             INNER JOIN TravelerPreferences TP ON P.PreferenceID = TP.PreferenceID 
                             WHERE TP.TravelerID = @travelerId";

                SqlCommand cmdPrefs = new SqlCommand(prefQuery, conn);
                cmdPrefs.Parameters.AddWithValue("@travelerId", travelerId);

                SqlDataReader reader = cmdPrefs.ExecuteReader();
                Preferences.Items.Clear();
                while (reader.Read())
                {
                    Preferences.Items.Add(reader["Description"].ToString());
                }
                reader.Close();


                string reviewQuery = @"SELECT TripID, Rating, Comment 
                               FROM Review 
                               WHERE TravelerID = @travelerId And Status = 'Approved'";

                SqlCommand cmdReview = new SqlCommand(reviewQuery, conn);
                cmdReview.Parameters.AddWithValue("@travelerId", travelerId);

                SqlDataAdapter adapterReview = new SqlDataAdapter(cmdReview);
                DataTable dtReview = new DataTable();
                adapterReview.Fill(dtReview);
                dataGridView3.DataSource = dtReview;
            }
        }



        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width + 10, pictureBox1.Height + 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);

            pictureBox1.Cursor = Cursors.Hand;

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width - 10, pictureBox1.Height - 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);

            pictureBox1.Cursor = Cursors.Default;
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(pictureBox7.Width + 10, pictureBox7.Height + 10);
            pictureBox7.Location = new Point(pictureBox7.Location.X - 5, pictureBox7.Location.Y - 5);

            pictureBox7.Cursor = Cursors.Hand;

            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(pictureBox7.Width - 10, pictureBox7.Height - 10);
            pictureBox7.Location = new Point(pictureBox7.Location.X + 5, pictureBox7.Location.Y + 5);

            pictureBox7.Cursor = Cursors.Default;
            pictureBox7.BorderStyle = BorderStyle.None;
        }


        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(pictureBox3.Width + 10, pictureBox3.Height + 10);
            pictureBox3.Location = new Point(pictureBox3.Location.X - 5, pictureBox3.Location.Y - 5);

            pictureBox3.Cursor = Cursors.Hand;

            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(pictureBox3.Width - 10, pictureBox3.Height - 10);
            pictureBox3.Location = new Point(pictureBox3.Location.X + 5, pictureBox3.Location.Y + 5);

            pictureBox3.Cursor = Cursors.Default;
            pictureBox3.BorderStyle = BorderStyle.None;
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Traveler_Trip_Search tripsearch = new Traveler_Trip_Search(travelerId);
            tripsearch.Show();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TravelerPreferencesForm travelprefer = new TravelerPreferencesForm(6);
            travelprefer.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DigitalTravelPassForm DTP = new DigitalTravelPassForm(travelerId);
            DTP.Show();
        }

        private void btnRound5_Click(object sender, EventArgs e)
        {
            CancellationRequestForm CancelForm = new CancellationRequestForm(travelerId);
            CancelForm.Show();
        }

        private void btnRound6_Click(object sender, EventArgs e)
        {
            BookingHistoryForm BHistory = new BookingHistoryForm(travelerId);
            BHistory.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            EditTravelerProfileForm EditProfileTraveler = new EditTravelerProfileForm(travelerId);
            EditProfileTraveler.Show();
        }

        private void btnRound_Click_1(object sender, EventArgs e)
        {
            Traveler_Review_Submission ReviewSubmit = new Traveler_Review_Submission(travelerId);
            ReviewSubmit.Show();
        }

        private void btnRound2_Click(object sender, EventArgs e)
        {
            Traveler_Trip_Search form7 = new Traveler_Trip_Search(travelerId);
            form7.Show();
        }

        private void btnRound5_Click_1(object sender, EventArgs e)
        {
            CancellationRequestForm cancellationRequestForm = new CancellationRequestForm(travelerId);
            cancellationRequestForm.Show();
        }

        private void btnRound4_Click(object sender, EventArgs e)
        {
            TravelerPreferencesForm travelerPreferencesForm = new TravelerPreferencesForm(travelerId);
            travelerPreferencesForm.FormClosed += (s, args) => { LoadPreferences(); };
            travelerPreferencesForm.Show();
        }

        private void btnRound6_Click_1(object sender, EventArgs e)
        {
            BookingHistoryForm bookingHistoryForm = new BookingHistoryForm(travelerId);
            bookingHistoryForm.Show();
        }

        private void btnRound3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        public void LoadPreferences()
        {
            Preferences.Items.Clear();

            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
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

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Preferences.Items.Add(reader["Description"].ToString());
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(travelerId, sessionId);
            cartForm.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
