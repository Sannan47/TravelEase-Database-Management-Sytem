namespace WindowsFormsApp1
{
    partial class Report4Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guideRatingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report4 = new WindowsFormsApp1.Report4();
            this.hotelOccupancyRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guideRatingsTableAdapter = new WindowsFormsApp1.Report4TableAdapters.GuideRatingsTableAdapter();
            this.hotelOccupancyRateTableAdapter = new WindowsFormsApp1.Report4TableAdapters.HotelOccupancyRateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guideRatingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelOccupancyRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guideRatingsBindingSource
            // 
            this.guideRatingsBindingSource.DataMember = "GuideRatings";
            this.guideRatingsBindingSource.DataSource = this.report4;
            // 
            // report4
            // 
            this.report4.DataSetName = "Report4";
            this.report4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelOccupancyRateBindingSource
            // 
            this.hotelOccupancyRateBindingSource.DataMember = "HotelOccupancyRate";
            this.hotelOccupancyRateBindingSource.DataSource = this.report4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GuideRatings";
            reportDataSource1.Value = this.guideRatingsBindingSource;
            reportDataSource2.Name = "HotelOccupancyRate";
            reportDataSource2.Value = this.hotelOccupancyRateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(855, 615);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // guideRatingsTableAdapter
            // 
            this.guideRatingsTableAdapter.ClearBeforeFill = true;
            // 
            // hotelOccupancyRateTableAdapter
            // 
            this.hotelOccupancyRateTableAdapter.ClearBeforeFill = true;
            // 
            // Report4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 615);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report4Form";
            this.Text = "Report4Form";
            this.Load += new System.EventHandler(this.Report4Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guideRatingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelOccupancyRateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report4 report4;
        private System.Windows.Forms.BindingSource guideRatingsBindingSource;
        private Report4TableAdapters.GuideRatingsTableAdapter guideRatingsTableAdapter;
        private System.Windows.Forms.BindingSource hotelOccupancyRateBindingSource;
        private Report4TableAdapters.HotelOccupancyRateTableAdapter hotelOccupancyRateTableAdapter;
    }
}