namespace WindowsFormsApp1
{
    partial class ViewItineraryForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAddItinerary = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 90);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(349, 400);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 17);
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
            this.headerPanel.Size = new System.Drawing.Size(376, 60);
            this.headerPanel.TabIndex = 28;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(109, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(175, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Itinerary View";
            // 
            // btnAddItinerary
            // 
            this.btnAddItinerary.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddItinerary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItinerary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddItinerary.ForeColor = System.Drawing.Color.White;
            this.btnAddItinerary.Location = new System.Drawing.Point(211, 507);
            this.btnAddItinerary.Name = "btnAddItinerary";
            this.btnAddItinerary.Size = new System.Drawing.Size(150, 40);
            this.btnAddItinerary.TabIndex = 29;
            this.btnAddItinerary.Text = "Add Itinerary";
            this.btnAddItinerary.UseVisualStyleBackColor = false;
            this.btnAddItinerary.Click += new System.EventHandler(this.btnAddItinerary_Click);
            // 
            // ViewItineraryForm
            // 
            this.ClientSize = new System.Drawing.Size(376, 558);
            this.Controls.Add(this.btnAddItinerary);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "ViewItineraryForm";
            this.Text = "Itinerary";
            this.Load += new System.EventHandler(this.ViewItineraryForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddItinerary;
    }
}
