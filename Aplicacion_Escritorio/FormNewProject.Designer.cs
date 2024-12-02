namespace Aplicacion_Escritorio
{
    partial class FormNewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewProject));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elegirColaboradoresProyecto = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textoInicio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(115)))));
            this.groupBox1.Controls.Add(this.elegirColaboradoresProyecto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.projectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(338, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 544);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // elegirColaboradoresProyecto
            // 
            this.elegirColaboradoresProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.elegirColaboradoresProyecto.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elegirColaboradoresProyecto.ForeColor = System.Drawing.Color.White;
            this.elegirColaboradoresProyecto.FormattingEnabled = true;
            this.elegirColaboradoresProyecto.ItemHeight = 29;
            this.elegirColaboradoresProyecto.Location = new System.Drawing.Point(75, 162);
            this.elegirColaboradoresProyecto.Name = "elegirColaboradoresProyecto";
            this.elegirColaboradoresProyecto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.elegirColaboradoresProyecto.Size = new System.Drawing.Size(532, 236);
            this.elegirColaboradoresProyecto.TabIndex = 5;
            this.elegirColaboradoresProyecto.SelectedIndexChanged += new System.EventHandler(this.elegirColaboradoresProyecto_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ELIGE A LOS COLABORADORES";
            // 
            // projectName
            // 
            this.projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.projectName.ForeColor = System.Drawing.Color.White;
            this.projectName.Location = new System.Drawing.Point(238, 63);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(281, 20);
            this.projectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE DEL PROYECTO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Escritorio.Properties.Resources.log_solo_simbolo1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // FormNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textoInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormNewProject";
            this.Text = "FormNewProject";
            this.Load += new System.EventHandler(this.FormNewProject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox elegirColaboradoresProyecto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label textoInicio;
    }
}