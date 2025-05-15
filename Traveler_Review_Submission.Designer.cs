namespace WindowsFormsApp1
{
    partial class Traveler_Review_Submission
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.ComboBox cbTrips;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTrip = new System.Windows.Forms.Label();
            this.cbTrips = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrip
            // 
            this.lblTrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(50, 80);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(100, 25);
            this.lblTrip.TabIndex = 1;
            this.lblTrip.Text = "Select Trip:";
            // 
            // cbTrips
            // 
            this.cbTrips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrips.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbTrips.Location = new System.Drawing.Point(160, 80);
            this.cbTrips.Name = "cbTrips";
            this.cbTrips.Size = new System.Drawing.Size(270, 29);
            this.cbTrips.TabIndex = 2;
            this.cbTrips.SelectedIndexChanged += new System.EventHandler(this.cbTrips_SelectedIndexChanged);
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(50, 130);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(100, 25);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "Rating (1-5):";
            // 
            // cbRating
            // 
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRating.Location = new System.Drawing.Point(160, 130);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(270, 29);
            this.cbRating.TabIndex = 4;
            // 
            // lblComments
            // 
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(50, 180);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(100, 25);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtComments.Location = new System.Drawing.Point(160, 180);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(270, 120);
            this.txtComments.TabIndex = 6;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 60);
            this.headerPanel.TabIndex = 16;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(165, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(228, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Submit Review";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(171, 327);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 40);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // Traveler_Review_Submission
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 412);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.cbTrips);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Traveler_Review_Submission";
            this.Text = "Submit Review";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSubmit;
    }
}
