namespace WindowsFormsApp1
{
    partial class TripCreationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkWheelchair = new System.Windows.Forms.CheckBox();
            this.chkSignLanguage = new System.Windows.Forms.CheckBox();
            this.chkDietary = new System.Windows.Forms.CheckBox();
            this.txtEcoScore = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblEcoScore = new System.Windows.Forms.Label();
            this.btnManageItinerary = new System.Windows.Forms.Button();
            this.btnManageInclusions = new System.Windows.Forms.Button();
            this.btnAssignServices = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbCategory.Location = new System.Drawing.Point(32, 106);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(300, 25);
            this.cmbCategory.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTitle.Location = new System.Drawing.Point(32, 156);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(145, 25);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDestination.Location = new System.Drawing.Point(187, 156);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(145, 25);
            this.txtDestination.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrice.Location = new System.Drawing.Point(32, 206);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 25);
            this.txtPrice.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpStartDate.Location = new System.Drawing.Point(187, 206);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(145, 25);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEndDate.Location = new System.Drawing.Point(32, 264);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(145, 25);
            this.dtpEndDate.TabIndex = 11;
            // 
            // chkWheelchair
            // 
            this.chkWheelchair.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkWheelchair.Location = new System.Drawing.Point(190, 264);
            this.chkWheelchair.Name = "chkWheelchair";
            this.chkWheelchair.Size = new System.Drawing.Size(104, 24);
            this.chkWheelchair.TabIndex = 12;
            this.chkWheelchair.Text = "Wheelchair Friendly";
            // 
            // chkSignLanguage
            // 
            this.chkSignLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkSignLanguage.Location = new System.Drawing.Point(32, 294);
            this.chkSignLanguage.Name = "chkSignLanguage";
            this.chkSignLanguage.Size = new System.Drawing.Size(104, 24);
            this.chkSignLanguage.TabIndex = 13;
            this.chkSignLanguage.Text = "Sign Language Guide";
            // 
            // chkDietary
            // 
            this.chkDietary.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkDietary.Location = new System.Drawing.Point(187, 294);
            this.chkDietary.Name = "chkDietary";
            this.chkDietary.Size = new System.Drawing.Size(104, 24);
            this.chkDietary.TabIndex = 14;
            this.chkDietary.Text = "Dietary Options";
            // 
            // txtEcoScore
            // 
            this.txtEcoScore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEcoScore.Location = new System.Drawing.Point(32, 355);
            this.txtEcoScore.Name = "txtEcoScore";
            this.txtEcoScore.Size = new System.Drawing.Size(145, 25);
            this.txtEcoScore.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(32, 79);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 24);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 136);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Trip Title:";
            // 
            // lblDestination
            // 
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(187, 136);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(100, 15);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(32, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 15);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(187, 186);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 15);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(32, 244);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 15);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblEcoScore
            // 
            this.lblEcoScore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcoScore.Location = new System.Drawing.Point(32, 335);
            this.lblEcoScore.Name = "lblEcoScore";
            this.lblEcoScore.Size = new System.Drawing.Size(150, 15);
            this.lblEcoScore.TabIndex = 15;
            this.lblEcoScore.Text = "Eco Score (0-5):";
            // 
            // btnManageItinerary
            // 
            this.btnManageItinerary.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnManageItinerary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageItinerary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageItinerary.ForeColor = System.Drawing.Color.White;
            this.btnManageItinerary.Location = new System.Drawing.Point(35, 396);
            this.btnManageItinerary.Name = "btnManageItinerary";
            this.btnManageItinerary.Size = new System.Drawing.Size(297, 40);
            this.btnManageItinerary.TabIndex = 23;
            this.btnManageItinerary.Text = "Manage Itinerary";
            this.btnManageItinerary.UseVisualStyleBackColor = false;
            this.btnManageItinerary.Click += new System.EventHandler(this.btnManageItinerary_Click);
            // 
            // btnManageInclusions
            // 
            this.btnManageInclusions.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnManageInclusions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInclusions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInclusions.ForeColor = System.Drawing.Color.White;
            this.btnManageInclusions.Location = new System.Drawing.Point(35, 453);
            this.btnManageInclusions.Name = "btnManageInclusions";
            this.btnManageInclusions.Size = new System.Drawing.Size(297, 40);
            this.btnManageInclusions.TabIndex = 24;
            this.btnManageInclusions.Text = "Manage Inclusions";
            this.btnManageInclusions.UseVisualStyleBackColor = false;
            this.btnManageInclusions.Click += new System.EventHandler(this.btnManageInclusions_Click);
            // 
            // btnAssignServices
            // 
            this.btnAssignServices.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAssignServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignServices.ForeColor = System.Drawing.Color.White;
            this.btnAssignServices.Location = new System.Drawing.Point(35, 508);
            this.btnAssignServices.Name = "btnAssignServices";
            this.btnAssignServices.Size = new System.Drawing.Size(297, 40);
            this.btnAssignServices.TabIndex = 25;
            this.btnAssignServices.Text = "Assign Services";
            this.btnAssignServices.UseVisualStyleBackColor = false;
            this.btnAssignServices.Click += new System.EventHandler(this.btnAssignServices_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(35, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.headerPanel.Size = new System.Drawing.Size(370, 60);
            this.headerPanel.TabIndex = 27;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(169, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(58, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Trip";
            // 
            // TripCreationForm
            // 
            this.ClientSize = new System.Drawing.Size(370, 618);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAssignServices);
            this.Controls.Add(this.btnManageInclusions);
            this.Controls.Add(this.btnManageItinerary);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.chkWheelchair);
            this.Controls.Add(this.chkSignLanguage);
            this.Controls.Add(this.chkDietary);
            this.Controls.Add(this.lblEcoScore);
            this.Controls.Add(this.txtEcoScore);
            this.Name = "TripCreationForm";
            this.Text = "New Trip";
            this.Load += new System.EventHandler(this.TripCreationForm_Load_1);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Fields
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chkWheelchair;
        private System.Windows.Forms.CheckBox chkSignLanguage;
        private System.Windows.Forms.CheckBox chkDietary;
        private System.Windows.Forms.TextBox txtEcoScore;

        // Label fields
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEcoScore;
        private System.Windows.Forms.Button btnManageItinerary;
        private System.Windows.Forms.Button btnManageInclusions;
        private System.Windows.Forms.Button btnAssignServices;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
    }
}
