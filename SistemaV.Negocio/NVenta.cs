using SistemaV.Datos;
using SistemaV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaV.Negocio
{
    public class NVenta
    {
        public static DataTable listar() 
        {
            DVenta Datos = new DVenta();
            return Datos.listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DVenta Datos = new DVenta();
            return Datos.Buscar(Valor);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdCliente, int IdUsuario, string Tipo_Comprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
            DVenta Datos = new DVenta();
            Venta Obj = new Venta();
            Obj.IdCliente = IdCliente;
            Obj.IdUsuario = IdUsuario;
            Obj.TipoComprobante = Tipo_Comprobante;
            Obj.SerieComprobante= SerieComprobante;
            Obj.NumComprobante = NumComprobante;
            Obj.Impuesto = Impuesto;
            Obj.Total = Total;
            Obj.Detalles = Detalles;
            return Datos.Insertar(Obj);
        }

        public static string Anular(int Id) 
        {
            DVenta Datos = new DVenta();
            return Datos.Anular(Id);
        }
    }
}
