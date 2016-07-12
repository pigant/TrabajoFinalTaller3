using Servicios.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.servicios
{
    public static class TituloService
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

        public static Titulo FindById(Int32 id)
        {
            Titulo c = null;
            String comando = String.Format("select titulo, id_clase, id_tipo, fecha, comentario, evaluacion, ubicacion, cantidad from titulo where id_titulo={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                Object[] o = lista[0];
                String nombre = (String) o[0];
                Int32 idClase = (Int32) o[1];
                Int32 idTipo = (Int32) o[2];
                String fechaLanzamiento = ((DateTime) o[3]).ToString();
                String comentarios = (String) o[4];
                Decimal evaluacion = Convert.ToDecimal(o[5]);
                String ubicacion = (String) o[6];
                Int32 cantidad = (Int32) o[7];
                c = new Titulo(
                        id, nombre, idClase, idTipo,
                        fechaLanzamiento, comentarios,
                        evaluacion, ubicacion, cantidad);
            }
            return c;
        }

        public static List<Titulo> FindAll()
        {
            List<Titulo> l = new List<Titulo>();
            String comando = "select id_titulo, titulo, id_clase, id_tipo, fecha, comentario, evaluacion, ubicacion, cantidad from titulo";
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 id = (Int32)o[0];
                    String nombre = (String)o[1];
                    Int32 idClase = (Int32)o[2];
                    Int32 idTipo = (Int32)o[3];
                    String fechaLanzamiento = ((DateTime)o[4]).ToString();
                    String comentarios = (String)o[5];
                    Decimal evaluacion = Convert.ToDecimal(o[6]);
                    String ubicacion = (String)o[7];
                    Int32 cantidad = (Int32)o[8];
                    Titulo t = new Titulo(
                            id, nombre, idClase, idTipo,
                            fechaLanzamiento, comentarios,
                            evaluacion, ubicacion, cantidad);
                    l.Add(t);
                }
            }
            return l;
        }

        public static List<Titulo> FindLike(String text)
        {
            List<Titulo> l = new List<Titulo>();
            String comando = String.Format("select id_titulo, titulo, id_clase, id_tipo, fecha, comentario, evaluacion, ubicacion, cantidad from titulo where lower(titulo) like lower('%{0}%')", text);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    Int32 idTitulo = (Int32)o[0];
                    String nombre = (String)o[1];
                    Int32 idClase = (Int32)o[2];
                    Int32 idTipo = (Int32)o[3];
                    String fechaLanzamiento = ((DateTime)o[4]).ToString();
                    String comentarios = (String)o[5];
                    Decimal evaluacion = Convert.ToDecimal(o[6]);
                    String ubicacion = (String)o[7];
                    Int32 cantidad = (Int32)o[8];
                    Titulo t = new Titulo(
                            idTitulo, nombre, idClase, idTipo,
                            fechaLanzamiento, comentarios,
                            evaluacion, ubicacion, cantidad);
                    l.Add(t);
                }
            }
            return l;
        }

        public static void create(Titulo titulo)
        {
            String consulta = String.Format(
                "insert into titulo (titulo, fecha, comentario, evaluacion, ubicacion, cantidad, id_tipo, id_clase) "
                + "values ('{0}','{1}','{2}',{3},'{4}',{5},{6},{7})", 
                titulo.NombreTitulo, titulo.FechaLanzamiento, titulo.Comentarios, 
                titulo.Evaluacion.ToString().Replace(',', '.'),
                titulo.Ubicacion, titulo.Cantidad, titulo.IdTipo, titulo.IdClase);
            ConexionDB db = new ConexionDB();
            Int32 id = db.OperacionesNonQueryReturnId(consulta);
            titulo.IdTitulo = id;
        }
        
        public static void delete(Int32 id)
        {
            String consulta;
            ConexionDB db = new ConexionDB();
            consulta = String.Format("delete from titulo_idioma_aud where id_titulo={0}", id);
            db.OperacionesNonQuery(consulta);
            consulta = String.Format("delete from titulo_idioma_sub where id_titulo={0}", id);
            db.OperacionesNonQuery(consulta);
            consulta = String.Format("delete from titulo_categoria where id_titulo={0}", id);
            db.OperacionesNonQuery(consulta);
            consulta = String.Format("delete from titulo where id_titulo={0}", id);
            db.OperacionesNonQuery(consulta);
        }
        
        public static void update(Titulo titulo)
        {
            String consulta = String.Format(
                "update titulo set titulo='{1}',fecha='{2}',comentario='{3}, "
                +"evaluacion={4},ubicacion='{5}',cantidad={6},id_tipo={7},"
                +"id_clase={8} where id_tipo={0}", 
                titulo.IdTitulo, titulo.NombreTitulo, titulo.FechaLanzamiento, titulo.Comentarios, 
                titulo.Evaluacion, titulo.Ubicacion, titulo.Cantidad, titulo.IdTipo, titulo.IdClase);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }

        public static void CreateRelationAudio(Int32 idTitulo, Int32 idIdioma)
        {
            String consulta = String.Format("insert into titulo_idioma_aud (id_titulo, id_idioma) values ({0}, {1})", idTitulo, idIdioma);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }

        public static void CreateRelationSubtitulo(Int32 idTitulo, Int32 idIdioma)
        {
            String consulta = String.Format("insert into titulo_idioma_sub (id_titulo, id_idioma) values ({0}, {1})", idTitulo, idIdioma);
            ConexionDB db = new ConexionDB();
            db.OperacionesNonQuery(consulta);
        }

        public static void CreateRelationCategoria(Int32 idTitulo, Int32 idCategoria)
        {
            String consulta = String.Format("insert into titulo_categoria (id_titulo, id_categoria) values ({0}, {1})", idTitulo, idCategoria);
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
