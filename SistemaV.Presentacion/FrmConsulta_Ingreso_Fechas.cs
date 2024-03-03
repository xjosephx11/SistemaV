using SistemaV.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaV.Presentacion
{
    public partial class FrmConsulta_Ingreso_Fechas : Form
    {
        public FrmConsulta_Ingreso_Fechas()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.ConsultaFechas(Convert.ToDateTime(DtpFechaInicio.Value),Convert.ToDateTime(DtpFechaFin.Value));
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {//esta lista son la lista de parametros ordenados por columna para mostrar en el datagridview
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[0].Width = 100;
            DgvListado.Columns[1].Width = 60;
            DgvListado.Columns[3].Width = 150;
            DgvListado.Columns[4].Width = 150;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documento";
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[6].HeaderText = "Serie";
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[7].HeaderText = "Numero";
            DgvListado.Columns[8].Width = 60;
            DgvListado.Columns[9].Width = 100;
            DgvListado.Columns[10].Width = 100;
            DgvListado.Columns[11].Width = 100;
        }

        private void Limpiar()
        {
            DgvListado.Columns[0].Visible = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmConsulta_Ingreso_Fechas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //la fuente de poder(datos) vienen de Ningreso, con la funcion listar detalle
                DgvMostrarDetalle.DataSource = NIngreso.ListarDetalle(Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value));
                decimal Total, SubTotal;
                //impuesto es = a la celda seleccionada de la columna impuesto
                decimal Impuesto = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Impuesto"].Value);
                Total = Convert.ToDecimal(DgvListado.CurrentRow.Cells["Total"].Value);
                SubTotal = Total / (1 + Impuesto);
                txtSubTotalD.Text = SubTotal.ToString("#0.00#");
                txtTotalImpuestoD.Text = (Total - SubTotal).ToString("#0.00#");
                txtTotalD.Text = Total.ToString("#0.00#");
                PanelMostrar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComprobanteIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                //enviamos el valor de la celda ID de la fila actual que hemos seleccionado
                Variables.IdIngreso = Convert.ToInt32(DgvListado.CurrentRow.Cells["ID"].Value);
                Reportes.FrmReporteComprobanteIngreso reporte = new Reportes.FrmReporteComprobanteIngreso();
                reporte.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarDetalle_Click(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
        }
    }
}
