using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaV.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "DESKTOP-6NBMCT5\\MSSQLSERVER01";
            this.Usuario = "sa";
            this.Clave = "jgamboa12";
            this.Seguridad = true;
        }
        public SqlConnection CrearConexion() 
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {//establesemos si la conexion es por medio de windows (sin logueo de cuenta en sql que seria true) o si es necesario el ingreso por medio de la cuenta que seria false
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else 
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia() 
        {
            if (Con == null)//si no tengo una instancia creada
            {
                Con = new Conexion();//procedo a crearla y la almaceno en Con para poder ser llamada (esto por que la hicimos privada al principio)
            }
            return Con;
        }



    }
}
