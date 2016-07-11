namespace TrabajoFinalTaller3
{
    partial class Mantenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddIdioma = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCategorias = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkListAudio = new System.Windows.Forms.CheckedListBox();
            this.chkListCategorias = new System.Windows.Forms.CheckedListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAddIdioma);
            this.groupBox1.Controls.Add(this.chkListAudio);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idiomas";
            // 
            // btnAddIdioma
            // 
            this.btnAddIdioma.Location = new System.Drawing.Point(195, 32);
            this.btnAddIdioma.Name = "btnAddIdioma";
            this.btnAddIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnAddIdioma.TabIndex = 1;
            this.btnAddIdioma.Text = "Agregar";
            this.btnAddIdioma.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.chkListCategorias);
            this.groupBox2.Controls.Add(this.btnAddCategorias);
            this.groupBox2.Location = new System.Drawing.Point(301, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // btnAddCategorias
            // 
            this.btnAddCategorias.Location = new System.Drawing.Point(188, 32);
            this.btnAddCategorias.Name = "btnAddCategorias";
            this.btnAddCategorias.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategorias.TabIndex = 1;
            this.btnAddCategorias.Text = "Agregar";
            this.btnAddCategorias.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkListAudio
            // 
            this.chkListAudio.FormattingEnabled = true;
            this.chkListAudio.Location = new System.Drawing.Point(33, 32);
            this.chkListAudio.Name = "chkListAudio";
            this.chkListAudio.Size = new System.Drawing.Size(138, 109);
            this.chkListAudio.TabIndex = 3;
            // 
            // chkListCategorias
            // 
            this.chkListCategorias.FormattingEnabled = true;
            this.chkListCategorias.Location = new System.Drawing.Point(23, 32);
            this.chkListCategorias.Name = "chkListCategorias";
            this.chkListCategorias.Size = new System.Drawing.Size(143, 109);
            this.chkListCategorias.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 82);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 116);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Mantenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mantenedor";
            this.Text = "Mantenedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddIdioma;
        private System.Windows.Forms.Button btnAddCategorias;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckedListBox chkListAudio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox chkListCategorias;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}