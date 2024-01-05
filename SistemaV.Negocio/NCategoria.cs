﻿using SistemaV.Datos;
using SistemaV.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaV.Negocio
{
    public class NCategoria
    {
        public static DataTable listar() 
        {
            DCategoria Datos = new DCategoria();
            return Datos.listar();
        }

        public static DataTable Buscar(string Valor) 
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(Valor);
        }


        public static string Insertar(string Nombre, string Descripcion) 
        {
            DCategoria Datos = new DCategoria();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else 
            {
                Categoria obj = new Categoria();
                obj.Nombre = Nombre;
                obj.Descripcion = Descripcion;
                return Datos.Insertar(obj);
            }
        }

        public static string Actualizar(int Id, string Nombre, string Descripcion) 
        {
            DCategoria Datos = new DCategoria();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.IdCategoria = Id;
                obj.Nombre = Nombre;
                obj.Descripcion = Descripcion;
                return Datos.Actualizar(obj);
            }   
        }

        public static string Eliminar(int Id) 
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(Id);
        }
    }
}
