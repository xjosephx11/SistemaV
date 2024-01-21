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
    public class NPersona
    {
        public static DataTable listar()
        {
            DPersona Datos = new DPersona();
            return Datos.listar();
        }

        public static DataTable listarProveedores()
        {
            DPersona Datos = new DPersona();
            return Datos.listarProveedores();
        }

        public static DataTable listarClientes()
        {
            DPersona Datos = new DPersona();
            return Datos.listarClientes();
        }

        public static DataTable Buscar(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(Valor);
        }

        public static DataTable BuscarProveedores(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedores(Valor);
        }

        public static DataTable BuscarClientes(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarClientes(Valor);
        }
        public static string Insertar(string TipoPersona, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            string Existe = Datos.Existe(Email);
            if (Existe.Equals("1"))
            {
                return "La persona ya existe";
            }
            else
            {
                Persona obj = new Persona();
                obj.TipoPersona = TipoPersona;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                return Datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id, string TipoPersona,string NombreAnt, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            Persona obj = new Persona();

            if (NombreAnt.Equals(Nombre))
            {
                obj.IdPersona = Id;
                obj.TipoPersona = TipoPersona;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La persona ya existe";
                }
                else
                {
                    obj.IdPersona = Id;
                    obj.TipoPersona = TipoPersona;
                    obj.Nombre = Nombre;
                    obj.TipoDocumento = TipoDocumento;
                    obj.NumDocumento = NumDocumento;
                    obj.Direccion = Direccion;
                    obj.Telefono = Telefono;
                    obj.Email = Email;
                    return Datos.Actualizar(obj);
                }
            }
        }

        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }


    }
}
