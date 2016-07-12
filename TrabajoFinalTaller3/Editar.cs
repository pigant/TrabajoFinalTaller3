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
    public partial class EditarForm : Form
    {

        private List<Clase> listaClases;
        private List<Tipo> listaTipos;
        private List<Idioma> listaIdiomas;
        private List<Categoria> listaCategorias;
        private List<Categoria> listaPreviaCategoriaSeleccionada;
        private List<Idioma> listaPreviaAudioSeleccionada;
        private List<Idioma> listaPreviaSubtituloSeleccionada;
        private Int32 id;

        public EditarForm(Int32 id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void EditarForm_Load(object sender, EventArgs e)
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
            //Seleccion de atributos correctos
            Titulo t = TituloService.FindById(id);
            txtTitulo.Text = t.NombreTitulo;
            txtUbicacion.Text = t.Ubicacion;
            txtComentario.Text = t.Comentarios;
            txtCantidad.Value = t.Cantidad;
            txtEvaluacion.Value = t.Evaluacion;
            cmbFecha.Value = t.FechaLanzamiento;
            for (int i = 0; i < listaTipos.Count; i++)
            {
                if (((Tipo)cmbTipo.Items[i]).IdTipo == t.IdTipo)
                {
                    cmbTipo.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < listaTipos.Count; i++)
            {
                if (((Clase)cmbClase.Items[i]).IdClase == t.IdClase)
                {
                    cmbClase.SelectedIndex = i;
                    break;
                }
            }
            //Relaciones
            listaPreviaCategoriaSeleccionada = CategoriaService.findByTituloId(t.IdTitulo);
            listaPreviaAudioSeleccionada = IdiomaService.FindAudioByTituloId(t.IdTitulo);
            listaPreviaSubtituloSeleccionada = IdiomaService.FindSubtituloByTituloId(t.IdTitulo);
            foreach (var cate in listaPreviaCategoriaSeleccionada)
            {
                Int32 n = chkListCategorias.FindStringExact(cate.Nombre);
                chkListCategorias.SetItemCheckState(n, CheckState.Checked);
            }
            foreach (var aud in listaPreviaAudioSeleccionada)
            {
                Int32 n = chkListAudio.FindStringExact(aud.Nombre);
                chkListAudio.SetItemCheckState(n, CheckState.Checked);
            }
            foreach (var sub in listaPreviaSubtituloSeleccionada)
            {
                Int32 n = chkListSubtitulos.FindStringExact(sub.Nombre);
                chkListSubtitulos.SetItemCheckState(n, CheckState.Checked);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
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
            Titulo t = new Titulo(id, titulo, clase.IdClase, tipo.IdTipo, fecha, comentario, evaluacion, ubicacion, cantidad);
            TituloService.Update(t);
            //Elimina antiguas relaciones
            TituloService.DeleteRelations(t.IdTitulo);
            //Relaciones muchos a muchos con titulo
            listaPreviaCategoriaSeleccionada = chkListCategorias.CheckedItems.OfType<Categoria>().ToList<Categoria>();
            listaPreviaSubtituloSeleccionada = chkListSubtitulos.CheckedItems.OfType<Idioma>().ToList<Idioma>();
            listaPreviaAudioSeleccionada = chkListAudio.CheckedItems.OfType<Idioma>().ToList<Idioma>();
            listaPreviaCategoriaSeleccionada.ForEach((a) => TituloService.CreateRelationCategoria(t.IdTitulo, a.IdCategoria));
            listaPreviaSubtituloSeleccionada.ForEach((a) => TituloService.CreateRelationSubtitulo(t.IdTitulo, a.IdIdioma));
            listaPreviaAudioSeleccionada.ForEach((a) => TituloService.CreateRelationAudio(t.IdTitulo, a.IdIdioma));
            MessageBox.Show("Titulo ingresado");
            this.Close();

        }
    }
}
