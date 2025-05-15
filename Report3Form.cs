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
    public partial class Report3Form : Form
    {
        public Report3Form()
        {
            InitializeComponent();
        }

        private void Report3Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'report3Data.RevenuePerOperator' table. You can move, or remove it, as needed.
            this.revenuePerOperatorTableAdapter.Fill(this.report3Data.RevenuePerOperator);
            // TODO: This line of code loads data into the 'report3Data.AverageOperatorRating' table. You can move, or remove it, as needed.
            this.averageOperatorRatingTableAdapter.Fill(this.report3Data.AverageOperatorRating);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
