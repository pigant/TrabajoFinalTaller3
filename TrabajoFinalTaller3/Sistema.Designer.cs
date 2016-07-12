namespace TrabajoFinalTaller3
{
    partial class Sistema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaEIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTitulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTitulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.developerToolStripMenuItem,
            this.verTitulosToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.mantenedorDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(776, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.fileToolStripMenuItem.Text = "Sistema";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaEIdiomaToolStripMenuItem,
            this.executeSQLToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.developerToolStripMenuItem.Text = "Ingresar";
            // 
            // categoriaEIdiomaToolStripMenuItem
            // 
            this.categoriaEIdiomaToolStripMenuItem.Name = "categoriaEIdiomaToolStripMenuItem";
            this.categoriaEIdiomaToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.categoriaEIdiomaToolStripMenuItem.Text = "Ingresar Titulo";
            this.categoriaEIdiomaToolStripMenuItem.Click += new System.EventHandler(this.categoriaEIdiomaToolStripMenuItem_Click_1);
            // 
            // executeSQLToolStripMenuItem
            // 
            this.executeSQLToolStripMenuItem.Name = "executeSQLToolStripMenuItem";
            this.executeSQLToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.executeSQLToolStripMenuItem.Text = "Execute SQL";
            this.executeSQLToolStripMenuItem.Click += new System.EventHandler(this.ExecuteSql_Click);
            // 
            // verTitulosToolStripMenuItem
            // 
            this.verTitulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeTitulosToolStripMenuItem});
            this.verTitulosToolStripMenuItem.Name = "verTitulosToolStripMenuItem";
            this.verTitulosToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.verTitulosToolStripMenuItem.Text = "Ver Titulos";
            // 
            // listaDeTitulosToolStripMenuItem
            // 
            this.listaDeTitulosToolStripMenuItem.Name = "listaDeTitulosToolStripMenuItem";
            this.listaDeTitulosToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.listaDeTitulosToolStripMenuItem.Text = "Lista de Titulos";
            this.listaDeTitulosToolStripMenuItem.Click += new System.EventHandler(this.listaDeTitulosToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarTituloToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarTituloToolStripMenuItem
            // 
            this.eliminarTituloToolStripMenuItem.Name = "eliminarTituloToolStripMenuItem";
            this.eliminarTituloToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.eliminarTituloToolStripMenuItem.Text = "Eliminar Titulo";
            this.eliminarTituloToolStripMenuItem.Click += new System.EventHandler(this.eliminarTituloToolStripMenuItem_Click);
            // 
            // mantenedorDelSistemaToolStripMenuItem
            // 
            this.mantenedorDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem});
            this.mantenedorDelSistemaToolStripMenuItem.Name = "mantenedorDelSistemaToolStripMenuItem";
            this.mantenedorDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.mantenedorDelSistemaToolStripMenuItem.Text = "Mantenedor del Sistema";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria o Idioma";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TrabajoFinalTaller3.Properties.Resources.Biblioteca_Videoteca;
            this.pictureBox1.Image = global::TrabajoFinalTaller3.Properties.Resources.Biblioteca_Videoteca;
            this.pictureBox1.InitialImage = global::TrabajoFinalTaller3.Properties.Resources.Biblioteca_Videoteca;
            this.pictureBox1.Location = new System.Drawing.Point(15, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 471);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 498);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 536);
            this.MinimumSize = new System.Drawing.Size(794, 536);
            this.Name = "Sistema";
            this.Text = "Sistema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTitulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorDelSistemaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem categoriaEIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTitulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
    }
}

