using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.entidades
{

    public class Idioma
    {
        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        private int idIdioma;
        private String nombre;
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region

        public Idioma()
        {
        }

        public Idioma(String nombre)
        {
            Nombre = nombre;
        }

        public Idioma(int idIdioma, String nombre)
        {
            IdIdioma = idIdioma;
            Nombre = nombre;
        }
        #endregion
        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/

        public override string ToString()
        {
            return nombre;
        }

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        public int IdIdioma
        {
            get
            {
                return idIdioma;
            }

            set
            {
                idIdioma = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        #endregion
    }
}
