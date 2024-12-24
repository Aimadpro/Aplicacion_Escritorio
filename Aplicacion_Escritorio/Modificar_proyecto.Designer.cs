namespace Aplicacion_Escritorio
{
    partial class Modificar_proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificar_proyecto));
            this.listaTareas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.listaUsersProject = new System.Windows.Forms.ListBox();
            this.fechafinaltarea = new System.Windows.Forms.DateTimePicker();
            this.fechainiciotarea = new System.Windows.Forms.DateTimePicker();
            this.nombreTarea = new System.Windows.Forms.TextBox();
            this.listaColaboradoresTarea = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaSubtareas = new System.Windows.Forms.ListBox();
            this.flecha_atras = new System.Windows.Forms.PictureBox();
            this.boton_add_subtarea = new System.Windows.Forms.PictureBox();
            this.boton_modificar_tarea = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guardarModificaciones = new System.Windows.Forms.PictureBox();
            this.estadoTarea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flecha_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_add_subtarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_modificar_tarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardarModificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // listaTareas
            // 
            this.listaTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.listaTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaTareas.ForeColor = System.Drawing.Color.White;
            this.listaTareas.FormattingEnabled = true;
            this.listaTareas.ItemHeight = 20;
            this.listaTareas.Location = new System.Drawing.Point(73, 445);
            this.listaTareas.Name = "listaTareas";
            this.listaTareas.Size = new System.Drawing.Size(615, 124);
            this.listaTareas.TabIndex = 20;
            this.listaTareas.SelectedIndexChanged += new System.EventHandler(this.listaUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre del proyecto";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(320, 157);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(277, 20);
            this.projectName.TabIndex = 22;
            // 
            // listaUsersProject
            // 
            this.listaUsersProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.listaUsersProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaUsersProject.ForeColor = System.Drawing.Color.White;
            this.listaUsersProject.FormattingEnabled = true;
            this.listaUsersProject.ItemHeight = 20;
            this.listaUsersProject.Location = new System.Drawing.Point(73, 255);
            this.listaUsersProject.Name = "listaUsersProject";
            this.listaUsersProject.Size = new System.Drawing.Size(615, 144);
            this.listaUsersProject.TabIndex = 29;
            // 
            // fechafinaltarea
            // 
            this.fechafinaltarea.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinaltarea.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinaltarea.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinaltarea.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinaltarea.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechafinaltarea.Location = new System.Drawing.Point(1032, 206);
            this.fechafinaltarea.Name = "fechafinaltarea";
            this.fechafinaltarea.Size = new System.Drawing.Size(281, 20);
            this.fechafinaltarea.TabIndex = 38;
            // 
            // fechainiciotarea
            // 
            this.fechainiciotarea.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainiciotarea.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainiciotarea.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainiciotarea.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainiciotarea.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.fechainiciotarea.Location = new System.Drawing.Point(1032, 164);
            this.fechainiciotarea.Name = "fechainiciotarea";
            this.fechainiciotarea.Size = new System.Drawing.Size(281, 20);
            this.fechainiciotarea.TabIndex = 35;
            // 
            // nombreTarea
            // 
            this.nombreTarea.Location = new System.Drawing.Point(1032, 124);
            this.nombreTarea.Name = "nombreTarea";
            this.nombreTarea.Size = new System.Drawing.Size(281, 20);
            this.nombreTarea.TabIndex = 39;
            this.nombreTarea.TextChanged += new System.EventHandler(this.nombreTarea_TextChanged);
            // 
            // listaColaboradoresTarea
            // 
            this.listaColaboradoresTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.listaColaboradoresTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaColaboradoresTarea.ForeColor = System.Drawing.Color.White;
            this.listaColaboradoresTarea.FormattingEnabled = true;
            this.listaColaboradoresTarea.ItemHeight = 20;
            this.listaColaboradoresTarea.Location = new System.Drawing.Point(839, 358);
            this.listaColaboradoresTarea.Name = "listaColaboradoresTarea";
            this.listaColaboradoresTarea.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listaColaboradoresTarea.Size = new System.Drawing.Size(262, 164);
            this.listaColaboradoresTarea.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(336, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Lista de usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Lista de tareas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(869, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "Nombre de la tarea";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(869, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Fecha de  inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(869, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Fecha de  final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(888, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Elige a los colaboradores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(869, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Estado tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1218, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Subtareas a añadir";
            // 
            // listaSubtareas
            // 
            this.listaSubtareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.listaSubtareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSubtareas.ForeColor = System.Drawing.Color.White;
            this.listaSubtareas.FormattingEnabled = true;
            this.listaSubtareas.ItemHeight = 20;
            this.listaSubtareas.Location = new System.Drawing.Point(1153, 358);
            this.listaSubtareas.Name = "listaSubtareas";
            this.listaSubtareas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listaSubtareas.Size = new System.Drawing.Size(262, 164);
            this.listaSubtareas.TabIndex = 54;
            // 
            // flecha_atras
            // 
            this.flecha_atras.BackColor = System.Drawing.Color.AliceBlue;
            this.flecha_atras.Image = global::Aplicacion_Escritorio.Properties.Resources.flecha_atras1;
            this.flecha_atras.Location = new System.Drawing.Point(839, 83);
            this.flecha_atras.Name = "flecha_atras";
            this.flecha_atras.Size = new System.Drawing.Size(59, 30);
            this.flecha_atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha_atras.TabIndex = 57;
            this.flecha_atras.TabStop = false;
            this.flecha_atras.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // boton_add_subtarea
            // 
            this.boton_add_subtarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(167)))));
            this.boton_add_subtarea.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_subtarea;
            this.boton_add_subtarea.Location = new System.Drawing.Point(1218, 528);
            this.boton_add_subtarea.Name = "boton_add_subtarea";
            this.boton_add_subtarea.Size = new System.Drawing.Size(133, 47);
            this.boton_add_subtarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boton_add_subtarea.TabIndex = 55;
            this.boton_add_subtarea.TabStop = false;
            this.boton_add_subtarea.Click += new System.EventHandler(this.boton_add_subtarea_Click);
            // 
            // boton_modificar_tarea
            // 
            this.boton_modificar_tarea.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_modificar_tarea;
            this.boton_modificar_tarea.Location = new System.Drawing.Point(73, 606);
            this.boton_modificar_tarea.Name = "boton_modificar_tarea";
            this.boton_modificar_tarea.Size = new System.Drawing.Size(133, 50);
            this.boton_modificar_tarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boton_modificar_tarea.TabIndex = 52;
            this.boton_modificar_tarea.TabStop = false;
            this.boton_modificar_tarea.Click += new System.EventHandler(this.boton_modificar_tarea_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Aplicacion_Escritorio.Properties.Resources.log_solo_simbolo1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1218, 606);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 50);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aplicacion_Escritorio.Properties.Resources.recuadroProyectos;
            this.pictureBox1.Location = new System.Drawing.Point(751, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Escritorio.Properties.Resources.recuadroProyectos;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(787, 629);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // guardarModificaciones
            // 
            this.guardarModificaciones.Image = global::Aplicacion_Escritorio.Properties.Resources.boton_mod_tarea;
            this.guardarModificaciones.Location = new System.Drawing.Point(839, 606);
            this.guardarModificaciones.Name = "guardarModificaciones";
            this.guardarModificaciones.Size = new System.Drawing.Size(135, 50);
            this.guardarModificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardarModificaciones.TabIndex = 56;
            this.guardarModificaciones.TabStop = false;
            this.guardarModificaciones.Click += new System.EventHandler(this.guardarModificaciones_Click);
            // 
            // estadoTarea
            // 
            this.estadoTarea.DisplayMember = "TO DO";
            this.estadoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoTarea.FormattingEnabled = true;
            this.estadoTarea.Items.AddRange(new object[] {
            "TO DO ",
            "DOING",
            "DONE"});
            this.estadoTarea.Location = new System.Drawing.Point(1032, 255);
            this.estadoTarea.Name = "estadoTarea";
            this.estadoTarea.Size = new System.Drawing.Size(121, 21);
            this.estadoTarea.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(70, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ir al inicio";
            // 
            // Modificar_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1488, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flecha_atras);
            this.Controls.Add(this.guardarModificaciones);
            this.Controls.Add(this.boton_add_subtarea);
            this.Controls.Add(this.listaSubtareas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_modificar_tarea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estadoTarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listaColaboradoresTarea);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nombreTarea);
            this.Controls.Add(this.fechafinaltarea);
            this.Controls.Add(this.fechainiciotarea);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.listaUsersProject);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaTareas);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Modificar_proyecto";
            this.Text = "EliminarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.flecha_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_add_subtarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boton_modificar_tarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardarModificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listaTareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listaUsersProject;
        private System.Windows.Forms.DateTimePicker fechafinaltarea;
        private System.Windows.Forms.DateTimePicker fechainiciotarea;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox nombreTarea;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox listaColaboradoresTarea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox boton_modificar_tarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaSubtareas;
        private System.Windows.Forms.PictureBox boton_add_subtarea;
        private System.Windows.Forms.PictureBox flecha_atras;
        private System.Windows.Forms.PictureBox guardarModificaciones;
        private System.Windows.Forms.ComboBox estadoTarea;
        private System.Windows.Forms.Label label8;
    }
}