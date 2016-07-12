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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Object o = null;

            switch (cmbItem.SelectedIndex)
            {
                case 0:
                    Idioma i = new Idioma(txtNombre.Text);
                    IdiomaService.Create(i);
                    o = i;
                    break;
                case 1:
                    Categoria c = new Categoria(txtNombre.Text);
                    CategoriaService.Create(c);
                    o = c;
                    break;
                case 2:
                    Tipo t = new Tipo(txtNombre.Text);
                    TipoService.Create(t);
                    o = t;
                    break;
                case 3:
                    Clase cl = new Clase(txtNombre.Text);
                    ClaseService.Create(cl);
                    o = cl;
                    break;
            }
            chklistMostrar.Items.Add(o);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = chklistMostrar.Items;
            switch (cmbItem.SelectedIndex)
            {
                case 0:
                    items.Clear();
                    IdiomaService.FindAll().ForEach((a) => items.Add(a));
                    break;
                case 1:
                    items.Clear();
                    CategoriaService.FindAll().ForEach((a) => items.Add(a));
                    break;
                case 2:
                    items.Clear();
                    TipoService.FindAll().ForEach((a) => items.Add(a));
                    break;
                case 3:
                    items.Clear();
                    ClaseService.FindAll().ForEach((a) => items.Add(a));
                    break;
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            var selected = chklistMostrar.SelectedItem;
            switch (cmbItem.SelectedIndex)
            {
                case 0:
                    Idioma i = (Idioma)selected;
                    i.Nombre = txtNombre.Text;
                    IdiomaService.Update(i);
                    break;
                case 1:
                    Categoria c = (Categoria)selected;
                    c.Nombre = txtNombre.Text;
                    CategoriaService.Update(c);
                    break;
                case 2:
                    Tipo t = (Tipo)selected;
                    t.Nombre = txtNombre.Text;
                    TipoService.Update(t);
                    break;
                case 3:
                    Clase cl = (Clase)selected;
                    cl.Nombre = txtNombre.Text;
                    ClaseService.Update(cl);
                    break;
            }
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var selected = chklistMostrar.CheckedItems;
            switch (cmbItem.SelectedIndex)
            {
                case 0:
                    var lista0 = selected.OfType<Idioma>().ToList<Idioma>();
                    lista0.ForEach((a) => IdiomaService.Delete(a.IdIdioma));
                    break;
                case 1:
                    var lista1 = selected.OfType<Categoria>().ToList<Categoria>();
                    lista1.ForEach((a) => CategoriaService.Delete(a.IdCategoria));
                    break;
                case 2:
                    var lista2 = selected.OfType<Tipo>().ToList<Tipo>();
                    lista2.ForEach((a) => TipoService.Delete(a.IdTipo));
                    break;
                case 3:
                    var lista3 = selected.OfType<Clase>().ToList<Clase>();
                    lista3.ForEach((a) => ClaseService.Delete(a.IdClase));
                    break;
            }
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void Mantenedor_Load(object sender, EventArgs e)
        {
            cmbItem.SelectedIndex = 0;
        }

        private void chklistMostrar_Click(object sender, EventArgs e)
        {
            var a = chklistMostrar.SelectedItem;
            if (a != null)
            {
                txtNombre.Text = a.ToString();
            }
        }
    }
}
