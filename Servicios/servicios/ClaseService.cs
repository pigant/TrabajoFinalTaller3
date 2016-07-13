using Servicios.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.servicios
{
    public static class ClaseService
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
        public static Clase FindById(Int32 id)
        {
            Clase c = null;
            String comando = String.Format("select nombre from clase where id_clase={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                String nombre = (String)lista[0][0];
                c = new Clase(id, nombre);
            }
            return c;
        }
        public static List<Clase> FindAll()
        {
            List<Clase> l = new List<Clase>();
            String comando = "select id_clase, nombre from clase";
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 id = (Int32)o[0];
                    String nombre = (String)o[1];
                    Clase c = new Clase(id, nombre);
                    l.Add(c);
                }
            }
            return l;
        }

        public static void Create(Clase clase)
        {
            String consulta = String.Format("insert into clase (nombre) values ('{0}')", clase.Nombre);
            ConexionDB db = new ConexionDB();
            clase.IdClase = db.OperacionesNonQueryReturnId(consulta);
        }
        
        public static void Delete(Int32 id)
        {
            String consulta = String.Format("delete from clase where id_clase={0}", id);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }
        
        public static void Update(Clase clase)
        {
            String consulta = String.Format("update clase set nombre='{1}' where id_clase={0}", clase.IdClase, clase.Nombre);
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
