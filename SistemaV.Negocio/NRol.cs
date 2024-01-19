using SistemaV.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaV.Negocio
{
    public class NRol
    {
        public static DataTable listar()
        {
            DRol Datos = new DRol();
            return Datos.listar();
        }
    }
}
