namespace WindowsFormsApp1
{
    partial class Report6Form
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
            this.abandonmentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report6 = new WindowsFormsApp1.Report6();
            this.commonReasonsforAbandonmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potentialRevenueLossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recoveryRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.abandonmentRateTableAdapter = new WindowsFormsApp1.Report6TableAdapters.AbandonmentRateTableAdapter();
            this.commonReasonsforAbandonmentTableAdapter = new WindowsFormsApp1.Report6TableAdapters.CommonReasonsforAbandonmentTableAdapter();
            this.potentialRevenueLossTableAdapter = new WindowsFormsApp1.Report6TableAdapters.PotentialRevenueLossTableAdapter();
            this.recoveryRateTableAdapter = new WindowsFormsApp1.Report6TableAdapters.RecoveryRateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.abandonmentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonReasonsforAbandonmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potentialRevenueLossBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // abandonmentRateBindingSource
            // 
            this.abandonmentRateBindingSource.DataMember = "AbandonmentRate";
            this.abandonmentRateBindingSource.DataSource = this.report6;
            // 
            // report6
            // 
            this.report6.DataSetName = "Report6";
            this.report6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commonReasonsforAbandonmentBindingSource
            // 
            this.commonReasonsforAbandonmentBindingSource.DataMember = "CommonReasonsforAbandonment";
            this.commonReasonsforAbandonmentBindingSource.DataSource = this.report6;
            // 
            // potentialRevenueLossBindingSource
            // 
            this.potentialRevenueLossBindingSource.DataMember = "PotentialRevenueLoss";
            this.potentialRevenueLossBindingSource.DataSource = this.report6;
            // 
            // recoveryRateBindingSource
            // 
            this.recoveryRateBindingSource.DataMember = "RecoveryRate";
            this.recoveryRateBindingSource.DataSource = this.report6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AbandonmentRate";
            reportDataSource1.Value = this.abandonmentRateBindingSource;
            reportDataSource2.Name = "CommonReasons";
            reportDataSource2.Value = this.commonReasonsforAbandonmentBindingSource;
            reportDataSource3.Name = "PotentialLoss";
            reportDataSource3.Value = this.potentialRevenueLossBindingSource;
            reportDataSource4.Name = "RecoveryRate";
            reportDataSource4.Value = this.recoveryRateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1156, 558);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // abandonmentRateTableAdapter
            // 
            this.abandonmentRateTableAdapter.ClearBeforeFill = true;
            // 
            // commonReasonsforAbandonmentTableAdapter
            // 
            this.commonReasonsforAbandonmentTableAdapter.ClearBeforeFill = true;
            // 
            // potentialRevenueLossTableAdapter
            // 
            this.potentialRevenueLossTableAdapter.ClearBeforeFill = true;
            // 
            // recoveryRateTableAdapter
            // 
            this.recoveryRateTableAdapter.ClearBeforeFill = true;
            // 
            // Report6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 558);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report6Form";
            this.Text = "Report6Form";
            this.Load += new System.EventHandler(this.Report6Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abandonmentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonReasonsforAbandonmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potentialRevenueLossBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryRateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report6 report6;
        private System.Windows.Forms.BindingSource abandonmentRateBindingSource;
        private Report6TableAdapters.AbandonmentRateTableAdapter abandonmentRateTableAdapter;
        private System.Windows.Forms.BindingSource commonReasonsforAbandonmentBindingSource;
        private Report6TableAdapters.CommonReasonsforAbandonmentTableAdapter commonReasonsforAbandonmentTableAdapter;
        private System.Windows.Forms.BindingSource potentialRevenueLossBindingSource;
        private Report6TableAdapters.PotentialRevenueLossTableAdapter potentialRevenueLossTableAdapter;
        private System.Windows.Forms.BindingSource recoveryRateBindingSource;
        private Report6TableAdapters.RecoveryRateTableAdapter recoveryRateTableAdapter;
    }
}