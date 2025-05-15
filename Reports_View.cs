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
    public partial class Reports_View : Form
    {
        public Reports_View()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            Report1Form reportForm = new Report1Form();
            reportForm.Show();
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            Report2Form reportForm = new Report2Form();
            reportForm.Show();
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            Report3Form reportForm = new Report3Form();
            reportForm.Show();
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            Report4Form reportForm = new Report4Form();
            reportForm.Show();
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            Report5Form reportForm = new Report5Form();
            reportForm.Show();
        }

        private void btnReport6_Click(object sender, EventArgs e)
        {
            Report6Form reportForm = new Report6Form();
            reportForm.Show();
        }

        private void btnReport8_Click(object sender, EventArgs e)
        {
            Report8Form reportForm = new Report8Form();
            reportForm.Show();
        }
    }
}
