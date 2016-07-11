using Servicios.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.servicios
{
    public static class IdiomaService
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
        public static Idioma FindById(Int32 id)
        {
            Idioma c = null;
            String comando = String.Format("select nombre from idioma where id_idioma={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                String nombre = (String)lista[0][0];
                c = new Idioma(id, nombre);
            }
            return c;
        }
        public static List<Idioma> FindAll()
        {
            List<Idioma> l = new List<Idioma>();
            String comando = "select id_idioma, nombre from idioma";
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 id = (Int32)o[0];
                    String nombre = (String)o[1];
                    Idioma c = new Idioma(id, nombre);
                    l.Add(c);
                }
            }
            return l;
        }

        public static void create(Idioma idioma)
        {
            String consulta = String.Format("insert into idioma (nombre) values ('{0}')", idioma.Nombre);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }
        
        public static void delete(Int32 id)
        {
            String consulta = String.Format("delete from idioma where id_idioma={0}", id);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }
        
        public static void update(Idioma idioma)
        {
            String consulta = String.Format("update idioma set nombre='{1}' where id_idioma={0}", idioma.IdIdioma, idioma.Nombre);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }

        #endregion

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        #endregion

    }
}
