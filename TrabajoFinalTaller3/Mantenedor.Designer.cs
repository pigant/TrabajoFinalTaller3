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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Idioma_btn = new System.Windows.Forms.Button();
            this.Idioma_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Categoria_btn = new System.Windows.Forms.Button();
            this.Categoria_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Idioma_btn);
            this.groupBox1.Controls.Add(this.Idioma_txt);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(377, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idiomas";
            // 
            // Idioma_btn
            // 
            this.Idioma_btn.Location = new System.Drawing.Point(260, 39);
            this.Idioma_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Idioma_btn.Name = "Idioma_btn";
            this.Idioma_btn.Size = new System.Drawing.Size(100, 28);
            this.Idioma_btn.TabIndex = 1;
            this.Idioma_btn.Text = "Agregar";
            this.Idioma_btn.UseVisualStyleBackColor = true;
            this.Idioma_btn.Click += new System.EventHandler(this.Idioma_btn_Click);
            // 
            // Idioma_txt
            // 
            this.Idioma_txt.Location = new System.Drawing.Point(36, 42);
            this.Idioma_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Idioma_txt.Name = "Idioma_txt";
            this.Idioma_txt.Size = new System.Drawing.Size(215, 22);
            this.Idioma_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Categoria_btn);
            this.groupBox2.Controls.Add(this.Categoria_txt);
            this.groupBox2.Location = new System.Drawing.Point(401, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(372, 206);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // Categoria_btn
            // 
            this.Categoria_btn.Location = new System.Drawing.Point(251, 39);
            this.Categoria_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Categoria_btn.Name = "Categoria_btn";
            this.Categoria_btn.Size = new System.Drawing.Size(100, 28);
            this.Categoria_btn.TabIndex = 1;
            this.Categoria_btn.Text = "Agregar";
            this.Categoria_btn.UseVisualStyleBackColor = true;
            this.Categoria_btn.Click += new System.EventHandler(this.Categoria_btn_Click);
            // 
            // Categoria_txt
            // 
            this.Categoria_txt.Location = new System.Drawing.Point(29, 42);
            this.Categoria_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Categoria_txt.Name = "Categoria_txt";
            this.Categoria_txt.Size = new System.Drawing.Size(212, 22);
            this.Categoria_txt.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 241);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mantenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mantenedor";
            this.Text = "Mantenedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Idioma_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Categoria_txt;
        private System.Windows.Forms.Button Idioma_btn;
        private System.Windows.Forms.Button Categoria_btn;
        private System.Windows.Forms.Button button3;
    }
}