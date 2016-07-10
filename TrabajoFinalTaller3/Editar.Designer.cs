namespace TrabajoFinalTaller3
{
    partial class Editar
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
            this.grpDtos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.chkHeroes = new System.Windows.Forms.CheckBox();
            this.chkHorror = new System.Windows.Forms.CheckBox();
            this.chkRomantica = new System.Windows.Forms.CheckBox();
            this.chkMagia = new System.Windows.Forms.CheckBox();
            this.chkRobots = new System.Windows.Forms.CheckBox();
            this.chkDrama = new System.Windows.Forms.CheckBox();
            this.chkSciFi = new System.Windows.Forms.CheckBox();
            this.chkPelea = new System.Windows.Forms.CheckBox();
            this.chkAccion = new System.Windows.Forms.CheckBox();
            this.chkComedia = new System.Windows.Forms.CheckBox();
            this.cmbFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpDtos.SuspendLayout();
            this.grpCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDtos
            // 
            this.grpDtos.Controls.Add(this.btnCancelar);
            this.grpDtos.Controls.Add(this.btnOK);
            this.grpDtos.Controls.Add(this.grpCategorias);
            this.grpDtos.Controls.Add(this.cmbFecha);
            this.grpDtos.Controls.Add(this.cmbClase);
            this.grpDtos.Controls.Add(this.cmbTipo);
            this.grpDtos.Controls.Add(this.label1);
            this.grpDtos.Controls.Add(this.lblClase);
            this.grpDtos.Controls.Add(this.lblTipo);
            this.grpDtos.Controls.Add(this.lblFecha);
            this.grpDtos.Controls.Add(this.textBox1);
            this.grpDtos.Controls.Add(this.txtEvaluacion);
            this.grpDtos.Controls.Add(this.lblEvaluacion);
            this.grpDtos.Controls.Add(this.txtUbicacion);
            this.grpDtos.Controls.Add(this.lblComentario);
            this.grpDtos.Controls.Add(this.txtComentario);
            this.grpDtos.Controls.Add(this.lblUbicacion);
            this.grpDtos.Controls.Add(this.txtTitulo);
            this.grpDtos.Controls.Add(this.Titulo);
            this.grpDtos.Location = new System.Drawing.Point(12, 12);
            this.grpDtos.Name = "grpDtos";
            this.grpDtos.Size = new System.Drawing.Size(524, 390);
            this.grpDtos.TabIndex = 1;
            this.grpDtos.TabStop = false;
            this.grpDtos.Text = "Editar los datos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(404, 338);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "Cambiar";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // grpCategorias
            // 
            this.grpCategorias.Controls.Add(this.chkHeroes);
            this.grpCategorias.Controls.Add(this.chkHorror);
            this.grpCategorias.Controls.Add(this.chkRomantica);
            this.grpCategorias.Controls.Add(this.chkMagia);
            this.grpCategorias.Controls.Add(this.chkRobots);
            this.grpCategorias.Controls.Add(this.chkDrama);
            this.grpCategorias.Controls.Add(this.chkSciFi);
            this.grpCategorias.Controls.Add(this.chkPelea);
            this.grpCategorias.Controls.Add(this.chkAccion);
            this.grpCategorias.Controls.Add(this.chkComedia);
            this.grpCategorias.Location = new System.Drawing.Point(36, 229);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(215, 132);
            this.grpCategorias.TabIndex = 31;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Categorias";
            // 
            // chkHeroes
            // 
            this.chkHeroes.AutoSize = true;
            this.chkHeroes.Location = new System.Drawing.Point(115, 111);
            this.chkHeroes.Name = "chkHeroes";
            this.chkHeroes.Size = new System.Drawing.Size(60, 17);
            this.chkHeroes.TabIndex = 11;
            this.chkHeroes.Text = "Heroes";
            this.chkHeroes.UseVisualStyleBackColor = true;
            // 
            // chkHorror
            // 
            this.chkHorror.AutoSize = true;
            this.chkHorror.Location = new System.Drawing.Point(115, 88);
            this.chkHorror.Name = "chkHorror";
            this.chkHorror.Size = new System.Drawing.Size(55, 17);
            this.chkHorror.TabIndex = 10;
            this.chkHorror.Text = "Horror";
            this.chkHorror.UseVisualStyleBackColor = true;
            // 
            // chkRomantica
            // 
            this.chkRomantica.AutoSize = true;
            this.chkRomantica.Location = new System.Drawing.Point(115, 65);
            this.chkRomantica.Name = "chkRomantica";
            this.chkRomantica.Size = new System.Drawing.Size(77, 17);
            this.chkRomantica.TabIndex = 9;
            this.chkRomantica.Text = "Romantica";
            this.chkRomantica.UseVisualStyleBackColor = true;
            // 
            // chkMagia
            // 
            this.chkMagia.AutoSize = true;
            this.chkMagia.Location = new System.Drawing.Point(115, 42);
            this.chkMagia.Name = "chkMagia";
            this.chkMagia.Size = new System.Drawing.Size(55, 17);
            this.chkMagia.TabIndex = 7;
            this.chkMagia.Text = "Magia";
            this.chkMagia.UseVisualStyleBackColor = true;
            // 
            // chkRobots
            // 
            this.chkRobots.AutoSize = true;
            this.chkRobots.Location = new System.Drawing.Point(6, 111);
            this.chkRobots.Name = "chkRobots";
            this.chkRobots.Size = new System.Drawing.Size(60, 17);
            this.chkRobots.TabIndex = 6;
            this.chkRobots.Text = "Robots";
            this.chkRobots.UseVisualStyleBackColor = true;
            // 
            // chkDrama
            // 
            this.chkDrama.AutoSize = true;
            this.chkDrama.Location = new System.Drawing.Point(115, 19);
            this.chkDrama.Name = "chkDrama";
            this.chkDrama.Size = new System.Drawing.Size(57, 17);
            this.chkDrama.TabIndex = 5;
            this.chkDrama.Text = "Drama";
            this.chkDrama.UseVisualStyleBackColor = true;
            // 
            // chkSciFi
            // 
            this.chkSciFi.AutoSize = true;
            this.chkSciFi.Location = new System.Drawing.Point(6, 88);
            this.chkSciFi.Name = "chkSciFi";
            this.chkSciFi.Size = new System.Drawing.Size(52, 17);
            this.chkSciFi.TabIndex = 4;
            this.chkSciFi.Text = "Sci-Fi";
            this.chkSciFi.UseVisualStyleBackColor = true;
            // 
            // chkPelea
            // 
            this.chkPelea.AutoSize = true;
            this.chkPelea.Location = new System.Drawing.Point(6, 65);
            this.chkPelea.Name = "chkPelea";
            this.chkPelea.Size = new System.Drawing.Size(53, 17);
            this.chkPelea.TabIndex = 3;
            this.chkPelea.Text = "Pelea";
            this.chkPelea.UseVisualStyleBackColor = true;
            // 
            // chkAccion
            // 
            this.chkAccion.AutoSize = true;
            this.chkAccion.Location = new System.Drawing.Point(6, 42);
            this.chkAccion.Name = "chkAccion";
            this.chkAccion.Size = new System.Drawing.Size(59, 17);
            this.chkAccion.TabIndex = 2;
            this.chkAccion.Text = "Accion";
            this.chkAccion.UseVisualStyleBackColor = true;
            // 
            // chkComedia
            // 
            this.chkComedia.AutoSize = true;
            this.chkComedia.Location = new System.Drawing.Point(6, 19);
            this.chkComedia.Name = "chkComedia";
            this.chkComedia.Size = new System.Drawing.Size(67, 17);
            this.chkComedia.TabIndex = 1;
            this.chkComedia.Text = "Comedia";
            this.chkComedia.UseVisualStyleBackColor = true;
            // 
            // cmbFecha
            // 
            this.cmbFecha.Location = new System.Drawing.Point(279, 60);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(200, 20);
            this.cmbFecha.TabIndex = 30;
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(105, 142);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(123, 21);
            this.cmbClase.TabIndex = 29;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(105, 102);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(123, 21);
            this.cmbTipo.TabIndex = 29;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(38, 145);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 13);
            this.lblClase.TabIndex = 28;
            this.lblClase.Text = "Clase";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(39, 105);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 28;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(276, 44);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 13);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha Lanzamiento";
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Location = new System.Drawing.Point(347, 156);
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(131, 20);
            this.txtEvaluacion.TabIndex = 27;
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Location = new System.Drawing.Point(281, 159);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(60, 13);
            this.lblEvaluacion.TabIndex = 26;
            this.lblEvaluacion.Text = "Evaluacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(347, 116);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(131, 20);
            this.txtUbicacion.TabIndex = 25;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(281, 213);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 24;
            this.lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(284, 229);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(195, 75);
            this.txtComentario.TabIndex = 23;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(280, 119);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 22;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(42, 65);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(186, 20);
            this.txtTitulo.TabIndex = 21;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(39, 48);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 20;
            this.Titulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 27;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 416);
            this.Controls.Add(this.grpDtos);
            this.Name = "Editar";
            this.Text = "Editar";
            this.grpDtos.ResumeLayout(false);
            this.grpDtos.PerformLayout();
            this.grpCategorias.ResumeLayout(false);
            this.grpCategorias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDtos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.CheckBox chkHeroes;
        private System.Windows.Forms.CheckBox chkHorror;
        private System.Windows.Forms.CheckBox chkRomantica;
        private System.Windows.Forms.CheckBox chkMagia;
        private System.Windows.Forms.CheckBox chkRobots;
        private System.Windows.Forms.CheckBox chkDrama;
        private System.Windows.Forms.CheckBox chkSciFi;
        private System.Windows.Forms.CheckBox chkPelea;
        private System.Windows.Forms.CheckBox chkAccion;
        private System.Windows.Forms.CheckBox chkComedia;
        private System.Windows.Forms.DateTimePicker cmbFecha;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}