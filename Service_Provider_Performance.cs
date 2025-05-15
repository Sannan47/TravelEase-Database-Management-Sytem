using System;
using System.Data;
using System.Windows.Forms;

namespace TravelEase
{
    public partial class ServiceAnalytics : Form
    {
        public ServiceAnalytics()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            // Dummy review data
            DataTable dt = new DataTable();
            dt.Columns.Add("ReviewID", typeof(int));
            dt.Columns.Add("TravelerName", typeof(string));
            dt.Columns.Add("Rating", typeof(int));
            dt.Columns.Add("Comment", typeof(string));
            dt.Columns.Add("ReviewDate", typeof(DateTime));

            dt.Rows.Add(1, "Ali Khan", 5, "Amazing trip!", new DateTime(2025, 4, 1));
            dt.Rows.Add(2, "Sara Ahmed", 4, "Very good experience.", new DateTime(2025, 4, 10));
            dt.Rows.Add(3, "Usman Tariq", 5, "Best service ever!", new DateTime(2025, 4, 15));

            dgvReviews.DataSource = dt;

            // Dummy revenue
            lblRevenueAmount.Text = "$12,500.00";
        }

        private void ServiceAnalytics_Load(object sender, EventArgs e)
        {

        }
    }
}
