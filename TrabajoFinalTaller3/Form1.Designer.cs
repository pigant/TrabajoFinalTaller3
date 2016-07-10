namespace TrabajoFinalTaller3
{
    partial class Form1
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
            this.executeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeSQLToolStripMenuItem,
            this.verIdiomasToolStripMenuItem,
            this.verClasesToolStripMenuItem,
            this.verTiposToolStripMenuItem,
            this.verCategoríasToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // executeSQLToolStripMenuItem
            // 
            this.executeSQLToolStripMenuItem.Name = "executeSQLToolStripMenuItem";
            this.executeSQLToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.executeSQLToolStripMenuItem.Text = "Execute SQL";
            this.executeSQLToolStripMenuItem.Click += new System.EventHandler(this.ExecuteSql_Click);
            // 
            // verIdiomasToolStripMenuItem
            // 
            this.verIdiomasToolStripMenuItem.Name = "verIdiomasToolStripMenuItem";
            this.verIdiomasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verIdiomasToolStripMenuItem.Text = "Ver idiomas";
            this.verIdiomasToolStripMenuItem.Click += new System.EventHandler(this.verIdiomasToolStripMenuItem_Click);
            // 
            // verClasesToolStripMenuItem
            // 
            this.verClasesToolStripMenuItem.Name = "verClasesToolStripMenuItem";
            this.verClasesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verClasesToolStripMenuItem.Text = "Ver clases";
            this.verClasesToolStripMenuItem.Click += new System.EventHandler(this.verClasesToolStripMenuItem_Click);
            // 
            // verTiposToolStripMenuItem
            // 
            this.verTiposToolStripMenuItem.Name = "verTiposToolStripMenuItem";
            this.verTiposToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verTiposToolStripMenuItem.Text = "Ver tipos";
            this.verTiposToolStripMenuItem.Click += new System.EventHandler(this.verTiposToolStripMenuItem_Click);
            // 
            // verCategoríasToolStripMenuItem
            // 
            this.verCategoríasToolStripMenuItem.Name = "verCategoríasToolStripMenuItem";
            this.verCategoríasToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verCategoríasToolStripMenuItem.Text = "Ver categorías";
            this.verCategoríasToolStripMenuItem.Click += new System.EventHandler(this.verCategoríasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 336);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoríasToolStripMenuItem;
    }
}

