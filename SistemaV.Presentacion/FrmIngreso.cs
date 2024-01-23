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
    public partial class FrmIngreso : Form
    {
        private DataTable DtDetalle = new DataTable();
        public FrmIngreso()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.listar();
                this.Formato();
                this.Limpiar();
                lblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NIngreso.Buscar(txtBuscar.Text.Trim());
                this.Formato();
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
            txtBuscar.Clear();
            txtId.Clear();
            btnInsertar.Visible = true;
            errorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            btnAnular.Visible = false;
            chkSeleccionar.Checked = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CrearTabla() 
        {//agregar columnas al datatable, este metodo espera 2 parametros, el nombre de la columna y su tipo
            this.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));

            DgvDetalle.DataSource = this.DtDetalle;//la fuente de datos del datagridview sea este

            //formato para las columnas con variables
            DgvDetalle.Columns[0].Visible = false;
            DgvDetalle.Columns[1].HeaderText = "Codigo";
            DgvDetalle.Columns[1].Width = 100;
            DgvDetalle.Columns[2].HeaderText = "Articulo";
            DgvDetalle.Columns[2].Width = 200;
            DgvDetalle.Columns[3].HeaderText = "Cantidad";
            DgvDetalle.Columns[3].Width = 70;
            DgvDetalle.Columns[4].HeaderText = "Precio";
            DgvDetalle.Columns[4].Width = 70;
            DgvDetalle.Columns[5].HeaderText = "Importe";
            DgvDetalle.Columns[5].Width = 80;

            //columnas de solo lectura
            DgvDetalle.Columns[1].ReadOnly = true;//codigo
            DgvDetalle.Columns[2].ReadOnly = true;//articulo
            DgvDetalle.Columns[5].ReadOnly = true;//importe
        }

        private void FormatoArticulos() 
        {//formato para listar en el datagridview los parametros de los articulos
            dgvArticulos.Columns[1].Visible = false;
            dgvArticulos.Columns[1].Width = 50;
            dgvArticulos.Columns[2].Width = 100;
            dgvArticulos.Columns[2].HeaderText = "Categoria";
            dgvArticulos.Columns[3].Width = 100;
            dgvArticulos.Columns[3].HeaderText = "Codigo";
            dgvArticulos.Columns[4].Width = 150;
            dgvArticulos.Columns[5].Width = 100;
            dgvArticulos.Columns[5].HeaderText = "Precio Venta";
            dgvArticulos.Columns[6].Width = 60;
            dgvArticulos.Columns[7].Width = 200;
            dgvArticulos.Columns[7].HeaderText = "Descripcion";
            dgvArticulos.Columns[8].Width = 100;
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CrearTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVista_ProveedorIngreso Vista = new FrmVista_ProveedorIngreso();
            Vista.ShowDialog();
            txtIdProveedor.Text = Convert.ToString(Variables.IdProveedor);
            txtNombreProveedor.Text = Variables.NombreProveedor;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {//metodo para cuando apretamos la tecla enter
            try
            {
                if (e.KeyCode == Keys.Enter)//si la tecla apretada es ENTER
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NArticulo.BuscarCodigo(txtCodigo.Text.Trim());
                    if (Tabla.Rows.Count <= 0)
                    {//en caso de que no exista
                        this.MensajeError("No existe un articulo con ese codigo.");
                    }
                    else 
                    {//en caso de que si exista, agregamos al detalle
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]),
                            Convert.ToString(Tabla.Rows[0][1]), 
                            Convert.ToString(Tabla.Rows[0][2]), 
                            Convert.ToDecimal(Tabla.Rows[0][3]));
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarDetalle(int IdArticulo, string Codigo, string Nombre, decimal Precio) 
        {
            bool Agregar = true;
            foreach (DataRow FilaTemp in DtDetalle.Rows)//recorrer todos los detalles que ya tenemos, y verificamos si el articulo ya se encuentra agregado
            {
                if (Convert.ToInt32(FilaTemp["idarticulo"]) == IdArticulo)//fi ya hay una fila cuyo articulo estoy seleccionando, no se permite agregar otraves
                {
                    Agregar = false;
                    this.MensajeError("El articulo ya ha sido agregado.");
                }
            }
            if (Agregar)//si es igual a true, significa que no esta agregado
            {
                DataRow Fila = DtDetalle.NewRow();
                Fila["idarticulo"] = IdArticulo;
                Fila["codigo"] = Codigo;
                Fila["articulo"] = Nombre;
                Fila["cantidad"] = 1;
                Fila["precio"] = Precio;
                Fila["importe"] = Precio;
                this.DtDetalle.Rows.Add(Fila);
                this.CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            if (DgvDetalle.Rows.Count == 0)
            {
                Total = 0;
            }
            else 
            {
                foreach (DataRow Filatem in DtDetalle.Rows)//recorrer todos los articulos agregados al detalle
                {
                    Total = Total + Convert.ToDecimal(Filatem["importe"]);
                }
            }
            SubTotal = Total / (1 + Convert.ToDecimal(txtImpuesto.Text));
            txtTotal.Text = Total.ToString("#0.00#");
            txtSubTotal.Text = SubTotal.ToString("#0.00#");
            txtTotalImpuesto.Text = (Total - SubTotal).ToString("#0.00#");
        }
        private void btnVerArticulos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = true;
        }

        private void btnCerrarArticulos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;
        }

        private void btnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                //de la fuente de datos de la clase narticulo su metodo buscar, cargar la informacion a mi dgvarticulos
                dgvArticulos.DataSource = NArticulo.Buscar(txtBuscarArticulo.Text.Trim());
                lblTotalArticulos.Text = "Total Registros :" + Convert.ToString(dgvArticulos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //seleccionar un articulo del listado y los valores de esa fila pasarlos al detalle
            int IdArticulo;
            string Codigo, Nombre;
            decimal Precio;
            IdArticulo = Convert.ToInt32(dgvArticulos.CurrentRow.Cells["ID"].Value);
            Codigo = Convert.ToString(dgvArticulos.CurrentRow.Cells["Codigo"].Value);
            Nombre = Convert.ToString(dgvArticulos.CurrentRow.Cells["Nombre"].Value);
            Precio = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells["Precio_Venta"].Value);
            this.AgregarDetalle(IdArticulo,Codigo,Nombre,Precio);
        }

        private void DgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //capturamos la fila de la celda que modificamos (precio o cantidad)
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            Fila["importe"] = Precio * Cantidad;
            this.CalcularTotales();
        }

        private void DgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotales();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtIdProveedor.Text == string.Empty || txtImpuesto.Text == string.Empty || txtNumComprobante.Text == string.Empty || DtDetalle.Rows.Count == 0)
                {
                    this.MensajeError("Falta ingresar algunos datos, seran remarcados.");
                    errorIcono.SetError(txtIdProveedor, "Seleccione un proveedor");
                    errorIcono.SetError(txtImpuesto, "Digite un impuesto");
                    errorIcono.SetError(txtNumComprobante, "Ingrese el numero del comprobante");
                    errorIcono.SetError(DgvDetalle, "Debe tener al menos un detalle.");
                }
                else
                {
                    respuesta = NIngreso.Insertar(Convert.ToInt32(txtIdProveedor.Text),Variables.IdUsuario,cboComprobante.Text,txtSerieComrpobante.Text.Trim(),txtNumComprobante.Text.Trim(),Convert.ToDecimal(txtImpuesto.Text),Convert.ToDecimal(txtTotal.Text),DtDetalle);
                    if (respuesta.Equals("OK"))
                    {
                        this.MensajeOk("Registro almacenado correctamente.");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
