using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TravelEase
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();

            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);


        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width + 10, pictureBox1.Height + 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);

            pictureBox1.Cursor = Cursors.Hand;

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width - 10, pictureBox1.Height - 10);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);

            pictureBox1.Cursor = Cursors.Default;
            pictureBox1.BorderStyle = BorderStyle.None;
        }



        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to User Management");
        }

        private void btnReviewModeration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Review Moderation");
        }

        private void btnTourCategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Tour Category Management");
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Platform Analytics");
        }

        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            AdminUserOperatorForm adminUserOperatorForm = new AdminUserOperatorForm();
            adminUserOperatorForm.Show();
        }

        private void btnTourCategory_Click_1(object sender, EventArgs e)
        {
            Admin_Manage_Categories manageCategoriesForm = new Admin_Manage_Categories();
            manageCategoriesForm.Show();
        }

        private void btnReviewModeration_Click_1(object sender, EventArgs e)
        {
            Admin_Review_Moderation reviewModerationForm = new Admin_Review_Moderation();
            reviewModerationForm.Show();
        }

        private void btnAnalytics_Click_1(object sender, EventArgs e)
        {
            Admin_Platform_Analytics platformAnalyticsForm = new Admin_Platform_Analytics();
            platformAnalyticsForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }
    }
}
