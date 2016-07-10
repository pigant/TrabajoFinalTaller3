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
    }
}
