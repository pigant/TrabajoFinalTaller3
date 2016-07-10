using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.entidades
{

    public class Clase
    {
        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        private int idClase;
        private String nombre;
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region

        public Clase()
        {
        }

        public Clase(String nombre)
        {
            Nombre = nombre;
        }

        public Clase(int idClase, String nombre)
        {
            IdClase = idClase;
            Nombre = nombre;
        }
        #endregion
        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        public int IdClase
        {
            get
            {
                return idClase;
            }

            set
            {
                idClase = value;
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
