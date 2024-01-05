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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void Listar() 
        {
            try
            {
                DgvListado.DataSource = NCategoria.listar();
                this.Formato();
                lblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato() 
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Width = 400;
            DgvListado.Columns[3].HeaderText = "Descripcion";
            DgvListado.Columns[4].Width = 150;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
