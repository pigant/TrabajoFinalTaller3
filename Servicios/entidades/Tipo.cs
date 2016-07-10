using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.entidades
{

    public class Tipo
    {
        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        private int idTipo;
        private String nombre;
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region

        public Tipo()
        {
        }

        public Tipo(String nombre)
        {
            Nombre = nombre;
        }

        public Tipo(int idTipo, String nombre)
        {
            IdTipo = idTipo;
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
        public int IdTipo
        {
            get
            {
                return idTipo;
            }

            set
            {
                idTipo = value;
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
