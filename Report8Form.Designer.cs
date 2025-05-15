namespace WindowsFormsApp1
{
    partial class Report8Form
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
            this.vwChargebackRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report8data = new WindowsFormsApp1.Report8data();
            this.vwPaymentSuccessFailureRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_ChargebackRateTableAdapter = new WindowsFormsApp1.Report8dataTableAdapters.vw_ChargebackRateTableAdapter();
            this.vw_PaymentSuccessFailureRateTableAdapter = new WindowsFormsApp1.Report8dataTableAdapters.vw_PaymentSuccessFailureRateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwChargebackRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report8data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentSuccessFailureRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vwChargebackRateBindingSource
            // 
            this.vwChargebackRateBindingSource.DataMember = "vw_ChargebackRate";
            this.vwChargebackRateBindingSource.DataSource = this.report8data;
            // 
            // report8data
            // 
            this.report8data.DataSetName = "Report8data";
            this.report8data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwPaymentSuccessFailureRateBindingSource
            // 
            this.vwPaymentSuccessFailureRateBindingSource.DataMember = "vw_PaymentSuccessFailureRate";
            this.vwPaymentSuccessFailureRateBindingSource.DataSource = this.report8data;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ChargeBackRate";
            reportDataSource1.Value = this.vwChargebackRateBindingSource;
            reportDataSource2.Name = "PaymentSuccessRate";
            reportDataSource2.Value = this.vwPaymentSuccessFailureRateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(755, 386);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vw_ChargebackRateTableAdapter
            // 
            this.vw_ChargebackRateTableAdapter.ClearBeforeFill = true;
            // 
            // vw_PaymentSuccessFailureRateTableAdapter
            // 
            this.vw_PaymentSuccessFailureRateTableAdapter.ClearBeforeFill = true;
            // 
            // Report8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 386);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Report8Form";
            this.Text = "Report8Form";
            this.Load += new System.EventHandler(this.Report8Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwChargebackRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report8data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentSuccessFailureRateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report8data report8data;
        private System.Windows.Forms.BindingSource vwChargebackRateBindingSource;
        private Report8dataTableAdapters.vw_ChargebackRateTableAdapter vw_ChargebackRateTableAdapter;
        private System.Windows.Forms.BindingSource vwPaymentSuccessFailureRateBindingSource;
        private Report8dataTableAdapters.vw_PaymentSuccessFailureRateTableAdapter vw_PaymentSuccessFailureRateTableAdapter;
    }
}