using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class BookingDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCustomer;
        private Label lblStatus;
        private Label lblTripName;
        private Label lblBookingDate;
        private Label lblContactInfo;

        private GroupBox grpTravelerInfo;
        private GroupBox grpTripInfo;
        private GroupBox grpPaymentInfo;
        private GroupBox grpCancellationPolicy;
        private GroupBox grpRoomBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTripName = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.grpTravelerInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTripInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.grpCancellationPolicy = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpRoomBookings = new System.Windows.Forms.GroupBox();
            this.dgvRoomBookings = new System.Windows.Forms.DataGridView();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpTravelerInfo.SuspendLayout();
            this.grpTripInfo.SuspendLayout();
            this.grpPaymentInfo.SuspendLayout();
            this.grpCancellationPolicy.SuspendLayout();
            this.grpRoomBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBookings)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(95, 23);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(100, 23);
            this.lblCustomer.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(95, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 1;
            // 
            // lblTripName
            // 
            this.lblTripName.Location = new System.Drawing.Point(132, 23);
            this.lblTripName.Name = "lblTripName";
            this.lblTripName.Size = new System.Drawing.Size(100, 23);
            this.lblTripName.TabIndex = 0;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.Location = new System.Drawing.Point(132, 46);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(100, 23);
            this.lblBookingDate.TabIndex = 1;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.Location = new System.Drawing.Point(95, 55);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(100, 23);
            this.lblContactInfo.TabIndex = 2;
            // 
            // grpTravelerInfo
            // 
            this.grpTravelerInfo.Controls.Add(this.label3);
            this.grpTravelerInfo.Controls.Add(this.label2);
            this.grpTravelerInfo.Controls.Add(this.label1);
            this.grpTravelerInfo.Controls.Add(this.lblCustomer);
            this.grpTravelerInfo.Controls.Add(this.lblStatus);
            this.grpTravelerInfo.Controls.Add(this.lblContactInfo);
            this.grpTravelerInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTravelerInfo.Location = new System.Drawing.Point(20, 107);
            this.grpTravelerInfo.Name = "grpTravelerInfo";
            this.grpTravelerInfo.Size = new System.Drawing.Size(300, 114);
            this.grpTravelerInfo.TabIndex = 0;
            this.grpTravelerInfo.TabStop = false;
            this.grpTravelerInfo.Text = "Traveler Info";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // grpTripInfo
            // 
            this.grpTripInfo.Controls.Add(this.label5);
            this.grpTripInfo.Controls.Add(this.label4);
            this.grpTripInfo.Controls.Add(this.lblTripName);
            this.grpTripInfo.Controls.Add(this.lblBookingDate);
            this.grpTripInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpTripInfo.Location = new System.Drawing.Point(385, 107);
            this.grpTripInfo.Name = "grpTripInfo";
            this.grpTripInfo.Size = new System.Drawing.Size(300, 111);
            this.grpTripInfo.TabIndex = 1;
            this.grpTripInfo.TabStop = false;
            this.grpTripInfo.Text = "Trip Info";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Booking Date:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trip Name:";
            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.label7);
            this.grpPaymentInfo.Controls.Add(this.lblAmount);
            this.grpPaymentInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpPaymentInfo.Location = new System.Drawing.Point(20, 227);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(300, 100);
            this.grpPaymentInfo.TabIndex = 2;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Payment Info";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount:";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(112, 35);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 8;
            // 
            // grpCancellationPolicy
            // 
            this.grpCancellationPolicy.Controls.Add(this.textBox1);
            this.grpCancellationPolicy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpCancellationPolicy.Location = new System.Drawing.Point(385, 227);
            this.grpCancellationPolicy.Name = "grpCancellationPolicy";
            this.grpCancellationPolicy.Size = new System.Drawing.Size(300, 100);
            this.grpCancellationPolicy.TabIndex = 3;
            this.grpCancellationPolicy.TabStop = false;
            this.grpCancellationPolicy.Text = "Cancellation Policy";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(6, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 77);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // grpRoomBookings
            // 
            this.grpRoomBookings.Controls.Add(this.dgvRoomBookings);
            this.grpRoomBookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpRoomBookings.Location = new System.Drawing.Point(20, 347);
            this.grpRoomBookings.Name = "grpRoomBookings";
            this.grpRoomBookings.Size = new System.Drawing.Size(665, 166);
            this.grpRoomBookings.TabIndex = 4;
            this.grpRoomBookings.TabStop = false;
            this.grpRoomBookings.Text = "Room Bookings";
            // 
            // dgvRoomBookings
            // 
            this.dgvRoomBookings.AllowUserToAddRows = false;
            this.dgvRoomBookings.AllowUserToDeleteRows = false;
            this.dgvRoomBookings.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomBookings.Location = new System.Drawing.Point(6, 24);
            this.dgvRoomBookings.Name = "dgvRoomBookings";
            this.dgvRoomBookings.ReadOnly = true;
            this.dgvRoomBookings.Size = new System.Drawing.Size(653, 136);
            this.dgvRoomBookings.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(708, 60);
            this.headerPanel.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 28);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(227, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(194, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Booking Details";
            // 
            // BookingDetailsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 525);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.grpTravelerInfo);
            this.Controls.Add(this.grpTripInfo);
            this.Controls.Add(this.grpPaymentInfo);
            this.Controls.Add(this.grpCancellationPolicy);
            this.Controls.Add(this.grpRoomBookings);
            this.Name = "BookingDetailsForm";
            this.Text = "Booking Details";
            this.Load += new System.EventHandler(this.BookingDetailsForm_Load);
            this.grpTravelerInfo.ResumeLayout(false);
            this.grpTripInfo.ResumeLayout(false);
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpCancellationPolicy.ResumeLayout(false);
            this.grpCancellationPolicy.PerformLayout();
            this.grpRoomBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBookings)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label lblAmount;
        private Label label7;
        private Panel headerPanel;
        private Label lblHeading;
        private Button btnBack;
        private TextBox textBox1;
        private DataGridView dgvRoomBookings;
    }
}
