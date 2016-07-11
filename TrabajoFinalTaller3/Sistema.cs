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

namespace TrabajoFinalTaller3
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void ExecuteSql_Click(object sender, EventArgs e)
        {
            String url;
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            url = fd.FileName;
            DBService.ejecutarScript(url);
        }
        //private void categoriaEIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Mantenedor m = new Mantenedor();
        //    m.Show();
        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void categoriaEIdiomaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IngresarForm ingresar = new IngresarForm();
            ingresar.ShowDialog(this); 
        }
        private void listaDeTitulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar mostrar = new Mostrar();
            mostrar.ShowDialog(this); 
        }
        private void editarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.ShowDialog(this); 
        }
        private void eliminarTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog(this); 
        }
        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenedor mantenedor = new Mantenedor();
            mantenedor.ShowDialog(this); 
        }
    }
}
