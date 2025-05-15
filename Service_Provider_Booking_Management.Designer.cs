using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class BookingManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvBookings;

        private DataGridViewTextBoxColumn colBookingID;
        private DataGridViewTextBoxColumn colService;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colPayment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.colBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnRejectBooking = new System.Windows.Forms.Button();
            this.btnMarkAsPaid = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookingID,
            this.colService,
            this.colQty,
            this.colStatus,
            this.colAmount,
            this.colPayment});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBookings.Location = new System.Drawing.Point(24, 89);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(873, 300);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // colBookingID
            // 
            this.colBookingID.HeaderText = "Booking ID";
            this.colBookingID.Name = "colBookingID";
            this.colBookingID.ReadOnly = true;
            // 
            // colService
            // 
            this.colService.HeaderText = "Service";
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "Payment";
            this.colPayment.Name = "colPayment";
            this.colPayment.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 28);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Indigo;
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(963, 60);
            this.headerPanel.TabIndex = 8;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(319, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(267, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Booking Management";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // btnRejectBooking
            // 
            this.btnRejectBooking.BackColor = System.Drawing.Color.Maroon;
            this.btnRejectBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectBooking.ForeColor = System.Drawing.Color.White;
            this.btnRejectBooking.Location = new System.Drawing.Point(371, 413);
            this.btnRejectBooking.Name = "btnRejectBooking";
            this.btnRejectBooking.Size = new System.Drawing.Size(177, 40);
            this.btnRejectBooking.TabIndex = 14;
            this.btnRejectBooking.Text = "Reject Booking";
            this.btnRejectBooking.UseVisualStyleBackColor = false;
            this.btnRejectBooking.Click += new System.EventHandler(this.btnRejectBooking_Click);
            // 
            // btnMarkAsPaid
            // 
            this.btnMarkAsPaid.BackColor = System.Drawing.Color.Indigo;
            this.btnMarkAsPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAsPaid.ForeColor = System.Drawing.Color.White;
            this.btnMarkAsPaid.Location = new System.Drawing.Point(580, 413);
            this.btnMarkAsPaid.Name = "btnMarkAsPaid";
            this.btnMarkAsPaid.Size = new System.Drawing.Size(177, 40);
            this.btnMarkAsPaid.TabIndex = 13;
            this.btnMarkAsPaid.Text = "Mark as Paid";
            this.btnMarkAsPaid.UseVisualStyleBackColor = false;
            this.btnMarkAsPaid.Click += new System.EventHandler(this.btnMarkAsPaid_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.BackColor = System.Drawing.Color.Indigo;
            this.btnConfirmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBooking.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBooking.Location = new System.Drawing.Point(166, 413);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(177, 40);
            this.btnConfirmBooking.TabIndex = 12;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // BookingManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(963, 480);
            this.Controls.Add(this.btnRejectBooking);
            this.Controls.Add(this.btnMarkAsPaid);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.dgvBookings);
            this.Name = "BookingManagementForm";
            this.Text = "Booking Management";
            this.Load += new System.EventHandler(this.BookingManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private Button btnBack;
        private Panel headerPanel;
        private Label lblHeading;
        private Button btnRejectBooking;
        private Button btnMarkAsPaid;
        private Button btnConfirmBooking;
    }
}
