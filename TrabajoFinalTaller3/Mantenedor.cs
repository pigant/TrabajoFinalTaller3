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
    public partial class Mantenedor : Form
    {
        public Mantenedor()
        {
            InitializeComponent();
        }

        private void Idioma_btn_Click(object sender, EventArgs e)
        {
            Idioma i = new Idioma(Idioma_txt.Text);
            IdiomaService.create(i);
        }

        private void Categoria_btn_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria(Categoria_txt.Text);
            CategoriaService.create(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
