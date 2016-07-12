namespace TrabajoFinalTaller3
{
    partial class EditarForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpDtos = new System.Windows.Forms.GroupBox();
            this.txtEvaluacion = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.chkListSubtitulos = new System.Windows.Forms.CheckedListBox();
            this.chkListAudio = new System.Windows.Forms.CheckedListBox();
            this.chkListCategorias = new System.Windows.Forms.CheckedListBox();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpDtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvaluacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::TrabajoFinalTaller3.Properties.Resources.banner;
            this.pictureBox2.ImageLocation = "center";
            this.pictureBox2.InitialImage = global::TrabajoFinalTaller3.Properties.Resources.banner;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 116);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // grpDtos
            // 
            this.grpDtos.Controls.Add(this.txtEvaluacion);
            this.grpDtos.Controls.Add(this.txtCantidad);
            this.grpDtos.Controls.Add(this.chkListSubtitulos);
            this.grpDtos.Controls.Add(this.chkListAudio);
            this.grpDtos.Controls.Add(this.chkListCategorias);
            this.grpDtos.Controls.Add(this.cmbClase);
            this.grpDtos.Controls.Add(this.cmbTipo);
            this.grpDtos.Controls.Add(this.label1);
            this.grpDtos.Controls.Add(this.lblClase);
            this.grpDtos.Controls.Add(this.lblTipo);
            this.grpDtos.Controls.Add(this.lblEvaluacion);
            this.grpDtos.Controls.Add(this.txtUbicacion);
            this.grpDtos.Controls.Add(this.lblUbicacion);
            this.grpDtos.Controls.Add(this.btnCancelar);
            this.grpDtos.Controls.Add(this.btnOK);
            this.grpDtos.Controls.Add(this.label3);
            this.grpDtos.Controls.Add(this.cmbFecha);
            this.grpDtos.Controls.Add(this.label2);
            this.grpDtos.Controls.Add(this.lblFecha);
            this.grpDtos.Controls.Add(this.lblCategorias);
            this.grpDtos.Controls.Add(this.lblComentario);
            this.grpDtos.Controls.Add(this.txtComentario);
            this.grpDtos.Controls.Add(this.txtTitulo);
            this.grpDtos.Controls.Add(this.Titulo);
            this.grpDtos.Location = new System.Drawing.Point(25, 128);
            this.grpDtos.Name = "grpDtos";
            this.grpDtos.Size = new System.Drawing.Size(524, 390);
            this.grpDtos.TabIndex = 44;
            this.grpDtos.TabStop = false;
            this.grpDtos.Text = "Ingrese los datos";
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.DecimalPlaces = 1;
            this.txtEvaluacion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtEvaluacion.Location = new System.Drawing.Point(372, 161);
            this.txtEvaluacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEvaluacion.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtEvaluacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(132, 20);
            this.txtEvaluacion.TabIndex = 6;
            this.txtEvaluacion.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtCantidad
            // 
            this.txtCantidad.ForeColor = System.Drawing.Color.SlateGray;
            this.txtCantidad.Location = new System.Drawing.Point(88, 158);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkListSubtitulos
            // 
            this.chkListSubtitulos.FormattingEnabled = true;
            this.chkListSubtitulos.Location = new System.Drawing.Point(361, 266);
            this.chkListSubtitulos.Name = "chkListSubtitulos";
            this.chkListSubtitulos.Size = new System.Drawing.Size(143, 64);
            this.chkListSubtitulos.TabIndex = 10;
            // 
            // chkListAudio
            // 
            this.chkListAudio.FormattingEnabled = true;
            this.chkListAudio.Location = new System.Drawing.Point(194, 266);
            this.chkListAudio.Name = "chkListAudio";
            this.chkListAudio.Size = new System.Drawing.Size(138, 64);
            this.chkListAudio.TabIndex = 9;
            // 
            // chkListCategorias
            // 
            this.chkListCategorias.FormattingEnabled = true;
            this.chkListCategorias.Location = new System.Drawing.Point(25, 266);
            this.chkListCategorias.Name = "chkListCategorias";
            this.chkListCategorias.Size = new System.Drawing.Size(137, 64);
            this.chkListCategorias.TabIndex = 8;
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(88, 119);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(123, 21);
            this.cmbClase.TabIndex = 3;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(88, 78);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(123, 21);
            this.cmbTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cantidad";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(21, 122);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 13);
            this.lblClase.TabIndex = 39;
            this.lblClase.Text = "Clase";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(22, 86);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 40;
            this.lblTipo.Text = "Tipo";
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Location = new System.Drawing.Point(306, 162);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(60, 13);
            this.lblEvaluacion.TabIndex = 35;
            this.lblEvaluacion.Text = "Evaluacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(373, 119);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(131, 20);
            this.txtUbicacion.TabIndex = 4;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(306, 122);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 33;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(304, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(412, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Actualizar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Subtitulos";
            // 
            // cmbFecha
            // 
            this.cmbFecha.Location = new System.Drawing.Point(304, 84);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(200, 20);
            this.cmbFecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Audio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(301, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 13);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha Lanzamiento";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(22, 249);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(57, 13);
            this.lblCategorias.TabIndex = 24;
            this.lblCategorias.Text = "Categorias";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(21, 184);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 24;
            this.lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(24, 200);
            this.txtComentario.MaxLength = 255;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(480, 47);
            this.txtComentario.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(25, 41);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(479, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(22, 24);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 20;
            this.Titulo.Text = "Titulo";
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 534);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpDtos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 561);
            this.MinimumSize = new System.Drawing.Size(597, 561);
            this.Name = "EditarForm";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.EditarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpDtos.ResumeLayout(false);
            this.grpDtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvaluacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpDtos;
        private System.Windows.Forms.NumericUpDown txtEvaluacion;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.CheckedListBox chkListSubtitulos;
        private System.Windows.Forms.CheckedListBox chkListAudio;
        private System.Windows.Forms.CheckedListBox chkListCategorias;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker cmbFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label Titulo;
    }
}