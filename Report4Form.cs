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
    public partial class Report4Form : Form
    {
        public Report4Form()
        {
            InitializeComponent();
        }

        private void Report4Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'report4.HotelOccupancyRate' table. You can move, or remove it, as needed.
            this.hotelOccupancyRateTableAdapter.Fill(this.report4.HotelOccupancyRate);
            // TODO: This line of code loads data into the 'report4.GuideRatings' table. You can move, or remove it, as needed.
            this.guideRatingsTableAdapter.Fill(this.report4.GuideRatings);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
