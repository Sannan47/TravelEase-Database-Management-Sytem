namespace WindowsFormsApp1
{
    partial class Report2Form
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
            this.ageDistruibutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report2Data = new WindowsFormsApp1.Report2Data();
            this.averageSpendingPerTravelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostBookedCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationalityDistruibutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingByNationalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ageDistruibutionTableAdapter = new WindowsFormsApp1.Report2DataTableAdapters.AgeDistruibutionTableAdapter();
            this.averageSpendingPerTravelerTableAdapter = new WindowsFormsApp1.Report2DataTableAdapters.AverageSpendingPerTravelerTableAdapter();
            this.mostBookedCategoriesTableAdapter = new WindowsFormsApp1.Report2DataTableAdapters.MostBookedCategoriesTableAdapter();
            this.nationalityDistruibutionTableAdapter = new WindowsFormsApp1.Report2DataTableAdapters.NationalityDistruibutionTableAdapter();
            this.spendingByNationalityTableAdapter = new WindowsFormsApp1.Report2DataTableAdapters.SpendingByNationalityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ageDistruibutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageSpendingPerTravelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostBookedCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityDistruibutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingByNationalityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ageDistruibutionBindingSource
            // 
            this.ageDistruibutionBindingSource.DataMember = "AgeDistruibution";
            this.ageDistruibutionBindingSource.DataSource = this.report2Data;
            // 
            // report2Data
            // 
            this.report2Data.DataSetName = "Report2Data";
            this.report2Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // averageSpendingPerTravelerBindingSource
            // 
            this.averageSpendingPerTravelerBindingSource.DataMember = "AverageSpendingPerTraveler";
            this.averageSpendingPerTravelerBindingSource.DataSource = this.report2Data;
            // 
            // mostBookedCategoriesBindingSource
            // 
            this.mostBookedCategoriesBindingSource.DataMember = "MostBookedCategories";
            this.mostBookedCategoriesBindingSource.DataSource = this.report2Data;
            // 
            // nationalityDistruibutionBindingSource
            // 
            this.nationalityDistruibutionBindingSource.DataMember = "NationalityDistruibution";
            this.nationalityDistruibutionBindingSource.DataSource = this.report2Data;
            // 
            // spendingByNationalityBindingSource
            // 
            this.spendingByNationalityBindingSource.DataMember = "SpendingByNationality";
            this.spendingByNationalityBindingSource.DataSource = this.report2Data;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AgeDist";
            reportDataSource1.Value = this.ageDistruibutionBindingSource;
            reportDataSource2.Name = "AvgSpendingTrave";
            reportDataSource2.Value = this.averageSpendingPerTravelerBindingSource;
            reportDataSource3.Name = "MostBookedCategories";
            reportDataSource3.Value = this.mostBookedCategoriesBindingSource;
            reportDataSource4.Name = "NationalityDist";
            reportDataSource4.Value = this.nationalityDistruibutionBindingSource;
            reportDataSource5.Name = "SpendingByNationality";
            reportDataSource5.Value = this.spendingByNationalityBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1001, 547);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ageDistruibutionTableAdapter
            // 
            this.ageDistruibutionTableAdapter.ClearBeforeFill = true;
            // 
            // averageSpendingPerTravelerTableAdapter
            // 
            this.averageSpendingPerTravelerTableAdapter.ClearBeforeFill = true;
            // 
            // mostBookedCategoriesTableAdapter
            // 
            this.mostBookedCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // nationalityDistruibutionTableAdapter
            // 
            this.nationalityDistruibutionTableAdapter.ClearBeforeFill = true;
            // 
            // spendingByNationalityTableAdapter
            // 
            this.spendingByNationalityTableAdapter.ClearBeforeFill = true;
            // 
            // Report2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 547);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report2Form";
            this.Text = "Report2Form";
            this.Load += new System.EventHandler(this.Report2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageDistruibutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageSpendingPerTravelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostBookedCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityDistruibutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingByNationalityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report2Data report2Data;
        private System.Windows.Forms.BindingSource ageDistruibutionBindingSource;
        private Report2DataTableAdapters.AgeDistruibutionTableAdapter ageDistruibutionTableAdapter;
        private System.Windows.Forms.BindingSource averageSpendingPerTravelerBindingSource;
        private Report2DataTableAdapters.AverageSpendingPerTravelerTableAdapter averageSpendingPerTravelerTableAdapter;
        private System.Windows.Forms.BindingSource mostBookedCategoriesBindingSource;
        private Report2DataTableAdapters.MostBookedCategoriesTableAdapter mostBookedCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource nationalityDistruibutionBindingSource;
        private Report2DataTableAdapters.NationalityDistruibutionTableAdapter nationalityDistruibutionTableAdapter;
        private System.Windows.Forms.BindingSource spendingByNationalityBindingSource;
        private Report2DataTableAdapters.SpendingByNationalityTableAdapter spendingByNationalityTableAdapter;
    }
}