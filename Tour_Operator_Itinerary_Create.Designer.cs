namespace WindowsFormsApp1
{
    partial class ItineraryForm
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
            this.labelDayNumber = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelActivity = new System.Windows.Forms.Label();
            this.textBoxDayNumber = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDayNumber
            // 
            this.labelDayNumber.AutoSize = true;
            this.labelDayNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayNumber.Location = new System.Drawing.Point(27, 94);
            this.labelDayNumber.Name = "labelDayNumber";
            this.labelDayNumber.Size = new System.Drawing.Size(91, 17);
            this.labelDayNumber.TabIndex = 0;
            this.labelDayNumber.Text = "Day Number:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(27, 129);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 17);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(27, 239);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(65, 17);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Location:";
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivity.Location = new System.Drawing.Point(27, 269);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(59, 17);
            this.labelActivity.TabIndex = 6;
            this.labelActivity.Text = "Activity:";
            // 
            // textBoxDayNumber
            // 
            this.textBoxDayNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxDayNumber.Location = new System.Drawing.Point(127, 91);
            this.textBoxDayNumber.Name = "textBoxDayNumber";
            this.textBoxDayNumber.Size = new System.Drawing.Size(200, 25);
            this.textBoxDayNumber.TabIndex = 1;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxLocation.Location = new System.Drawing.Point(127, 236);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(300, 25);
            this.textBoxLocation.TabIndex = 5;
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxActivity.Location = new System.Drawing.Point(127, 266);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.Size = new System.Drawing.Size(300, 25);
            this.textBoxActivity.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxDescription.Location = new System.Drawing.Point(127, 126);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(300, 100);
            this.textBoxDescription.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(32, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 28);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(450, 60);
            this.headerPanel.TabIndex = 29;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(160, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(167, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Add Itinerary";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(73, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 40);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ItineraryForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 390);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.labelDayNumber);
            this.Controls.Add(this.textBoxDayNumber);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.textBoxActivity);
            this.Name = "ItineraryForm";
            this.Text = "Itinerary";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelDayNumber;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelActivity;

        private System.Windows.Forms.TextBox textBoxDayNumber;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSave;
    }
}
