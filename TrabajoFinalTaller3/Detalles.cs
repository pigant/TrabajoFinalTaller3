using Servicios.servicios;
using Servicios.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace TrabajoFinalTaller3
{
    public partial class DetallesForm : Form
    {

        private Int32 id;

        public DetallesForm(Int32 id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetallesForm_Load(object sender, EventArgs e)
        {
            Titulo t = TituloService.FindById(id);
            txtTitulo.Text = t.NombreTitulo;
            cmbTipo.Items.Add(TipoService.FindById(t.IdTipo));
            cmbTipo.SelectedIndex = 0;
            cmbClase.Items.Add(ClaseService.FindById(t.IdClase));
            cmbClase.SelectedIndex = 0;
            txtCantidad.Text = t.Cantidad.ToString();
            txtComentario.Text = t.Comentarios;
            txtUbicacion.Text = t.Ubicacion;
            txtEvaluacion.Text = t.Evaluacion.ToString();
            txtFecha.Text = t.FechaLanzamientoString;
            listCategorias.DataSource = CategoriaService.findByTituloId(id);
            listAudio.DataSource = IdiomaService.FindAudioByTituloId(id);
            listSubtitulos.DataSource = IdiomaService.FindSubtituloByTituloId(id);

        }
    }
}
