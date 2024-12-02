namespace Aplicacion_Escritorio
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textoInicio = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textoProyecto = new System.Windows.Forms.Label();
            this.cuadroProyectos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.anyadirUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anyadirProyecto = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyadirUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyadirProyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(936, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoInicio
            // 
            this.textoInicio.AutoSize = true;
            this.textoInicio.ForeColor = System.Drawing.Color.White;
            this.textoInicio.Location = new System.Drawing.Point(79, 20);
            this.textoInicio.Name = "textoInicio";
            this.textoInicio.Size = new System.Drawing.Size(56, 13);
            this.textoInicio.TabIndex = 1;
            this.textoInicio.Text = "FocusHub";
            this.textoInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textoProyecto
            // 
            this.textoProyecto.AutoSize = true;
            this.textoProyecto.ForeColor = System.Drawing.Color.White;
            this.textoProyecto.Location = new System.Drawing.Point(436, 146);
            this.textoProyecto.Name = "textoProyecto";
            this.textoProyecto.Size = new System.Drawing.Size(84, 13);
            this.textoProyecto.TabIndex = 9;
            this.textoProyecto.Text = "Nuevo Proyecto";
            this.textoProyecto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cuadroProyectos
            // 
            this.cuadroProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuadroProyectos.Location = new System.Drawing.Point(412, 349);
            this.cuadroProyectos.Name = "cuadroProyectos";
            this.cuadroProyectos.Size = new System.Drawing.Size(841, 308);
            this.cuadroProyectos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(765, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nuevo Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Escritorio.Properties.Resources.recuadroProyectos;
            this.pictureBox2.Location = new System.Drawing.Point(252, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1136, 470);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_plus;
            this.pictureBox7.Location = new System.Drawing.Point(961, 137);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Aplicacion_Escritorio.Properties.Resources.RECUADRO1;
            this.pictureBox5.Location = new System.Drawing.Point(921, 89);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(234, 125);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // anyadirUsuario
            // 
            this.anyadirUsuario.BackColor = System.Drawing.Color.Transparent;
            this.anyadirUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anyadirUsuario.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_plus;
            this.anyadirUsuario.Location = new System.Drawing.Point(695, 137);
            this.anyadirUsuario.Name = "anyadirUsuario";
            this.anyadirUsuario.Size = new System.Drawing.Size(37, 32);
            this.anyadirUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anyadirUsuario.TabIndex = 13;
            this.anyadirUsuario.TabStop = false;
            this.anyadirUsuario.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Aplicacion_Escritorio.Properties.Resources.RECUADRO1;
            this.pictureBox6.Location = new System.Drawing.Point(658, 89);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(234, 125);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Aplicacion_Escritorio.Properties.Resources.buscador;
            this.pictureBox4.Location = new System.Drawing.Point(853, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicacion_Escritorio.Properties.Resources.log_solo_simbolo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // anyadirProyecto
            // 
            this.anyadirProyecto.BackColor = System.Drawing.Color.Transparent;
            this.anyadirProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anyadirProyecto.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_plus;
            this.anyadirProyecto.Location = new System.Drawing.Point(366, 137);
            this.anyadirProyecto.Name = "anyadirProyecto";
            this.anyadirProyecto.Size = new System.Drawing.Size(37, 32);
            this.anyadirProyecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anyadirProyecto.TabIndex = 0;
            this.anyadirProyecto.TabStop = false;
            this.anyadirProyecto.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Aplicacion_Escritorio.Properties.Resources.RECUADRO1;
            this.pictureBox3.Location = new System.Drawing.Point(329, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(234, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anyadirUsuario);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cuadroProyectos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textoInicio);
            this.Controls.Add(this.textoProyecto);
            this.Controls.Add(this.anyadirProyecto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuadroProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyadirUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anyadirProyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textoInicio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox anyadirProyecto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label textoProyecto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView cuadroProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox anyadirUsuario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}