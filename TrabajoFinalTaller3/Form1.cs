using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.servicios;
using Servicios.entidades;

namespace TrabajoFinalTaller3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExecuteSql_Click(object sender, EventArgs e)
        {
            String url;
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            url = fd.FileName;
            DBService.ejecutarScript(url);
        }

        private void verIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Idioma> idomas = IdiomaService.FindAll();
        }

        private void verClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Clase> clases = ClaseService.FindAll();
        }

        private void verTiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Tipo> tipos = TipoService.FindAll();
        }

        private void verCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Categoria> categorias = CategoriaService.FindAll();
        }
    }
}
