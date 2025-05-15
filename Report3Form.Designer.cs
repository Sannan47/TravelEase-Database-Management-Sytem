namespace WindowsFormsApp1
{
    partial class Report3Form
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
            this.averageOperatorRatingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report3Data = new WindowsFormsApp1.Report3Data();
            this.revenuePerOperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.averageOperatorRatingTableAdapter = new WindowsFormsApp1.Report3DataTableAdapters.AverageOperatorRatingTableAdapter();
            this.revenuePerOperatorTableAdapter = new WindowsFormsApp1.Report3DataTableAdapters.RevenuePerOperatorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.averageOperatorRatingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenuePerOperatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // averageOperatorRatingBindingSource
            // 
            this.averageOperatorRatingBindingSource.DataMember = "AverageOperatorRating";
            this.averageOperatorRatingBindingSource.DataSource = this.report3Data;
            // 
            // report3Data
            // 
            this.report3Data.DataSetName = "Report3Data";
            this.report3Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revenuePerOperatorBindingSource
            // 
            this.revenuePerOperatorBindingSource.DataMember = "RevenuePerOperator";
            this.revenuePerOperatorBindingSource.DataSource = this.report3Data;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AvgopRating";
            reportDataSource1.Value = this.averageOperatorRatingBindingSource;
            reportDataSource2.Name = "RevenueOp";
            reportDataSource2.Value = this.revenuePerOperatorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(835, 566);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // averageOperatorRatingTableAdapter
            // 
            this.averageOperatorRatingTableAdapter.ClearBeforeFill = true;
            // 
            // revenuePerOperatorTableAdapter
            // 
            this.revenuePerOperatorTableAdapter.ClearBeforeFill = true;
            // 
            // Report3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 566);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report3Form";
            this.Text = "Report3Form";
            this.Load += new System.EventHandler(this.Report3Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.averageOperatorRatingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report3Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenuePerOperatorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report3Data report3Data;
        private System.Windows.Forms.BindingSource averageOperatorRatingBindingSource;
        private Report3DataTableAdapters.AverageOperatorRatingTableAdapter averageOperatorRatingTableAdapter;
        private System.Windows.Forms.BindingSource revenuePerOperatorBindingSource;
        private Report3DataTableAdapters.RevenuePerOperatorTableAdapter revenuePerOperatorTableAdapter;
    }
}