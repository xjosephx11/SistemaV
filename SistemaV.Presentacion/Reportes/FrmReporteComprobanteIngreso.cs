using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaV.Presentacion.Reportes
{
    public partial class FrmReporteComprobanteIngreso : Form
    {
        public FrmReporteComprobanteIngreso()
        {
            InitializeComponent();
        }

        private void FrmReporteComprobanteIngreso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSistema.ingreso_comprobante' table. You can move, or remove it, as needed.
            this.ingreso_comprobanteTableAdapter.Fill(this.dsSistema.ingreso_comprobante,Variables.IdIngreso);

            this.reportViewer1.RefreshReport();
        }
    }
}
