using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.entidades
{
    public class Titulo
    {

        /**********************************************************/
        /* Definicion de parametros de clase */
        /**********************************************************/
        #region
        private int idTitulo;
        private String nombreTitulo;
        private int idClase;
        private int idTipo;
        private DateTime fechaLanzamiento;
        private String comentarios;
        private int evaluacion;
        private String ubicacion;
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region
        public Titulo()
        {

        }

        public Titulo(String titulo, int idClase, int idTipo, DateTime fechaLanzamiento, String comentarios, int evaluacion, String ubicacion)
        {
            NombreTitulo = titulo;
            IdClase = idClase;
            IdTipo = idTipo;
            FechaLanzamiento = fechaLanzamiento;
            Comentarios = comentarios;
            Evaluacion = evaluacion;
            Ubicacion = ubicacion;
        }

        public Titulo(Int32 id, String titulo, int idClase, int idTipo, DateTime fechaLanzamiento, String comentarios, int evaluacion, String ubicacion)
        {
            IdTitulo = idTitulo;
            NombreTitulo = titulo;
            IdClase = idClase;
            IdTipo = idTipo;
            FechaLanzamiento = fechaLanzamiento;
            Comentarios = comentarios;
            Evaluacion = evaluacion;
            Ubicacion = ubicacion;
        }

        #endregion

        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/
        #region
        #endregion

        /**********************************************************/
        /* Definicion de Propiedades */
        /**********************************************************/
        #region
        public string NombreTitulo
        {
            get
            {
                return nombreTitulo;
            }

            set
            {
                nombreTitulo = value;
            }
        }

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

        public DateTime FechaLanzamiento
        {
            get
            {
                return fechaLanzamiento;
            }

            set
            {
                fechaLanzamiento = value;
            }
        }

        public string Comentarios
        {
            get
            {
                return comentarios;
            }

            set
            {
                comentarios = value;
            }
        }

        public int Evaluacion
        {
            get
            {
                return evaluacion;
            }

            set
            {
                evaluacion = value;
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }

            set
            {
                ubicacion = value;
            }
        }

        public int IdTitulo
        {
            get
            {
                return idTitulo;
            }

            set
            {
                idTitulo = value;
            }
        }
        #endregion        

    }
}
