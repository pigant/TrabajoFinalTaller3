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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var item = lbxMostrar.Items;
            List<Titulo> lista = TituloService.FindLike(txtBuscar.Text);
            item.Clear();
            lista.ForEach((a) => item.Add(a));
        }
        private void MostrarForm_Load(object sender, EventArgs e)
        {
            List<Titulo> lista = TituloService.FindAll();
            var item = lbxMostrar.Items;
            lista.ForEach((a) => item.Add(a));
        }
    }
}
