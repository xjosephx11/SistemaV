using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaV.Datos
{
    public class Conexion2
    {
        private static Conexion2 Con = null;

        private Conexion2() 
        {

        }

        public SqlConnection CrearConexion2() 
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Data Source=DESKTOP-6NBMCT5\\MSSQLSERVER01;Initial Catalog=dbsistema;Integrated Security=True;TrustServerCertificate=True";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion2 getInstancia2()
        {
            if (Con == null)//si no tengo una instancia creada
            {
                Con = new Conexion2();//procedo a crearla y la almaceno en Con para poder ser llamada (esto por que la hicimos privada al principio)
            }
            return Con;
        }
    }
}
