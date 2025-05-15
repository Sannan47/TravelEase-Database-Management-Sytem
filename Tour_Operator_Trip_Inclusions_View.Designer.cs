namespace WindowsFormsApp1
{
    partial class ViewInclusionsForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAddInclusion = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 83);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(460, 400);
            this.flowLayoutPanel.TabIndex = 0;
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
            this.headerPanel.Size = new System.Drawing.Size(484, 60);
            this.headerPanel.TabIndex = 29;
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
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(137, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(243, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Trip Inclusions View";
            // 
            // btnAddInclusion
            // 
            this.btnAddInclusion.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddInclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInclusion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddInclusion.ForeColor = System.Drawing.Color.White;
            this.btnAddInclusion.Location = new System.Drawing.Point(322, 507);
            this.btnAddInclusion.Name = "btnAddInclusion";
            this.btnAddInclusion.Size = new System.Drawing.Size(150, 40);
            this.btnAddInclusion.TabIndex = 30;
            this.btnAddInclusion.Text = "Add Inclusion";
            this.btnAddInclusion.UseVisualStyleBackColor = false;
            this.btnAddInclusion.Click += new System.EventHandler(this.btnAddInclusion_Click);
            // 
            // ViewInclusionsForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 559);
            this.Controls.Add(this.btnAddInclusion);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "ViewInclusionsForm";
            this.Text = "Trip Inclusions";
            this.Load += new System.EventHandler(this.ViewInclusionsForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddInclusion;
    }
}
