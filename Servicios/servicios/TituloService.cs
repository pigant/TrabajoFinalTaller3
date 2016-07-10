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
            String comando = String.Format("select nombre, id_clase, id_tipo, fecha_nacimiento, comentarios, evaluacion, ubicacion, cantidad from titulo where id_titulo={0}", id);
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                String nombre = (String)lista[0][0];
                Int32 idClase = (Int32)lista[0][1];
                Int32 idTipo = (Int32)lista[0][2];
                DateTime fechaLanzamiento = (DateTime)lista[0][3];
                String comentarios = (String)lista[0][4];
                Int32 evaluacion = (Int32)lista[0][5];
                String ubicacion = (String)lista[0][6];
                Int32 cantidad = (Int32)lista[0][7];
                c = new Titulo(
                        id, nombre, idClase, idTipo,
                        fechaLanzamiento, comentarios,
                        evaluacion, ubicacion, cantidad);
            }
            return c;
        }

        public static List<Titulo> FindAll(Int32 id)
        {
            List<Titulo> l = new List<Titulo>();
            String comando = "select nombre, id_clase, id_tipo, fecha_nacimiento, comentarios, evaluacion, ubicacion, cantidad from titulo";
            ConexionDB db = new ConexionDB();
            List<Object[]> lista = db.ObtenerLista(comando);
            if (lista.Count > 0)
            {
                foreach (Object[] o in lista)
                {
                    String nombre = (String)o[1];
                    Int32 idClase = (Int32)o[2];
                    Int32 idTipo = (Int32)o[3];
                    DateTime fechaLanzamiento = (DateTime)o[4];
                    String comentarios = (String)o[5];
                    Int32 evaluacion = (Int32)o[6];
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

        #endregion

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        #endregion

    }
}
