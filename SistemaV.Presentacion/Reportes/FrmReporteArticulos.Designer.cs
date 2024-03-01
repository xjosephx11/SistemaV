﻿namespace SistemaV.Presentacion.Reportes
{
    partial class FrmReporteArticulos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSistema = new SistemaV.Presentacion.Reportes.DsSistema();
            this.articulolistarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulo_listarTableAdapter = new SistemaV.Presentacion.Reportes.DsSistemaTableAdapters.articulo_listarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulolistarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsArticulo";
            reportDataSource1.Value = this.articulolistarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaV.Presentacion.Reportes.RptArticulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 615);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "DsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulolistarBindingSource
            // 
            this.articulolistarBindingSource.DataMember = "articulo_listar";
            this.articulolistarBindingSource.DataSource = this.dsSistema;
            // 
            // articulo_listarTableAdapter
            // 
            this.articulo_listarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteArticulos";
            this.Text = "Reporte de Articulos";
            this.Load += new System.EventHandler(this.FrmReporteArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulolistarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsSistema dsSistema;
        private System.Windows.Forms.BindingSource articulolistarBindingSource;
        private DsSistemaTableAdapters.articulo_listarTableAdapter articulo_listarTableAdapter;
    }
}