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
    public partial class Report1Form : Form
    {
        public Report1Form()
        {
            InitializeComponent();
        }

        private void RViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelEaseDataSet12.vw_AverageBookingValue' table. You can move, or remove it, as needed.
            this.vw_AverageBookingValueTableAdapter.Fill(this.travelEaseDataSet12.vw_AverageBookingValue);
            // TODO: This line of code loads data into the 'travelEaseDataSet11.vw_PeakBookingPeriods' table. You can move, or remove it, as needed.
            this.vw_PeakBookingPeriodsTableAdapter.Fill(this.travelEaseDataSet11.vw_PeakBookingPeriods);
            // TODO: This line of code loads data into the 'travelEaseDataSet10.vw_CancellationRate' table. You can move, or remove it, as needed.
            this.vw_CancellationRateTableAdapter.Fill(this.travelEaseDataSet10.vw_CancellationRate);
            // TODO: This line of code loads data into the 'travelEaseDataSet9.vw_TotalBookings' table. You can move, or remove it, as needed.
            this.vw_TotalBookingsTableAdapter.Fill(this.travelEaseDataSet9.vw_TotalBookings);
            // TODO: This line of code loads data into the 'trprevenuecategory.vw_RevenueByTripCategory' table. You can move, or remove it, as needed.
            this.vw_RevenueByTripCategoryTableAdapter.Fill(this.trprevenuecategory.vw_RevenueByTripCategory);

            this.reportViewer1.RefreshReport();
        }
    }
}
