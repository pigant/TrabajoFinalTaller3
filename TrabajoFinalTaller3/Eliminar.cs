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
            Titulo t = (Titulo)lbxMostrar.SelectedItem;
            DialogResult dialogResult = MessageBox.Show("Confirma desea eliminar? \n Esta accion no tiene vuelta atras", "Confirmar", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
                {
                    TituloService.Delete(t.IdTitulo);
                }
            else if (dialogResult == DialogResult.No)
                {
                    //cancel;
                }
            List<Titulo> lista = TituloService.FindLike(txtBuscar.Text);
            lbxMostrar.DataSource = lista;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Titulo> lista = TituloService.FindLike(txtBuscar.Text);
            lbxMostrar.DataSource = lista;
        }
        private void MostrarForm_Load(object sender, EventArgs e)
        {
            List<Titulo> lista = TituloService.FindAll();
            var item = lbxMostrar.Items;
            lista.ForEach((a) => item.Add(a));
        }
    }
}
