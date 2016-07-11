﻿using Servicios.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.servicios
{
    public static class CategoriaService
    {
        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        #endregion

        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/
        #region
        public static Categoria FindById(Int32 id)
        {
            Categoria c = null;
            String comando = String.Format("select nombre from categoria where id_categoria={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                String nombre = (String)lista[0][0];
                c = new Categoria(id, nombre);
            }
            return c;
        }

        public static List<Categoria> FindAll()
        {
            List<Categoria> l = new List<Categoria>();
            String comando = "select id_categoria, nombre from categoria";
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 id = (Int32)o[0];
                    String nombre = (String)o[1];
                    Categoria c = new Categoria(id, nombre);
                    l.Add(c);
                }
            }
            return l;
        }
        #endregion

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        #endregion

    }
}