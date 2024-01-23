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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(txtEmail.Text.Trim(),txtClave.Text.Trim());
                if (Tabla.Rows.Count <= 0)//si mi objeto tabla no tiene almenos un registro valido
                {
                    MessageBox.Show("El email o la clave es incorrecto", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    //en este caso si tenemos almenos 1 registro
                    if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)//columna 4 es el estado
                    {
                        MessageBox.Show("Este usuario no esta activo.", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        FrmPrincipal Frm = new FrmPrincipal();
                        Variables.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        Frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        Frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        Frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        Frm.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        Frm.Show();//mostramos el frm principal
                        this.Hide();//este formulario se oculta
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
