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
            var item = lbxMostrar.Items;
            lista.ForEach((a) => item.Add(a));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var item = lbxMostrar.Items;
            List<Titulo> lista = TituloService.FindLike(txtBuscar.Text);
            item.Clear();
            lista.ForEach((a) => item.Add(a));
        }

        private void lbxMostrar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Titulo t = (Titulo)lbxMostrar.SelectedItem;
            DetallesForm d = new DetallesForm(t.IdTitulo);
            d.Show();
        }
    }
}
