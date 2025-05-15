namespace TravelEase
{
    partial class TripDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAccessibility = new System.Windows.Forms.Label();
            this.dgvItinerary = new System.Windows.Forms.DataGridView();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstInclusions = new System.Windows.Forms.ListBox();
            this.lblInclusions = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblHotelInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerary)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(37, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trip to:  Cairo";
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(105, 105);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(100, 23);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Cairo";
            // 
            // lblDates
            // 
            this.lblDates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(38, 139);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(265, 23);
            this.lblDates.TabIndex = 2;
            this.lblDates.Text = "Dates: 06/10/2025 - 06/18/2025";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(308, 105);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "$1,200.00";
            // 
            // lblAccessibility
            // 
            this.lblAccessibility.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessibility.Location = new System.Drawing.Point(309, 139);
            this.lblAccessibility.Name = "lblAccessibility";
            this.lblAccessibility.Size = new System.Drawing.Size(200, 23);
            this.lblAccessibility.TabIndex = 4;
            this.lblAccessibility.Text = "♿ 🍽️ 👂 E,2";
            this.lblAccessibility.Click += new System.EventHandler(this.lblAccessibility_Click);
            // 
            // dgvItinerary
            // 
            this.dgvItinerary.AllowUserToAddRows = false;
            this.dgvItinerary.AllowUserToDeleteRows = false;
            this.dgvItinerary.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItinerary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItinerary.ColumnHeadersHeight = 29;
            this.dgvItinerary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay,
            this.colDescription,
            this.colLocation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItinerary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItinerary.Location = new System.Drawing.Point(37, 197);
            this.dgvItinerary.Name = "dgvItinerary";
            this.dgvItinerary.ReadOnly = true;
            this.dgvItinerary.RowHeadersWidth = 51;
            this.dgvItinerary.Size = new System.Drawing.Size(529, 120);
            this.dgvItinerary.TabIndex = 5;
            // 
            // colDay
            // 
            this.colDay.HeaderText = "Day";
            this.colDay.MinimumWidth = 6;
            this.colDay.Name = "colDay";
            this.colDay.ReadOnly = true;
            this.colDay.Width = 60;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 250;
            // 
            // colLocation
            // 
            this.colLocation.HeaderText = "Location";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 150;
            // 
            // lstInclusions
            // 
            this.lstInclusions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInclusions.ItemHeight = 21;
            this.lstInclusions.Location = new System.Drawing.Point(37, 362);
            this.lstInclusions.Name = "lstInclusions";
            this.lstInclusions.Size = new System.Drawing.Size(371, 46);
            this.lstInclusions.TabIndex = 7;
            // 
            // lblInclusions
            // 
            this.lblInclusions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInclusions.Location = new System.Drawing.Point(37, 336);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Size = new System.Drawing.Size(100, 23);
            this.lblInclusions.TabIndex = 6;
            this.lblInclusions.Text = "Inclusions:";
            // 
            // lblServices
            // 
            this.lblServices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblServices.Location = new System.Drawing.Point(37, 417);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(100, 23);
            this.lblServices.TabIndex = 8;
            this.lblServices.Text = "Services:";
            // 
            // lblHotelInfo
            // 
            this.lblHotelInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelInfo.Location = new System.Drawing.Point(37, 446);
            this.lblHotelInfo.Name = "lblHotelInfo";
            this.lblHotelInfo.Size = new System.Drawing.Size(350, 56);
            this.lblHotelInfo.TabIndex = 9;
            this.lblHotelInfo.Text = "Hotel: Golden\nAddress: 123 Ir., Cairo";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 28);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(590, 60);
            this.headerPanel.TabIndex = 17;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(202, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(179, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Trip Details";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCart.ForeColor = System.Drawing.Color.White;
            this.btnViewCart.Location = new System.Drawing.Point(340, 522);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(140, 40);
            this.btnViewCart.TabIndex = 18;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = false;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(108, 522);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(140, 40);
            this.btnAddToCart.TabIndex = 19;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
            // 
            // TripDetailsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 640);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAccessibility);
            this.Controls.Add(this.dgvItinerary);
            this.Controls.Add(this.lblInclusions);
            this.Controls.Add(this.lstInclusions);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblHotelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TripDetailsForm";
            this.Text = "TripDetailsForm";
            this.Load += new System.EventHandler(this.TripDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerary)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAccessibility;
        private System.Windows.Forms.DataGridView dgvItinerary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.ListBox lstInclusions;
        private System.Windows.Forms.Label lblInclusions;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblHotelInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnAddToCart;
    }
}
