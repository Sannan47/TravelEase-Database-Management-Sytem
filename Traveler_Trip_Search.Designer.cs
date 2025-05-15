namespace WindowsFormsApp1
{
    partial class Traveler_Trip_Search
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.CheckBox chkWheelchair;
        private System.Windows.Forms.CheckBox chkSignLanguage;
        private System.Windows.Forms.CheckBox chkDietary;
        private System.Windows.Forms.Label lblEcoScore;
        private System.Windows.Forms.NumericUpDown nudEcoScore;
        private System.Windows.Forms.DataGridView dgvTrips;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkWheelchair = new System.Windows.Forms.CheckBox();
            this.chkSignLanguage = new System.Windows.Forms.CheckBox();
            this.chkDietary = new System.Windows.Forms.CheckBox();
            this.lblEcoScore = new System.Windows.Forms.Label();
            this.nudEcoScore = new System.Windows.Forms.NumericUpDown();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEcoScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnSearch);
            this.grpFilters.Controls.Add(this.lblDestination);
            this.grpFilters.Controls.Add(this.txtDestination);
            this.grpFilters.Controls.Add(this.lblMinPrice);
            this.grpFilters.Controls.Add(this.nudMinPrice);
            this.grpFilters.Controls.Add(this.lblMaxPrice);
            this.grpFilters.Controls.Add(this.nudMaxPrice);
            this.grpFilters.Controls.Add(this.lblStartDate);
            this.grpFilters.Controls.Add(this.dtpStartDate);
            this.grpFilters.Controls.Add(this.lblEndDate);
            this.grpFilters.Controls.Add(this.dtpEndDate);
            this.grpFilters.Controls.Add(this.chkWheelchair);
            this.grpFilters.Controls.Add(this.chkSignLanguage);
            this.grpFilters.Controls.Add(this.chkDietary);
            this.grpFilters.Controls.Add(this.lblEcoScore);
            this.grpFilters.Controls.Add(this.nudEcoScore);
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilters.Location = new System.Drawing.Point(19, 96);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(329, 440);
            this.grpFilters.TabIndex = 0;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filter Trips";
            this.grpFilters.Enter += new System.EventHandler(this.grpFilters_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(90, 375);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 40);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(15, 30);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(100, 23);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDestination.Location = new System.Drawing.Point(120, 27);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(150, 29);
            this.txtDestination.TabIndex = 1;
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.Location = new System.Drawing.Point(15, 70);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(100, 23);
            this.lblMinPrice.TabIndex = 2;
            this.lblMinPrice.Text = "Min Price:";
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudMinPrice.Location = new System.Drawing.Point(120, 67);
            this.nudMinPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(120, 29);
            this.nudMinPrice.TabIndex = 3;
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.Location = new System.Drawing.Point(15, 100);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(100, 23);
            this.lblMaxPrice.TabIndex = 4;
            this.lblMaxPrice.Text = "Max Price:";
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudMaxPrice.Location = new System.Drawing.Point(120, 97);
            this.nudMaxPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(120, 29);
            this.nudMaxPrice.TabIndex = 5;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(15, 140);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 23);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpStartDate.Location = new System.Drawing.Point(90, 137);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(230, 29);
            this.dtpStartDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(15, 170);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 23);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpEndDate.Location = new System.Drawing.Point(90, 167);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(230, 29);
            this.dtpEndDate.TabIndex = 9;
            // 
            // chkWheelchair
            // 
            this.chkWheelchair.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkWheelchair.Location = new System.Drawing.Point(18, 210);
            this.chkWheelchair.Name = "chkWheelchair";
            this.chkWheelchair.Size = new System.Drawing.Size(104, 24);
            this.chkWheelchair.TabIndex = 10;
            this.chkWheelchair.Text = "Wheelchair Friendly";
            // 
            // chkSignLanguage
            // 
            this.chkSignLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkSignLanguage.Location = new System.Drawing.Point(18, 240);
            this.chkSignLanguage.Name = "chkSignLanguage";
            this.chkSignLanguage.Size = new System.Drawing.Size(104, 24);
            this.chkSignLanguage.TabIndex = 11;
            this.chkSignLanguage.Text = "Sign Language Guide";
            // 
            // chkDietary
            // 
            this.chkDietary.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkDietary.Location = new System.Drawing.Point(18, 270);
            this.chkDietary.Name = "chkDietary";
            this.chkDietary.Size = new System.Drawing.Size(104, 24);
            this.chkDietary.TabIndex = 12;
            this.chkDietary.Text = "Dietary Options";
            // 
            // lblEcoScore
            // 
            this.lblEcoScore.Location = new System.Drawing.Point(15, 310);
            this.lblEcoScore.Name = "lblEcoScore";
            this.lblEcoScore.Size = new System.Drawing.Size(100, 23);
            this.lblEcoScore.TabIndex = 13;
            this.lblEcoScore.Text = "Min EcoScore:";
            // 
            // nudEcoScore
            // 
            this.nudEcoScore.DecimalPlaces = 1;
            this.nudEcoScore.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudEcoScore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudEcoScore.Location = new System.Drawing.Point(120, 307);
            this.nudEcoScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudEcoScore.Name = "nudEcoScore";
            this.nudEcoScore.Size = new System.Drawing.Size(120, 29);
            this.nudEcoScore.TabIndex = 14;
            // 
            // dgvTrips
            // 
            this.dgvTrips.AllowUserToAddRows = false;
            this.dgvTrips.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrips.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrips.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrips.Location = new System.Drawing.Point(371, 96);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.ReadOnly = true;
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.Size = new System.Drawing.Size(456, 440);
            this.dgvTrips.TabIndex = 1;
            this.dgvTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellContentClick);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 60);
            this.headerPanel.TabIndex = 18;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(365, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(175, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Trip Search";
            // 
            // Traveler_Trip_Search
            // 
            this.ClientSize = new System.Drawing.Size(900, 605);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.dgvTrips);
            this.Name = "Traveler_Trip_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Search";
            this.Load += new System.EventHandler(this.Traveler_Trip_Search_Load);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEcoScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSearch;
    }
}
