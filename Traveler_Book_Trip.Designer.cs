using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TravelEase
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.TextBox txtTrip;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblTravelers;
        private System.Windows.Forms.NumericUpDown nudTravelers;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCostAmount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTrip = new System.Windows.Forms.Label();
            this.txtTrip = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblTravelers = new System.Windows.Forms.Label();
            this.nudTravelers = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCostAmount = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTravelers)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrip
            // 
            this.lblTrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(28, 78);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(100, 23);
            this.lblTrip.TabIndex = 1;
            this.lblTrip.Text = "Trip";
            // 
            // txtTrip
            // 
            this.txtTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTrip.Location = new System.Drawing.Point(28, 104);
            this.txtTrip.Name = "txtTrip";
            this.txtTrip.Size = new System.Drawing.Size(340, 30);
            this.txtTrip.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(28, 137);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 21);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(28, 161);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(340, 30);
            this.txtFullName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(28, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 26);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(28, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(28, 268);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(100, 23);
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "Room Type";
            this.lblRoomType.Click += new System.EventHandler(this.lblRoomType_Click);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoomType.Location = new System.Drawing.Point(28, 294);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(150, 31);
            this.cmbRoomType.TabIndex = 10;
            // 
            // lblTravelers
            // 
            this.lblTravelers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelers.Location = new System.Drawing.Point(204, 268);
            this.lblTravelers.Name = "lblTravelers";
            this.lblTravelers.Size = new System.Drawing.Size(100, 23);
            this.lblTravelers.TabIndex = 11;
            this.lblTravelers.Text = "Number of Travelers";
            // 
            // nudTravelers
            // 
            this.nudTravelers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudTravelers.Location = new System.Drawing.Point(208, 294);
            this.nudTravelers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTravelers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTravelers.Name = "nudTravelers";
            this.nudTravelers.Size = new System.Drawing.Size(120, 30);
            this.nudTravelers.TabIndex = 12;
            this.nudTravelers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(26, 333);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(80, 23);
            this.lblTotalCost.TabIndex = 13;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblCostAmount
            // 
            this.lblCostAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostAmount.Location = new System.Drawing.Point(112, 333);
            this.lblCostAmount.Name = "lblCostAmount";
            this.lblCostAmount.Size = new System.Drawing.Size(200, 30);
            this.lblCostAmount.TabIndex = 14;
            this.lblCostAmount.Text = "$0.00";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.lblHeading);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.Maroon;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(400, 60);
            this.headerPanel.TabIndex = 16;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(121, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(183, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Book A Trip";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(26, 380);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(342, 40);
            this.btnBook.TabIndex = 17;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // BookingForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 444);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.txtTrip);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblTravelers);
            this.Controls.Add(this.nudTravelers);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCostAmount);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book a Trip";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTravelers)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Panel headerPanel;
        private Label lblHeading;
        private Button btnBook;
    }
}
