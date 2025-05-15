using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TravelEase
{
    public partial class DashboardForm : Form
    {
        private int providerId;
        public DashboardForm(int providerId)
        {
            InitializeComponent();
            this.providerId = providerId;
        }

        private void btnPerformanceReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Performance Reports clicked.");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceApprovalForm serviceApprovalForm = new ServiceApprovalForm(providerId);
            serviceApprovalForm.Show();
        }

        private void btnServiceListing_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ServiceProviderServicesForm serviceProviderServicesForm = new ServiceProviderServicesForm(providerId);
            serviceProviderServicesForm.Show();
        }

        private void btnBookingManagement_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BookingManagementForm bookingManagementForm = new BookingManagementForm(providerId);
            bookingManagementForm.Show();
        }
    }
}
