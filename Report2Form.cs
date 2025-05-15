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
    public partial class Report2Form : Form
    {
        public Report2Form()
        {
            InitializeComponent();
        }

        private void Report2Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'report2Data.SpendingByNationality' table. You can move, or remove it, as needed.
            this.spendingByNationalityTableAdapter.Fill(this.report2Data.SpendingByNationality);
            // TODO: This line of code loads data into the 'report2Data.NationalityDistruibution' table. You can move, or remove it, as needed.
            this.nationalityDistruibutionTableAdapter.Fill(this.report2Data.NationalityDistruibution);
            // TODO: This line of code loads data into the 'report2Data.MostBookedCategories' table. You can move, or remove it, as needed.
            this.mostBookedCategoriesTableAdapter.Fill(this.report2Data.MostBookedCategories);
            // TODO: This line of code loads data into the 'report2Data.AverageSpendingPerTraveler' table. You can move, or remove it, as needed.
            this.averageSpendingPerTravelerTableAdapter.Fill(this.report2Data.AverageSpendingPerTraveler);
            // TODO: This line of code loads data into the 'report2Data.AgeDistruibution' table. You can move, or remove it, as needed.
            this.ageDistruibutionTableAdapter.Fill(this.report2Data.AgeDistruibution);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
