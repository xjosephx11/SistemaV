namespace SistemaV.Presentacion.Reportes
{
    partial class FrmReporteComprobanteIngreso
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
            this.ingresocomprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingreso_comprobanteTableAdapter = new SistemaV.Presentacion.Reportes.DsSistemaTableAdapters.ingreso_comprobanteTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ingreso_comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingresocomprobanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresocomprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingreso_comprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresocomprobanteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingresocomprobanteBindingSource
            // 
            this.ingresocomprobanteBindingSource.DataMember = "ingreso_comprobante";
            this.ingresocomprobanteBindingSource.DataSource = this.dsSistema;
            // 
            // ingreso_comprobanteTableAdapter
            // 
            this.ingreso_comprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsComprobanteIngreso";
            reportDataSource1.Value = this.ingresocomprobanteBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaV.Presentacion.Reportes.RptComprobanteIngreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // ingreso_comprobanteBindingSource
            // 
            this.ingreso_comprobanteBindingSource.DataMember = "ingreso_comprobante";
            this.ingreso_comprobanteBindingSource.DataSource = this.dsSistema;
            // 
            // ingresocomprobanteBindingSource1
            // 
            this.ingresocomprobanteBindingSource1.DataMember = "ingreso_comprobante";
            this.ingresocomprobanteBindingSource1.DataSource = this.dsSistema;
            // 
            // FrmReporteComprobanteIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteComprobanteIngreso";
            this.Text = "Reporte comprobante de ingreso";
            this.Load += new System.EventHandler(this.FrmReporteComprobanteIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresocomprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingreso_comprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresocomprobanteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ingresocomprobanteBindingSource;
        private DsSistema dsSistema;
        private DsSistemaTableAdapters.ingreso_comprobanteTableAdapter ingreso_comprobanteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ingreso_comprobanteBindingSource;
        private System.Windows.Forms.BindingSource ingresocomprobanteBindingSource1;
    }
}