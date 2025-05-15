namespace WindowsFormsApp1
{
    partial class Report1Form
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.trprevenuecategory = new WindowsFormsApp1.trprevenuecategory();
            this.trprevenuecategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwRevenueByTripCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RevenueByTripCategoryTableAdapter = new WindowsFormsApp1.trprevenuecategoryTableAdapters.vw_RevenueByTripCategoryTableAdapter();
            this.travelEaseDataSet9 = new WindowsFormsApp1.TravelEaseDataSet9();
            this.vwTotalBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_TotalBookingsTableAdapter = new WindowsFormsApp1.TravelEaseDataSet9TableAdapters.vw_TotalBookingsTableAdapter();
            this.travelEaseDataSet10 = new WindowsFormsApp1.TravelEaseDataSet10();
            this.vwCancellationRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_CancellationRateTableAdapter = new WindowsFormsApp1.TravelEaseDataSet10TableAdapters.vw_CancellationRateTableAdapter();
            this.travelEaseDataSet11 = new WindowsFormsApp1.TravelEaseDataSet11();
            this.vwPeakBookingPeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_PeakBookingPeriodsTableAdapter = new WindowsFormsApp1.TravelEaseDataSet11TableAdapters.vw_PeakBookingPeriodsTableAdapter();
            this.travelEaseDataSet12 = new WindowsFormsApp1.TravelEaseDataSet12();
            this.vwAverageBookingValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_AverageBookingValueTableAdapter = new WindowsFormsApp1.TravelEaseDataSet12TableAdapters.vw_AverageBookingValueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.trprevenuecategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trprevenuecategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRevenueByTripCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTotalBookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCancellationRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPeakBookingPeriodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAverageBookingValueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwRevenueByTripCategoryBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.vwTotalBookingsBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.vwCancellationRateBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.vwPeakBookingPeriodsBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.vwAverageBookingValueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1272, 694);
            this.reportViewer1.TabIndex = 0;
            // 
            // trprevenuecategory
            // 
            this.trprevenuecategory.DataSetName = "trprevenuecategory";
            this.trprevenuecategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trprevenuecategoryBindingSource
            // 
            this.trprevenuecategoryBindingSource.DataSource = this.trprevenuecategory;
            this.trprevenuecategoryBindingSource.Position = 0;
            // 
            // vwRevenueByTripCategoryBindingSource
            // 
            this.vwRevenueByTripCategoryBindingSource.DataMember = "vw_RevenueByTripCategory";
            this.vwRevenueByTripCategoryBindingSource.DataSource = this.trprevenuecategoryBindingSource;
            // 
            // vw_RevenueByTripCategoryTableAdapter
            // 
            this.vw_RevenueByTripCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // travelEaseDataSet9
            // 
            this.travelEaseDataSet9.DataSetName = "TravelEaseDataSet9";
            this.travelEaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwTotalBookingsBindingSource
            // 
            this.vwTotalBookingsBindingSource.DataMember = "vw_TotalBookings";
            this.vwTotalBookingsBindingSource.DataSource = this.travelEaseDataSet9;
            // 
            // vw_TotalBookingsTableAdapter
            // 
            this.vw_TotalBookingsTableAdapter.ClearBeforeFill = true;
            // 
            // travelEaseDataSet10
            // 
            this.travelEaseDataSet10.DataSetName = "TravelEaseDataSet10";
            this.travelEaseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCancellationRateBindingSource
            // 
            this.vwCancellationRateBindingSource.DataMember = "vw_CancellationRate";
            this.vwCancellationRateBindingSource.DataSource = this.travelEaseDataSet10;
            // 
            // vw_CancellationRateTableAdapter
            // 
            this.vw_CancellationRateTableAdapter.ClearBeforeFill = true;
            // 
            // travelEaseDataSet11
            // 
            this.travelEaseDataSet11.DataSetName = "TravelEaseDataSet11";
            this.travelEaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwPeakBookingPeriodsBindingSource
            // 
            this.vwPeakBookingPeriodsBindingSource.DataMember = "vw_PeakBookingPeriods";
            this.vwPeakBookingPeriodsBindingSource.DataSource = this.travelEaseDataSet11;
            // 
            // vw_PeakBookingPeriodsTableAdapter
            // 
            this.vw_PeakBookingPeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // travelEaseDataSet12
            // 
            this.travelEaseDataSet12.DataSetName = "TravelEaseDataSet12";
            this.travelEaseDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAverageBookingValueBindingSource
            // 
            this.vwAverageBookingValueBindingSource.DataMember = "vw_AverageBookingValue";
            this.vwAverageBookingValueBindingSource.DataSource = this.travelEaseDataSet12;
            // 
            // vw_AverageBookingValueTableAdapter
            // 
            this.vw_AverageBookingValueTableAdapter.ClearBeforeFill = true;
            // 
            // RViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 694);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RViewer";
            this.Text = "RViewer";
            this.Load += new System.EventHandler(this.RViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trprevenuecategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trprevenuecategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRevenueByTripCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTotalBookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCancellationRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPeakBookingPeriodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelEaseDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAverageBookingValueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource trprevenuecategoryBindingSource;
        private trprevenuecategory trprevenuecategory;
        private System.Windows.Forms.BindingSource vwRevenueByTripCategoryBindingSource;
        private trprevenuecategoryTableAdapters.vw_RevenueByTripCategoryTableAdapter vw_RevenueByTripCategoryTableAdapter;
        private TravelEaseDataSet9 travelEaseDataSet9;
        private System.Windows.Forms.BindingSource vwTotalBookingsBindingSource;
        private TravelEaseDataSet9TableAdapters.vw_TotalBookingsTableAdapter vw_TotalBookingsTableAdapter;
        private TravelEaseDataSet10 travelEaseDataSet10;
        private System.Windows.Forms.BindingSource vwCancellationRateBindingSource;
        private TravelEaseDataSet10TableAdapters.vw_CancellationRateTableAdapter vw_CancellationRateTableAdapter;
        private TravelEaseDataSet11 travelEaseDataSet11;
        private System.Windows.Forms.BindingSource vwPeakBookingPeriodsBindingSource;
        private TravelEaseDataSet11TableAdapters.vw_PeakBookingPeriodsTableAdapter vw_PeakBookingPeriodsTableAdapter;
        private TravelEaseDataSet12 travelEaseDataSet12;
        private System.Windows.Forms.BindingSource vwAverageBookingValueBindingSource;
        private TravelEaseDataSet12TableAdapters.vw_AverageBookingValueTableAdapter vw_AverageBookingValueTableAdapter;
    }
}