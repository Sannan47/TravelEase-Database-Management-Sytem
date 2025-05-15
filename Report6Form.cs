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
    public partial class Report6Form : Form
    {
        public Report6Form()
        {
            InitializeComponent();
        }

        private void Report6Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'report6.RecoveryRate' table. You can move, or remove it, as needed.
            this.recoveryRateTableAdapter.Fill(this.report6.RecoveryRate);
            // TODO: This line of code loads data into the 'report6.PotentialRevenueLoss' table. You can move, or remove it, as needed.
            this.potentialRevenueLossTableAdapter.Fill(this.report6.PotentialRevenueLoss);
            // TODO: This line of code loads data into the 'report6.CommonReasonsforAbandonment' table. You can move, or remove it, as needed.
            this.commonReasonsforAbandonmentTableAdapter.Fill(this.report6.CommonReasonsforAbandonment);
            // TODO: This line of code loads data into the 'report6.AbandonmentRate' table. You can move, or remove it, as needed.
            this.abandonmentRateTableAdapter.Fill(this.report6.AbandonmentRate);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
