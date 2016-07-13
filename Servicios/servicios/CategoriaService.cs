using Servicios.entidades;
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

        public static List<Categoria> findByTituloId(Int32 id)
        {
            List<Categoria> l = new List<Categoria>();
            String comando = String.Format("select categoria.id_categoria, categoria.nombre from categoria join titulo_categoria on categoria.id_categoria=titulo_categoria.id_categoria where titulo_categoria.id_titulo={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 idCategoria = (Int32)o[0];
                    String nombre = (String)o[1];
                    Categoria c = new Categoria(idCategoria, nombre);
                    l.Add(c);
                }
            }
            return l;
        }


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

        public static void Create(Categoria categoria)
        {
            String consulta = String.Format("insert into categoria (nombre) values ('{0}')", categoria.Nombre);
            ConexionDB db = new ConexionDB();
            categoria.IdCategoria = db.OperacionesNonQueryReturnId(consulta);
        }
        
        public static void Delete(Int32 id)
        {
            String consulta = String.Format("delete from categoria where id_categoria={0}", id);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }
        
        public static void Update(Categoria categoria)
        {
            String consulta = String.Format("update categoria set nombre='{1}' where id_categoria={0}", categoria.IdCategoria, categoria.Nombre);
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
