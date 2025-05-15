namespace WindowsFormsApp1
{
    partial class Report5Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mostBookedDestinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelEaseDataSet13 = new WindowsFormsApp1.TravelEaseDataSet13();
            this.monthlyTrendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelerSatisfactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergingDestinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.emergingDestinationsTableAdapter = new WindowsFormsApp1.TravelEaseDataSet13TableAdapters.EmergingDestinationsTableAdapter();
            this.monthlyTrendsTableAdapter = new WindowsFormsApp1.TravelEaseDataSet13TableAdapters.MonthlyTrendsTableAdapter();
            this.mostBookedDestinationsTableAdapter = new WindowsFormsApp1.TravelEaseDataSet13TableAdapters.MostBookedDestinationsTableAdapter();
            this.travelerSatisfactionTableAdapter = new WindowsFormsApp1.TravelEaseDataSet13TableAdapters.TravelerSatisfactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mostBookedDestinationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyTrendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelerSatisfactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergingDestinationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mostBookedDestinationsBindingSource
            // 
            this.mostBookedDestinationsBindingSource.DataMember = "MostBookedDestinations";
            this.mostBookedDestinationsBindingSource.DataSource = this.travelEaseDataSet13;
            // 
            // travelEaseDataSet13
            // 
            this.travelEaseDataSet13.DataSetName = "TravelEaseDataSet13";
            this.travelEaseDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthlyTrendsBindingSource
            // 
            this.monthlyTrendsBindingSource.DataMember = "MonthlyTrends";
            this.monthlyTrendsBindingSource.DataSource = this.travelEaseDataSet13;
            // 
            // travelerSatisfactionBindingSource
            // 
            this.travelerSatisfactionBindingSource.DataMember = "TravelerSatisfaction";
            this.travelerSatisfactionBindingSource.DataSource = this.travelEaseDataSet13;
            // 
            // emergingDestinationsBindingSource
            // 
            this.emergingDestinationsBindingSource.DataMember = "EmergingDestinations";
            this.emergingDestinationsBindingSource.DataSource = this.travelEaseDataSet13;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mostBookedDestinationsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.monthlyTrendsBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.travelerSatisfactionBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.emergingDestinationsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1072, 683);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // emergingDestinationsTableAdapter
            // 
            this.emergingDestinationsTableAdapter.ClearBeforeFill = true;
            // 
            // monthlyTrendsTableAdapter
            // 
            this.monthlyTrendsTableAdapter.ClearBeforeFill = true;
            // 
            // mostBookedDestinationsTableAdapter
            // 
            this.mostBookedDestinationsTableAdapter.ClearBeforeFill = true;
            // 
            // travelerSatisfactionTableAdapter
            // 
            this.travelerSatisfactionTableAdapter.ClearBeforeFill = true;
            // 
            // Report5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 683);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report5Form";
            this.Text = "Report5Form";
            this.Load += new System.EventHandler(this.Report5Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostBookedDestinationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyTrendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelerSatisfactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergingDestinationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TravelEaseDataSet13 travelEaseDataSet13;
        private System.Windows.Forms.BindingSource emergingDestinationsBindingSource;
        private TravelEaseDataSet13TableAdapters.EmergingDestinationsTableAdapter emergingDestinationsTableAdapter;
        private System.Windows.Forms.BindingSource monthlyTrendsBindingSource;
        private TravelEaseDataSet13TableAdapters.MonthlyTrendsTableAdapter monthlyTrendsTableAdapter;
        private System.Windows.Forms.BindingSource mostBookedDestinationsBindingSource;
        private TravelEaseDataSet13TableAdapters.MostBookedDestinationsTableAdapter mostBookedDestinationsTableAdapter;
        private System.Windows.Forms.BindingSource travelerSatisfactionBindingSource;
        private TravelEaseDataSet13TableAdapters.TravelerSatisfactionTableAdapter travelerSatisfactionTableAdapter;
    }
}