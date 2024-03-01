namespace SistemaV.Presentacion.Reportes
{
    partial class FrmReporteComprobanteVenta
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
            this.dsSistema = new SistemaV.Presentacion.Reportes.DsSistema();
            this.ventacomprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venta_comprobanteTableAdapter = new SistemaV.Presentacion.Reportes.DsSistemaTableAdapters.venta_comprobanteTableAdapter();
            this.ventacomprobanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventacomprobanteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.venta_comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventacomprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventacomprobanteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventacomprobanteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_comprobanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventacomprobanteBindingSource
            // 
            this.ventacomprobanteBindingSource.DataMember = "venta_comprobante";
            this.ventacomprobanteBindingSource.DataSource = this.dsSistema;
            // 
            // venta_comprobanteTableAdapter
            // 
            this.venta_comprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // ventacomprobanteBindingSource1
            // 
            this.ventacomprobanteBindingSource1.DataMember = "venta_comprobante";
            this.ventacomprobanteBindingSource1.DataSource = this.dsSistema;
            // 
            // ventacomprobanteBindingSource2
            // 
            this.ventacomprobanteBindingSource2.DataMember = "venta_comprobante";
            this.ventacomprobanteBindingSource2.DataSource = this.dsSistema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsComrpobanteVenta";
            reportDataSource1.Value = this.venta_comprobanteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaV.Presentacion.Reportes.RptComprobanteVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // venta_comprobanteBindingSource
            // 
            this.venta_comprobanteBindingSource.DataMember = "venta_comprobante";
            this.venta_comprobanteBindingSource.DataSource = this.dsSistema;
            // 
            // FrmReporteComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteComprobanteVenta";
            this.Text = "Reporte Comprobante Venta";
            this.Load += new System.EventHandler(this.FrmReporteComprobanteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventacomprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventacomprobanteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventacomprobanteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_comprobanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ventacomprobanteBindingSource;
        private DsSistema dsSistema;
        private DsSistemaTableAdapters.venta_comprobanteTableAdapter venta_comprobanteTableAdapter;
        private System.Windows.Forms.BindingSource ventacomprobanteBindingSource1;
        private System.Windows.Forms.BindingSource ventacomprobanteBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource venta_comprobanteBindingSource;
    }
}