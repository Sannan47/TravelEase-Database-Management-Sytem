namespace TravelEase
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnReviewModeration;
        private System.Windows.Forms.Button btnTourCategory;
        private System.Windows.Forms.Button btnAnalytics;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnReviewModeration = new System.Windows.Forms.Button();
            this.btnTourCategory = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeading.Location = new System.Drawing.Point(58, 19);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(221, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Admin Dashboard";
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.Maroon;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(48, 69);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(243, 39);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click_1);
            // 
            // btnReviewModeration
            // 
            this.btnReviewModeration.BackColor = System.Drawing.Color.Maroon;
            this.btnReviewModeration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewModeration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReviewModeration.ForeColor = System.Drawing.Color.White;
            this.btnReviewModeration.Location = new System.Drawing.Point(48, 123);
            this.btnReviewModeration.Margin = new System.Windows.Forms.Padding(2);
            this.btnReviewModeration.Name = "btnReviewModeration";
            this.btnReviewModeration.Size = new System.Drawing.Size(243, 39);
            this.btnReviewModeration.TabIndex = 2;
            this.btnReviewModeration.Text = "Review Moderation";
            this.btnReviewModeration.UseVisualStyleBackColor = false;
            this.btnReviewModeration.Click += new System.EventHandler(this.btnReviewModeration_Click_1);
            // 
            // btnTourCategory
            // 
            this.btnTourCategory.BackColor = System.Drawing.Color.Maroon;
            this.btnTourCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTourCategory.ForeColor = System.Drawing.Color.White;
            this.btnTourCategory.Location = new System.Drawing.Point(48, 176);
            this.btnTourCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnTourCategory.Name = "btnTourCategory";
            this.btnTourCategory.Size = new System.Drawing.Size(243, 39);
            this.btnTourCategory.TabIndex = 3;
            this.btnTourCategory.Text = "Tour Category Management";
            this.btnTourCategory.UseVisualStyleBackColor = false;
            this.btnTourCategory.Click += new System.EventHandler(this.btnTourCategory_Click_1);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.Maroon;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.Location = new System.Drawing.Point(48, 228);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(243, 39);
            this.btnAnalytics.TabIndex = 4;
            this.btnAnalytics.Text = "Platform Analytics";
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(297, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(350, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnReviewModeration);
            this.Controls.Add(this.btnTourCategory);
            this.Controls.Add(this.btnAnalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
