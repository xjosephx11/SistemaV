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
    public class NUsuario
    {
        public static DataTable listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(Valor);
        }

        public static DataTable Login(string Email,string Clave)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(Email,Clave);
        }


        public static string Insertar(int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email, string Clave)
        {
            DUsuario Datos = new DUsuario();
            string Existe = Datos.Existe(Email);
            if (Existe.Equals("1"))
            {
                return "El usuario ya existe";
            }
            else
            {
                Usuario obj = new Usuario();
                obj.IdRol = IdRol;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumeroDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                obj.Clave = Clave;
                return Datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id, int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono,string EmailAnt, string Email, string Clave)                               
        {
            DUsuario Datos = new DUsuario();
            Usuario obj = new Usuario();

            if (EmailAnt.Equals(Email))
            {
                obj.IdUsuario = Id;
                obj.IdRol = IdRol;
                obj.Nombre = Nombre;
                obj.TipoDocumento = TipoDocumento;
                obj.NumeroDocumento = NumDocumento;
                obj.Direccion = Direccion;
                obj.Telefono = Telefono;
                obj.Email = Email;
                obj.Clave = Clave;
                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    return "El usuario ya existe";
                }
                else
                {
                    obj.IdUsuario = Id;
                    obj.IdRol = IdRol;
                    obj.Nombre = Nombre;
                    obj.TipoDocumento = TipoDocumento;
                    obj.NumeroDocumento = NumDocumento;
                    obj.Direccion = Direccion;
                    obj.Telefono = Telefono;
                    obj.Email = Email;
                    obj.Clave = Clave;
                    return Datos.Actualizar(obj);
                }
            }
        }

        public static string Eliminar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(Id);
        }
    }
}
