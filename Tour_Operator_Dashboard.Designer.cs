using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class OperatorDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTotalTrips;
        private Label lblTotalRevenue;
        private GroupBox grpTrips;
        private GroupBox grpCustomers;
        private GroupBox grpUpcomingTrips;
        private GroupBox grpBookings;
        private ListBox lstUpcomingTrips;
        private DataGridView dgvBookings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalTrips = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.grpTrips = new System.Windows.Forms.GroupBox();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.grpUpcomingTrips = new System.Windows.Forms.GroupBox();
            this.lstUpcomingTrips = new System.Windows.Forms.ListBox();
            this.grpBookings = new System.Windows.Forms.GroupBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeading = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateTrip = new System.Windows.Forms.Button();
            this.btnSendReminder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpTrips.SuspendLayout();
            this.grpCustomers.SuspendLayout();
            this.grpUpcomingTrips.SuspendLayout();
            this.grpBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalTrips
            // 
            this.lblTotalTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalTrips.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTotalTrips.Location = new System.Drawing.Point(3, 21);
            this.lblTotalTrips.Name = "lblTotalTrips";
            this.lblTotalTrips.Size = new System.Drawing.Size(174, 76);
            this.lblTotalTrips.TabIndex = 0;
            this.lblTotalTrips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTotalRevenue.Location = new System.Drawing.Point(3, 21);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(174, 76);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTrips
            // 
            this.grpTrips.Controls.Add(this.lblTotalTrips);
            this.grpTrips.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrips.Location = new System.Drawing.Point(27, 99);
            this.grpTrips.Name = "grpTrips";
            this.grpTrips.Size = new System.Drawing.Size(180, 100);
            this.grpTrips.TabIndex = 0;
            this.grpTrips.TabStop = false;
            this.grpTrips.Text = "Total Trips";
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.lblTotalRevenue);
            this.grpCustomers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomers.Location = new System.Drawing.Point(227, 99);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(180, 100);
            this.grpCustomers.TabIndex = 1;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Revenue";
            // 
            // grpUpcomingTrips
            // 
            this.grpUpcomingTrips.Controls.Add(this.lstUpcomingTrips);
            this.grpUpcomingTrips.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpcomingTrips.Location = new System.Drawing.Point(27, 219);
            this.grpUpcomingTrips.Name = "grpUpcomingTrips";
            this.grpUpcomingTrips.Size = new System.Drawing.Size(380, 120);
            this.grpUpcomingTrips.TabIndex = 2;
            this.grpUpcomingTrips.TabStop = false;
            this.grpUpcomingTrips.Text = "Upcoming Trips";
            // 
            // lstUpcomingTrips
            // 
            this.lstUpcomingTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUpcomingTrips.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lstUpcomingTrips.ItemHeight = 17;
            this.lstUpcomingTrips.Location = new System.Drawing.Point(3, 21);
            this.lstUpcomingTrips.Name = "lstUpcomingTrips";
            this.lstUpcomingTrips.Size = new System.Drawing.Size(374, 96);
            this.lstUpcomingTrips.TabIndex = 0;
            this.lstUpcomingTrips.SelectedIndexChanged += new System.EventHandler(this.lstUpcomingTrips_SelectedIndexChanged);
            // 
            // grpBookings
            // 
            this.grpBookings.Controls.Add(this.dgvBookings);
            this.grpBookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookings.Location = new System.Drawing.Point(427, 99);
            this.grpBookings.Name = "grpBookings";
            this.grpBookings.Size = new System.Drawing.Size(550, 240);
            this.grpBookings.TabIndex = 3;
            this.grpBookings.TabStop = false;
            this.grpBookings.Text = "Bookings";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.ColumnHeadersHeight = 29;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomer,
            this.colStatus,
            this.colTrip,
            this.colDate,
            this.colAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(3, 21);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.Size = new System.Drawing.Size(544, 216);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colTrip
            // 
            this.colTrip.HeaderText = "Trip";
            this.colTrip.MinimumWidth = 6;
            this.colTrip.Name = "colTrip";
            this.colTrip.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 6;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(340, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(307, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Tour Operator Dashboard";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1000, 60);
            this.headerPanel.TabIndex = 9;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(933, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCreateTrip
            // 
            this.btnCreateTrip.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCreateTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTrip.ForeColor = System.Drawing.Color.White;
            this.btnCreateTrip.Location = new System.Drawing.Point(102, 360);
            this.btnCreateTrip.Name = "btnCreateTrip";
            this.btnCreateTrip.Size = new System.Drawing.Size(150, 40);
            this.btnCreateTrip.TabIndex = 11;
            this.btnCreateTrip.Text = "Create Trip";
            this.btnCreateTrip.UseVisualStyleBackColor = false;
            this.btnCreateTrip.Click += new System.EventHandler(this.btnCreateTrip_Click);
            // 
            // btnSendReminder
            // 
            this.btnSendReminder.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSendReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendReminder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendReminder.ForeColor = System.Drawing.Color.White;
            this.btnSendReminder.Location = new System.Drawing.Point(414, 360);
            this.btnSendReminder.Name = "btnSendReminder";
            this.btnSendReminder.Size = new System.Drawing.Size(150, 40);
            this.btnSendReminder.TabIndex = 12;
            this.btnSendReminder.Text = "Send Reminder";
            this.btnSendReminder.UseVisualStyleBackColor = false;
            this.btnSendReminder.Click += new System.EventHandler(this.btnSendReminder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(729, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Manage Cancellations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperatorDashboardForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSendReminder);
            this.Controls.Add(this.btnCreateTrip);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.grpTrips);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.grpUpcomingTrips);
            this.Controls.Add(this.grpBookings);
            this.Name = "OperatorDashboardForm";
            this.Text = "Operator Dashboard";
            this.Load += new System.EventHandler(this.OperatorDashboardForm_Load);
            this.grpTrips.ResumeLayout(false);
            this.grpCustomers.ResumeLayout(false);
            this.grpUpcomingTrips.ResumeLayout(false);
            this.grpBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTrip;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colAmount;
        private Label lblHeading;
        private Panel headerPanel;
        private Button btnCreateTrip;
        private Button btnSendReminder;
        private Button button1;
        private PictureBox pictureBox1;
    }
}