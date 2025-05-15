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
    public partial class Report8Form : Form
    {
        public Report8Form()
        {
            InitializeComponent();
        }

        private void Report8Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'report8data.vw_PaymentSuccessFailureRate' table. You can move, or remove it, as needed.
            this.vw_PaymentSuccessFailureRateTableAdapter.Fill(this.report8data.vw_PaymentSuccessFailureRate);
            // TODO: This line of code loads data into the 'report8data.vw_ChargebackRate' table. You can move, or remove it, as needed.
            this.vw_ChargebackRateTableAdapter.Fill(this.report8data.vw_ChargebackRate);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
