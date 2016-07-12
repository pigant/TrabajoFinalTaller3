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
        private Int32 idTitulo;
        private String nombreTitulo;
        private Int32 idClase;
        private Int32 idTipo;
        private DateTime fechaLanzamiento;
        private String comentarios;
        private Decimal evaluacion;
        private String ubicacion;
        private Int32 cantidad;
        #endregion

        /**********************************************************/
        /* Definicion de constructores */
        /**********************************************************/
        #region
        public Titulo()
        {

        }

        public Titulo(String titulo, Int32 idClase, Int32 idTipo, DateTime fechaLanzamiento, String comentarios, Decimal evaluacion, String ubicacion, Int32 cantidad)
        {
            NombreTitulo = titulo;
            IdClase = idClase;
            IdTipo = idTipo;
            FechaLanzamiento = fechaLanzamiento;
            Comentarios = comentarios;
            Evaluacion = evaluacion;
            Ubicacion = ubicacion;
            Cantidad = cantidad;
        }

        public Titulo(Int32 id, String titulo, Int32 idClase, Int32 idTipo, DateTime fechaLanzamiento, String comentarios, Decimal evaluacion, String ubicacion, Int32 cantidad)
        {
            IdTitulo = id;
            NombreTitulo = titulo;
            IdClase = idClase;
            IdTipo = idTipo;
            FechaLanzamiento = fechaLanzamiento;
            Comentarios = comentarios;
            Evaluacion = evaluacion;
            Ubicacion = ubicacion;
            Cantidad = cantidad;
        }

        #endregion

        /**********************************************************/
        /* Definicion de metodos */
        /**********************************************************/
        #region

        public override string ToString()
        {
            return nombreTitulo;
        }

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

        public Int32 IdClase
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

        public Int32 IdTipo
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
        public String FechaLanzamientoString
        {
            get
            {
                String fecha = "" + fechaLanzamiento.Year + '/' + fechaLanzamiento.Month + '/' + fechaLanzamiento.Day;
                return fecha;
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

        public Decimal Evaluacion
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

        public Int32 IdTitulo
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

        public Int32 Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
        #endregion

    }
}
