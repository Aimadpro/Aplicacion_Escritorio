namespace Aplicacion_Escritorio
{
    partial class creacion_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creacion_usuario));
            this.creacionUsuario = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contrasenyaconfirmText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuariocreateText = new System.Windows.Forms.TextBox();
            this.contrasenyacreateText = new System.Windows.Forms.TextBox();
            this.textoInicio = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listaUsuarios = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminarUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.creacionUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // creacionUsuario
            // 
            this.creacionUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(115)))));
            this.creacionUsuario.Controls.Add(this.pictureBox2);
            this.creacionUsuario.Controls.Add(this.pictureBox1);
            this.creacionUsuario.Controls.Add(this.contrasenyaconfirmText);
            this.creacionUsuario.Controls.Add(this.label4);
            this.creacionUsuario.Controls.Add(this.label3);
            this.creacionUsuario.Controls.Add(this.label2);
            this.creacionUsuario.Controls.Add(this.usuariocreateText);
            this.creacionUsuario.Controls.Add(this.contrasenyacreateText);
            this.creacionUsuario.Location = new System.Drawing.Point(82, 129);
            this.creacionUsuario.Name = "creacionUsuario";
            this.creacionUsuario.Size = new System.Drawing.Size(461, 401);
            this.creacionUsuario.TabIndex = 3;
            this.creacionUsuario.TabStop = false;
            this.creacionUsuario.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Escritorio.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(167, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contrasenyaconfirmText
            // 
            this.contrasenyaconfirmText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.contrasenyaconfirmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenyaconfirmText.ForeColor = System.Drawing.Color.White;
            this.contrasenyaconfirmText.Location = new System.Drawing.Point(167, 250);
            this.contrasenyaconfirmText.Name = "contrasenyaconfirmText";
            this.contrasenyaconfirmText.PasswordChar = '·';
            this.contrasenyaconfirmText.Size = new System.Drawing.Size(157, 29);
            this.contrasenyaconfirmText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "REPITE LA CONTRASEÑA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE DE USUARIO";
            // 
            // usuariocreateText
            // 
            this.usuariocreateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.usuariocreateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariocreateText.ForeColor = System.Drawing.Color.White;
            this.usuariocreateText.Location = new System.Drawing.Point(167, 141);
            this.usuariocreateText.Name = "usuariocreateText";
            this.usuariocreateText.Size = new System.Drawing.Size(157, 29);
            this.usuariocreateText.TabIndex = 3;
            // 
            // contrasenyacreateText
            // 
            this.contrasenyacreateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.contrasenyacreateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenyacreateText.ForeColor = System.Drawing.Color.White;
            this.contrasenyacreateText.Location = new System.Drawing.Point(167, 197);
            this.contrasenyacreateText.Name = "contrasenyacreateText";
            this.contrasenyacreateText.PasswordChar = '·';
            this.contrasenyacreateText.Size = new System.Drawing.Size(157, 29);
            this.contrasenyacreateText.TabIndex = 2;
            this.contrasenyacreateText.TextChanged += new System.EventHandler(this.contrasenyaText_TextChanged);
            // 
            // textoInicio
            // 
            this.textoInicio.AutoSize = true;
            this.textoInicio.ForeColor = System.Drawing.Color.White;
            this.textoInicio.Location = new System.Drawing.Point(79, 31);
            this.textoInicio.Name = "textoInicio";
            this.textoInicio.Size = new System.Drawing.Size(56, 13);
            this.textoInicio.TabIndex = 4;
            this.textoInicio.Text = "FocusHub";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aplicacion_Escritorio.Properties.Resources.log_solo_simbolo1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.listaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUsuarios.ForeColor = System.Drawing.Color.White;
            this.listaUsuarios.FormattingEnabled = true;
            this.listaUsuarios.ItemHeight = 20;
            this.listaUsuarios.Location = new System.Drawing.Point(772, 183);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(466, 304);
            this.listaUsuarios.TabIndex = 22;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Aplicacion_Escritorio.Properties.Resources.recuadroProyectos;
            this.pictureBox4.Location = new System.Drawing.Point(667, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(665, 465);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(612, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "Eliminar usuario";
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Image = global::Aplicacion_Escritorio.Properties.Resources.eliminarProyecto;
            this.eliminarUsuario.Location = new System.Drawing.Point(569, 202);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(37, 36);
            this.eliminarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminarUsuario.TabIndex = 27;
            this.eliminarUsuario.TabStop = false;
            this.eliminarUsuario.Click += new System.EventHandler(this.eliminarUsuario_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::Aplicacion_Escritorio.Properties.Resources.RECUADRO1;
            this.pictureBox11.Location = new System.Drawing.Point(549, 183);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(152, 74);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 28;
            this.pictureBox11.TabStop = false;
            // 
            // creacion_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1404, 723);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eliminarUsuario);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textoInicio);
            this.Controls.Add(this.creacionUsuario);
            this.Name = "creacion_usuario";
            this.Text = "g";
            this.Load += new System.EventHandler(this.creacion_usuario_Load);
            this.creacionUsuario.ResumeLayout(false);
            this.creacionUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox creacionUsuario;
        private System.Windows.Forms.TextBox usuariocreateText;
        private System.Windows.Forms.TextBox contrasenyacreateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contrasenyaconfirmText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label textoInicio;
        private System.Windows.Forms.ListBox listaUsuarios;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox eliminarUsuario;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}