﻿using Servicios.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.servicios
{
    public static class TipoService
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
        public static Tipo FindById(Int32 id)
        {
            Tipo c = null;
            String comando = String.Format("select nombre from tipo where id_tipo={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                String nombre = (String)lista[0][0];
                c = new Tipo(id, nombre);
            }
            return c;
        }
        public static List<Tipo> FindAll()
        {
            List<Tipo> l = new List<Tipo>();
            String comando = "select id_tipo, nombre from tipo";
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 id = (Int32)o[0];
                    String nombre = (String)o[1];
                    Tipo c = new Tipo(id, nombre);
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
