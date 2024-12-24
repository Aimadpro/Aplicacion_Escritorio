namespace Aplicacion_Escritorio
{
    partial class Subtarea
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_subtarea = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.estadoSubTarea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listaColaboradoresSubTarea = new System.Windows.Forms.ListBox();
            this.nombreSubTarea = new System.Windows.Forms.TextBox();
            this.fechafinalSubtarea = new System.Windows.Forms.DateTimePicker();
            this.fechainicioSubtarea = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_subtarea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicacion_Escritorio.Properties.Resources.recuadroProyectos;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_subtarea
            // 
            this.add_subtarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(168)))));
            this.add_subtarea.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_subtarea;
            this.add_subtarea.Location = new System.Drawing.Point(310, 544);
            this.add_subtarea.Name = "add_subtarea";
            this.add_subtarea.Size = new System.Drawing.Size(133, 47);
            this.add_subtarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_subtarea.TabIndex = 68;
            this.add_subtarea.TabStop = false;
            this.add_subtarea.Click += new System.EventHandler(this.boton_add_subtarea_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(116, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 65;
            this.label6.Text = "Estado de la tarea";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // estadoSubTarea
            // 
            this.estadoSubTarea.DisplayMember = "TO DO";
            this.estadoSubTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoSubTarea.FormattingEnabled = true;
            this.estadoSubTarea.Items.AddRange(new object[] {
            "TO DO ",
            "DOING",
            "DONE"});
            this.estadoSubTarea.Location = new System.Drawing.Point(279, 220);
            this.estadoSubTarea.Name = "estadoSubTarea";
            this.estadoSubTarea.Size = new System.Drawing.Size(121, 21);
            this.estadoSubTarea.TabIndex = 64;
            this.estadoSubTarea.SelectedIndexChanged += new System.EventHandler(this.estadoTarea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Elige a los colaboradores";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(116, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Fecha de  final";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(116, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Fecha de  inicio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(116, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 18);
            this.label11.TabIndex = 60;
            this.label11.Text = "Nombre de la Subtarea";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // listaColaboradoresSubTarea
            // 
            this.listaColaboradoresSubTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.listaColaboradoresSubTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaColaboradoresSubTarea.ForeColor = System.Drawing.Color.White;
            this.listaColaboradoresSubTarea.FormattingEnabled = true;
            this.listaColaboradoresSubTarea.ItemHeight = 20;
            this.listaColaboradoresSubTarea.Location = new System.Drawing.Point(166, 314);
            this.listaColaboradoresSubTarea.Name = "listaColaboradoresSubTarea";
            this.listaColaboradoresSubTarea.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listaColaboradoresSubTarea.Size = new System.Drawing.Size(408, 224);
            this.listaColaboradoresSubTarea.TabIndex = 59;
            this.listaColaboradoresSubTarea.SelectedIndexChanged += new System.EventHandler(this.listaColaboradoresTarea_SelectedIndexChanged);
            // 
            // nombreSubTarea
            // 
            this.nombreSubTarea.Location = new System.Drawing.Point(279, 89);
            this.nombreSubTarea.Name = "nombreSubTarea";
            this.nombreSubTarea.Size = new System.Drawing.Size(281, 20);
            this.nombreSubTarea.TabIndex = 58;
            this.nombreSubTarea.TextChanged += new System.EventHandler(this.nombreTarea_TextChanged);
            // 
            // fechafinalSubtarea
            // 
            this.fechafinalSubtarea.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinalSubtarea.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinalSubtarea.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinalSubtarea.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinalSubtarea.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinalSubtarea.Location = new System.Drawing.Point(279, 171);
            this.fechafinalSubtarea.Name = "fechafinalSubtarea";
            this.fechafinalSubtarea.Size = new System.Drawing.Size(281, 20);
            this.fechafinalSubtarea.TabIndex = 57;
            this.fechafinalSubtarea.ValueChanged += new System.EventHandler(this.fechafinaltarea_ValueChanged);
            // 
            // fechainicioSubtarea
            // 
            this.fechainicioSubtarea.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainicioSubtarea.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainicioSubtarea.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainicioSubtarea.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainicioSubtarea.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainicioSubtarea.Location = new System.Drawing.Point(279, 129);
            this.fechainicioSubtarea.Name = "fechainicioSubtarea";
            this.fechainicioSubtarea.Size = new System.Drawing.Size(281, 20);
            this.fechainicioSubtarea.TabIndex = 56;
            this.fechainicioSubtarea.ValueChanged += new System.EventHandler(this.fechainiciotarea_ValueChanged);
            // 
            // Subtarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(734, 643);
            this.Controls.Add(this.add_subtarea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estadoSubTarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listaColaboradoresSubTarea);
            this.Controls.Add(this.nombreSubTarea);
            this.Controls.Add(this.fechafinalSubtarea);
            this.Controls.Add(this.fechainicioSubtarea);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Subtarea";
            this.Text = "Subtarea";
            this.Load += new System.EventHandler(this.Subtarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_subtarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox add_subtarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox estadoSubTarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listaColaboradoresSubTarea;
        private System.Windows.Forms.TextBox nombreSubTarea;
        private System.Windows.Forms.DateTimePicker fechafinalSubtarea;
        private System.Windows.Forms.DateTimePicker fechainicioSubtarea;
    }
}