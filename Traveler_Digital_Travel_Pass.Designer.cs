// Updated Designer Code with Color Scheme
namespace TravelEase
{
    partial class DigitalTravelPassForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTripTitle;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.DataGridView dgvItinerary;
        private System.Windows.Forms.GroupBox groupHotel;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckInOut;
        private System.Windows.Forms.ListBox listInclusions;
        private System.Windows.Forms.Label lblInclusions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTripTitle = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.dgvItinerary = new System.Windows.Forms.DataGridView();
            this.groupHotel = new System.Windows.Forms.GroupBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckInOut = new System.Windows.Forms.Label();
            this.listInclusions = new System.Windows.Forms.ListBox();
            this.lblInclusions = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.cbBooking = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerary)).BeginInit();
            this.groupHotel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTripTitle
            // 
            this.lblTripTitle.AutoSize = true;
            this.lblTripTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTripTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTripTitle.Location = new System.Drawing.Point(26, 92);
            this.lblTripTitle.Name = "lblTripTitle";
            this.lblTripTitle.Size = new System.Drawing.Size(149, 25);
            this.lblTripTitle.TabIndex = 0;
            this.lblTripTitle.Text = "Trip: [Trip Title]";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.DimGray;
            this.lblDestination.Location = new System.Drawing.Point(26, 122);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(216, 23);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination: [Destination]";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.ForeColor = System.Drawing.Color.DimGray;
            this.lblDates.Location = new System.Drawing.Point(26, 142);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(240, 23);
            this.lblDates.TabIndex = 2;
            this.lblDates.Text = "Dates: [StartDate - EndDate]";
            // 
            // dgvItinerary
            // 
            this.dgvItinerary.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItinerary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItinerary.EnableHeadersVisualStyles = false;
            this.dgvItinerary.GridColor = System.Drawing.Color.LightGray;
            this.dgvItinerary.Location = new System.Drawing.Point(26, 172);
            this.dgvItinerary.Name = "dgvItinerary";
            this.dgvItinerary.ReadOnly = true;
            this.dgvItinerary.RowHeadersWidth = 51;
            this.dgvItinerary.Size = new System.Drawing.Size(450, 150);
            this.dgvItinerary.TabIndex = 3;
            // 
            // groupHotel
            // 
            this.groupHotel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupHotel.Controls.Add(this.lblHotelName);
            this.groupHotel.Controls.Add(this.lblRoomType);
            this.groupHotel.Controls.Add(this.lblCheckInOut);
            this.groupHotel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHotel.ForeColor = System.Drawing.Color.Black;
            this.groupHotel.Location = new System.Drawing.Point(26, 342);
            this.groupHotel.Name = "groupHotel";
            this.groupHotel.Size = new System.Drawing.Size(450, 100);
            this.groupHotel.TabIndex = 4;
            this.groupHotel.TabStop = false;
            this.groupHotel.Text = "Hotel Info";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHotelName.ForeColor = System.Drawing.Color.Black;
            this.lblHotelName.Location = new System.Drawing.Point(10, 20);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(162, 23);
            this.lblHotelName.TabIndex = 0;
            this.lblHotelName.Text = "Hotel: [Hotel Name]";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRoomType.ForeColor = System.Drawing.Color.Black;
            this.lblRoomType.Location = new System.Drawing.Point(10, 45);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(159, 23);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Room: [Room Type]";
            // 
            // lblCheckInOut
            // 
            this.lblCheckInOut.AutoSize = true;
            this.lblCheckInOut.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCheckInOut.ForeColor = System.Drawing.Color.Black;
            this.lblCheckInOut.Location = new System.Drawing.Point(10, 70);
            this.lblCheckInOut.Name = "lblCheckInOut";
            this.lblCheckInOut.Size = new System.Drawing.Size(287, 23);
            this.lblCheckInOut.TabIndex = 2;
            this.lblCheckInOut.Text = "Check-In: [Date] - Check-Out: [Date]";
            // 
            // listInclusions
            // 
            this.listInclusions.BackColor = System.Drawing.Color.White;
            this.listInclusions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInclusions.ForeColor = System.Drawing.Color.Black;
            this.listInclusions.ItemHeight = 21;
            this.listInclusions.Location = new System.Drawing.Point(26, 472);
            this.listInclusions.Name = "listInclusions";
            this.listInclusions.Size = new System.Drawing.Size(450, 88);
            this.listInclusions.TabIndex = 6;
            // 
            // lblInclusions
            // 
            this.lblInclusions.AutoSize = true;
            this.lblInclusions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInclusions.ForeColor = System.Drawing.Color.DimGray;
            this.lblInclusions.Location = new System.Drawing.Point(26, 452);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Size = new System.Drawing.Size(246, 23);
            this.lblInclusions.TabIndex = 5;
            this.lblInclusions.Text = "Included Activities / Services:";
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
            this.headerPanel.TabIndex = 10;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(109, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(274, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Digital Travel Pass";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // cbBooking
            // 
            this.cbBooking.FormattingEnabled = true;
            this.cbBooking.Location = new System.Drawing.Point(339, 92);
            this.cbBooking.Name = "cbBooking";
            this.cbBooking.Size = new System.Drawing.Size(121, 24);
            this.cbBooking.TabIndex = 11;
            // 
            // DigitalTravelPassForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 659);
            this.Controls.Add(this.cbBooking);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblTripTitle);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.dgvItinerary);
            this.Controls.Add(this.groupHotel);
            this.Controls.Add(this.lblInclusions);
            this.Controls.Add(this.listInclusions);
            this.Name = "DigitalTravelPassForm";
            this.Text = "Digital Travel Pass";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerary)).EndInit();
            this.groupHotel.ResumeLayout(false);
            this.groupHotel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cbBooking;
    }
}
