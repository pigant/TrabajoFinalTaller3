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
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(757, 143);
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
            this.grpDtos.Location = new System.Drawing.Point(33, 158);
            this.grpDtos.Margin = new System.Windows.Forms.Padding(4);
            this.grpDtos.Name = "grpDtos";
            this.grpDtos.Padding = new System.Windows.Forms.Padding(4);
            this.grpDtos.Size = new System.Drawing.Size(699, 480);
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
            this.txtEvaluacion.Location = new System.Drawing.Point(496, 198);
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
            this.txtEvaluacion.Size = new System.Drawing.Size(174, 22);
            this.txtEvaluacion.TabIndex = 44;
            this.txtEvaluacion.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtCantidad
            // 
            this.txtCantidad.ForeColor = System.Drawing.Color.SlateGray;
            this.txtCantidad.Location = new System.Drawing.Point(117, 194);
            this.txtCantidad.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 22);
            this.txtCantidad.TabIndex = 43;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkListSubtitulos
            // 
            this.chkListSubtitulos.FormattingEnabled = true;
            this.chkListSubtitulos.Location = new System.Drawing.Point(481, 327);
            this.chkListSubtitulos.Margin = new System.Windows.Forms.Padding(4);
            this.chkListSubtitulos.Name = "chkListSubtitulos";
            this.chkListSubtitulos.Size = new System.Drawing.Size(189, 89);
            this.chkListSubtitulos.TabIndex = 0;
            // 
            // chkListAudio
            // 
            this.chkListAudio.FormattingEnabled = true;
            this.chkListAudio.Location = new System.Drawing.Point(259, 327);
            this.chkListAudio.Margin = new System.Windows.Forms.Padding(4);
            this.chkListAudio.Name = "chkListAudio";
            this.chkListAudio.Size = new System.Drawing.Size(183, 89);
            this.chkListAudio.TabIndex = 0;
            // 
            // chkListCategorias
            // 
            this.chkListCategorias.FormattingEnabled = true;
            this.chkListCategorias.Location = new System.Drawing.Point(33, 327);
            this.chkListCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.chkListCategorias.Name = "chkListCategorias";
            this.chkListCategorias.Size = new System.Drawing.Size(181, 89);
            this.chkListCategorias.TabIndex = 0;
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(117, 146);
            this.cmbClase.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(163, 24);
            this.cmbClase.TabIndex = 41;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(117, 102);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(163, 24);
            this.cmbTipo.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cantidad";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(28, 150);
            this.lblClase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(43, 17);
            this.lblClase.TabIndex = 39;
            this.lblClase.Text = "Clase";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(29, 106);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 40;
            this.lblTipo.Text = "Tipo";
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Location = new System.Drawing.Point(408, 199);
            this.lblEvaluacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(77, 17);
            this.lblEvaluacion.TabIndex = 35;
            this.lblEvaluacion.Text = "Evaluacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(497, 146);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(173, 22);
            this.txtUbicacion.TabIndex = 34;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(408, 150);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(70, 17);
            this.lblUbicacion.TabIndex = 33;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(405, 436);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(549, 436);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "Agregar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Subtitulos";
            // 
            // cmbFecha
            // 
            this.cmbFecha.Location = new System.Drawing.Point(405, 104);
            this.cmbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(265, 22);
            this.cmbFecha.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Audio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(401, 86);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(132, 17);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha Lanzamiento";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(29, 307);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(76, 17);
            this.lblCategorias.TabIndex = 24;
            this.lblCategorias.Text = "Categorias";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(28, 226);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(80, 17);
            this.lblComentario.TabIndex = 24;
            this.lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(32, 246);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentario.MaxLength = 255;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(639, 57);
            this.txtComentario.TabIndex = 23;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(33, 50);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(637, 22);
            this.txtTitulo.TabIndex = 21;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(29, 29);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(43, 17);
            this.Titulo.TabIndex = 20;
            this.Titulo.Text = "Titulo";
            // 
            // EditarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 646);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpDtos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(793, 684);
            this.MinimumSize = new System.Drawing.Size(793, 684);
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