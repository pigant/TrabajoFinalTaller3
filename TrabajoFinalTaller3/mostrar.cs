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
    public partial class MostrarForm : Form
    {
        public MostrarForm()
        {
            InitializeComponent();
        }

        private void MostrarForm_Load(object sender, EventArgs e)
        {
            List<Titulo> lista = TituloService.FindAll();
            lista.Reverse();
            lbxMostrar.DataSource = lista;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Titulo> lista = TituloService.FindLike(txtBuscar.Text);
            lista.Reverse();
            lbxMostrar.DataSource = lista;
        }

        private void lbxMostrar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Titulo t = (Titulo)lbxMostrar.SelectedItem;
            if (t != null)
            {
                DetallesForm d = new DetallesForm(t.IdTitulo);
                d.Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxMostrar_MouseDoubleClick(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Titulo t = (Titulo)lbxMostrar.SelectedItem;
            if (t != null)
            {
                EditarForm d = new EditarForm(t.IdTitulo);
                d.Show();
            }
        }
    }
}
