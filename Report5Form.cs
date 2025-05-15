using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Report5Form : Form
    {
        public Report5Form()
        {
            InitializeComponent();
        }

        private void Report5Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelEaseDataSet13.TravelerSatisfaction' table. You can move, or remove it, as needed.
            this.travelerSatisfactionTableAdapter.Fill(this.travelEaseDataSet13.TravelerSatisfaction);
            // TODO: This line of code loads data into the 'travelEaseDataSet13.MostBookedDestinations' table. You can move, or remove it, as needed.
            this.mostBookedDestinationsTableAdapter.Fill(this.travelEaseDataSet13.MostBookedDestinations);
            // TODO: This line of code loads data into the 'travelEaseDataSet13.MonthlyTrends' table. You can move, or remove it, as needed.
            this.monthlyTrendsTableAdapter.Fill(this.travelEaseDataSet13.MonthlyTrends);
            // TODO: This line of code loads data into the 'travelEaseDataSet13.EmergingDestinations' table. You can move, or remove it, as needed.
            this.emergingDestinationsTableAdapter.Fill(this.travelEaseDataSet13.EmergingDestinations);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
