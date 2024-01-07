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
    public class NArticulo
    {
        public static DataTable listar()
        {
            DArticulo Datos = new DArticulo();
            return Datos.listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Buscar(Valor);
        }


        public static string Insertar(int IdCategoria, string Codigo, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo obj = new Articulo();
                obj.IdCategoria = IdCategoria;
                obj.Codigo = Codigo;    
                obj.Nombre = Nombre;
                obj.PrecioVenta = PrecioVenta;
                obj.Stock = Stock;
                obj.Descripcion = Descripcion;
                obj.Imagen = Imagen;
                return Datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id,int IdCategoria, string Codigo, string NombreAnt, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            Articulo obj = new Articulo();

            if (NombreAnt.Equals(Nombre))
            {
                obj.IdArticulo = Id;
                obj.IdCategoria = IdCategoria;
                obj.Codigo = Codigo;
                obj.Nombre = Nombre;
                obj.PrecioVenta = PrecioVenta;
                obj.Stock = Stock;
                obj.Descripcion = Descripcion;
                obj.Imagen = Imagen;
                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    obj.IdArticulo = Id;
                    obj.IdCategoria = IdCategoria;
                    obj.Codigo = Codigo;
                    obj.Nombre = Nombre;
                    obj.PrecioVenta = PrecioVenta;
                    obj.Stock = Stock;
                    obj.Descripcion = Descripcion;
                    obj.Imagen = Imagen;
                    return Datos.Actualizar(obj);
                }
            }
        }

        public static string Eliminar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Desactivar(Id);
        }
    }
}
