using Servicios.entidades;
using Servicios.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabajoFinalTaller3
{
    public partial class IngresarForm : Form
    {
        public IngresarForm()
        {
            InitializeComponent();
        }

        private void grpDtos_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngresarForm_Load(object sender, EventArgs e)
        {
            listaClases = ClaseService.FindAll();
            listaTipos = TipoService.FindAll();
            listaIdiomas = IdiomaService.FindAll();
            listaCategorias = CategoriaService.FindAll();
            //Relleno de componentes
            cmbTipo.DataSource = listaTipos;
            cmbClase.DataSource = listaClases;
            var audioLista = chkListAudio.Items;
            var subLista = chkListSubtitulos.Items;
            var cateLista = chkListCategorias.Items;
            listaIdiomas.ForEach((a) => audioLista.Add(a));
            listaIdiomas.ForEach((a) => subLista.Add(a));
            listaCategorias.ForEach((a) => cateLista.Add(a));
            txtTitulo.Select();
        }

        List<Clase> listaClases;
        List<Tipo> listaTipos;
        List<Idioma> listaIdiomas;
        List<Categoria> listaCategorias;

        private void btnOK_Click(object sender, EventArgs e)
        {
            //*******************
            //Atributos de Titulo
            //*******************
            String titulo = txtTitulo.Text;
            Tipo tipo = (Tipo)cmbTipo.SelectedItem;
            Clase clase = (Clase)cmbClase.SelectedItem;
            Int32 cantidad = -1;
            String cantidadTexto = txtCantidad.Text;
            DateTime fecha = cmbFecha.Value;
            String ubicacion = txtUbicacion.Text;
            Decimal evaluacion;
            String evaluacionTexto = txtEvaluacion.Text;
            String comentario = txtComentario.Text;
            //**************
            //Comprobaciones
            //**************
            //Comprobacion de titulo vacio
            if (titulo.Equals(""))
            {
                MessageBox.Show("Complete el campo titulo");
                txtTitulo.Select();
                return;
            }
            //Comprobacion de tipo vacio
            if(tipo == null)
            {
                MessageBox.Show("Seleccione un tipo");
                cmbTipo.Select();
                return;
            }
            //Comprobacion de clase vacio
            if(clase == null)
            {
                MessageBox.Show("Seleccione una clase");
                cmbClase.Select();
                return;
            }
            //Comprobacion de cantidad con formato de numero
            try
            {
                cantidad = Convert.ToInt32(cantidadTexto);
                if (cantidad < 1)
                    throw new FormatException();
            }
            catch (Exception)
            {
                MessageBox.Show("Cantidad debe ser entera positiva y no excesivamente grande");
                txtCantidad.Select();
                return;
            }
            //Comprobacion de evaluacion con formato de numero
            try
            {
                evaluacion = Convert.ToDecimal(evaluacionTexto);
                if (evaluacion < 1 && evaluacion > 5)
                    throw new FormatException();
            }
            catch (Exception)
            {
                MessageBox.Show("Evaluacion debe ser numerico de 1 a 5");
                txtEvaluacion.Select();
                return;
            }
            //******************************************************
            //Definicion del objeto y obtencion del id (dentro de t)
            //******************************************************
            Titulo t = new Titulo(titulo, clase.IdClase, tipo.IdTipo, fecha, comentario, evaluacion, ubicacion, cantidad);
            TituloService.create(t);
            //Relaciones muchos a muchos con titulo
            var categoriasSeleccionadas = chkListCategorias.CheckedItems.OfType<Categoria>().ToList<Categoria>();
            var subtitulosSeleccionados = chkListSubtitulos.CheckedItems.OfType<Idioma>().ToList<Idioma>();
            var audioSeleccionados = chkListAudio.CheckedItems.OfType<Idioma>().ToList<Idioma>();
            categoriasSeleccionadas.ForEach((a) => TituloService.CreateRelationCategoria(t.IdTitulo, a.IdCategoria));
            subtitulosSeleccionados.ForEach((a) => TituloService.CreateRelationSubtitulo(t.IdTitulo, a.IdIdioma));
            audioSeleccionados.ForEach((a) => TituloService.CreateRelationAudio(t.IdTitulo, a.IdIdioma));
            MessageBox.Show("Titulo ingresado");
            this.Close();
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int32 largo = txtTitulo.Text.Length;
        }
    }
}
