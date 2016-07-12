using Servicios.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.entidades
{

    public class Categoria
    {
        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        private int idCategoria;
        private String nombre;
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region

        public Categoria()
        {
        }

        public Categoria(String nombre)
        {
            Nombre = nombre;
        }

        public Categoria(int idCategoria, String nombre)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
        }

        #endregion
        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/
        #region

        public override string ToString()
        {
            return nombre;
        }

        #endregion

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
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
