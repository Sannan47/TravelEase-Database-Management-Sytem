namespace TravelEase
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnServiceApproval = new System.Windows.Forms.Button();
            this.btnServiceListing = new System.Windows.Forms.Button();
            this.btnBookingManagement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Indigo;
            this.lblHeading.Location = new System.Drawing.Point(23, 34);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(375, 37);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "Service Provider Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(367, 209);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnServiceApproval
            // 
            this.btnServiceApproval.BackColor = System.Drawing.Color.Indigo;
            this.btnServiceApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceApproval.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceApproval.ForeColor = System.Drawing.Color.White;
            this.btnServiceApproval.Location = new System.Drawing.Point(68, 102);
            this.btnServiceApproval.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceApproval.Name = "btnServiceApproval";
            this.btnServiceApproval.Size = new System.Drawing.Size(275, 39);
            this.btnServiceApproval.TabIndex = 7;
            this.btnServiceApproval.Text = "Service Approval";
            this.btnServiceApproval.UseVisualStyleBackColor = false;
            this.btnServiceApproval.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnServiceListing
            // 
            this.btnServiceListing.BackColor = System.Drawing.Color.Indigo;
            this.btnServiceListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceListing.ForeColor = System.Drawing.Color.White;
            this.btnServiceListing.Location = new System.Drawing.Point(68, 156);
            this.btnServiceListing.Margin = new System.Windows.Forms.Padding(2);
            this.btnServiceListing.Name = "btnServiceListing";
            this.btnServiceListing.Size = new System.Drawing.Size(275, 39);
            this.btnServiceListing.TabIndex = 8;
            this.btnServiceListing.Text = "Service Listing";
            this.btnServiceListing.UseVisualStyleBackColor = false;
            this.btnServiceListing.Click += new System.EventHandler(this.btnServiceListing_Click_1);
            // 
            // btnBookingManagement
            // 
            this.btnBookingManagement.BackColor = System.Drawing.Color.Indigo;
            this.btnBookingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookingManagement.ForeColor = System.Drawing.Color.White;
            this.btnBookingManagement.Location = new System.Drawing.Point(68, 209);
            this.btnBookingManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookingManagement.Name = "btnBookingManagement";
            this.btnBookingManagement.Size = new System.Drawing.Size(275, 39);
            this.btnBookingManagement.TabIndex = 9;
            this.btnBookingManagement.Text = "Booking Management";
            this.btnBookingManagement.UseVisualStyleBackColor = false;
            this.btnBookingManagement.Click += new System.EventHandler(this.btnBookingManagement_Click_1);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(422, 274);
            this.Controls.Add(this.btnServiceApproval);
            this.Controls.Add(this.btnServiceListing);
            this.Controls.Add(this.btnBookingManagement);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Provider Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnServiceApproval;
        private System.Windows.Forms.Button btnServiceListing;
        private System.Windows.Forms.Button btnBookingManagement;
    }
}
