namespace Aplicacion_Escritorio
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
            this.button1 = new System.Windows.Forms.Button();
            this.inicioSesion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.contrasenyaText = new System.Windows.Forms.TextBox();
            this.inicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(179, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "INICIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicioSesion
            // 
            this.inicioSesion.BackColor = System.Drawing.Color.AliceBlue;
            this.inicioSesion.Controls.Add(this.pictureBox1);
            this.inicioSesion.Controls.Add(this.pictureBox3);
            this.inicioSesion.Controls.Add(this.pictureBox2);
            this.inicioSesion.Controls.Add(this.usuarioText);
            this.inicioSesion.Controls.Add(this.contrasenyaText);
            this.inicioSesion.Controls.Add(this.button1);
            this.inicioSesion.Location = new System.Drawing.Point(748, 222);
            this.inicioSesion.Name = "inicioSesion";
            this.inicioSesion.Size = new System.Drawing.Size(461, 401);
            this.inicioSesion.TabIndex = 2;
            this.inicioSesion.TabStop = false;
            this.inicioSesion.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicacion_Escritorio.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(148, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aplicacion_Escritorio.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(117, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Escritorio.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(117, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // usuarioText
            // 
            this.usuarioText.Location = new System.Drawing.Point(152, 201);
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(157, 20);
            this.usuarioText.TabIndex = 3;
            this.usuarioText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // contrasenyaText
            // 
            this.contrasenyaText.Location = new System.Drawing.Point(152, 258);
            this.contrasenyaText.Name = "contrasenyaText";
            this.contrasenyaText.Size = new System.Drawing.Size(157, 20);
            this.contrasenyaText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::Aplicacion_Escritorio.Properties.Resources.imagenfondoincio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.inicioSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inicioSesion.ResumeLayout(false);
            this.inicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox inicioSesion;
        private System.Windows.Forms.TextBox contrasenyaText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usuarioText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

