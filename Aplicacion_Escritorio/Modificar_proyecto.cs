using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Aplicacion_Escritorio
{
    public partial class Modificar_proyecto : Form
    {
        Proyecto proyectoSeleccionado;
        List<Proyecto> proyectos;
        Tools tools = new Tools();
        List<Colaborador> colaboradores;
        List<Colaborador> colaboradoresAnadir;
        int proyectoSeleccionadoId;
        Tarea tareaRecibir;
        List<Tarea> subTareas;
        Tarea tareaSeleccionada;
        Form2 f  = new Form2();
        
        public Modificar_proyecto(Proyecto proyectoSeleccioando1)
        {
            proyectos = Form2.proyectos;
            InitializeComponent();
            proyectoSeleccionado = proyectoSeleccioando1;
            proyectoSeleccionadoId = proyectoSeleccioando1.id;
            colaboradores = Form2.colaboradores;
            mostrar_info_proy();
            mostrarTareas();
            mostrar_colaboradores(proyectoSeleccioando1.colaboradores);
            guardarModificaciones.Visible = false;   
            flecha_atras.Visible = false;

        }

        private void mostrarSubtareas()
        {
            if (tareaSeleccionada != null) { 
            listaSubtareas.DataSource = null; // Reseteamos la DataSource para evitar problemas
            listaSubtareas.DataSource = tareaSeleccionada.subTareas;
            listaSubtareas.DisplayMember = "nombreTarea";
            }
        }

        private void mostrar_info_proy() {
            int i = 0;
            List<Colaborador> colaboradoresProyecto = new List<Colaborador>();

            foreach (int num in proyectoSeleccionado.colaboradores)
            {

                foreach (Colaborador colaborador1 in colaboradores)
                {
                    if (num == colaborador1.id)
                    {
                        colaboradoresProyecto.Add(colaborador1);
                    }
                }

            }

            foreach (var colaborador in colaboradoresProyecto)
            {
                listaUsersProject.Items.Add(colaborador.nombre); // Aquí accedes al atributo Nombre
            }
            projectName.Text = proyectoSeleccionado.nombreProyecto;

        }
        private void mostrarListaSubTareas(List<Tarea>subtareas)
        {
            if (subTareas !=null) {
            foreach (Tarea tarea in subtareas) {
                listaSubtareas.Items.Add(tarea.nombreTarea);// Aquí accedes al atributo Nombre
                    }
            }
        }
        private void mostrarTareas()
        {
            
            
            if (proyectoSeleccionado.tareas != null && proyectoSeleccionado.tareas.Count > 0)
            {
                listaTareas.DataSource = null; // Reseteamos la DataSource para evitar problemas
                listaTareas.DataSource = proyectoSeleccionado.tareas;
                listaTareas.DisplayMember = "nombreTarea"; // El nombre que se mostrará
            }
            else
            {
                MessageBox.Show("El proyecto no tiene tareas asignadas.");
            }
        }

        private void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elegirColaboradoresTrea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)

        {
            List<Colaborador> colaboradoresSeleccionados = listaColaboradoresTarea.SelectedItems.Cast<Colaborador>().ToList();
            foreach (var colaborador in colaboradoresSeleccionados)
            {
                Console.WriteLine($"ID: {colaborador.id}, Nombre: {colaborador.nombre}");
            }
            List<Tarea> subtareas = listaSubtareas.Items.Cast<Tarea>().ToList();

            if (fechainiciotarea.Value == null ||
                fechafinaltarea.Value == null ||
                string.IsNullOrWhiteSpace(nombreTarea.Text) ||
                estadoTarea.SelectedItem == null ||
                !colaboradoresSeleccionados.Any())
            {
                MessageBox.Show("Faltan valores en uno o más campos. Por favor, completa todos los campos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
               
            }
            else
            {

                Tarea tarea = new Tarea(fechainiciotarea.Value, fechafinaltarea.Value, nombreTarea.Text, estadoTarea.SelectedItem.ToString(), colaboradoresSeleccionados, subtareas);
                proyectoSeleccionado.tareas.Add(tarea);
                mostrarTareas();
                fechainiciotarea.Value = DateTime.Now;
                nombreTarea.Text = "";
                fechafinaltarea.Value = DateTime.Now;
                estadoTarea.SelectedItem = null;
                listaSubtareas.DataSource = null;
            }

        }

        private void mostrar_colaboradores(List<int> colaboradoresIds)
        {
            colaboradoresAnadir = new List<Colaborador>();
            foreach (int id in colaboradoresIds)
            {
                // Buscamos el colaborador correspondiente al ID
                Colaborador colaborador = colaboradores.FirstOrDefault(c => c.id == id);
                if (colaborador != null)
                {
                    colaboradoresAnadir.Add(colaborador);
                }
            }
            listaColaboradoresTarea.DataSource = colaboradoresAnadir;
            listaColaboradoresTarea.DisplayMember = "Nombre";
            listaColaboradoresTarea.ValueMember = "id";
        }
        private void mostrarColaboradoresTareaSeleccionada(List<Colaborador>colaboradores)
        {
            
            listaColaboradoresTarea.DataSource = colaboradores;
            listaColaboradoresTarea.DisplayMember = "Nombre";
            listaColaboradoresTarea.ValueMember = "id";
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            JObject jsonData = tools.extraerJSON();

            JArray proyectosArray = (JArray)jsonData["Proyectos"];

            // Buscar el proyecto por ID
            JObject proyectoExistente = proyectosArray.FirstOrDefault(p => (int)p["id"] == proyectoSeleccionadoId) as JObject;

            if (proyectoExistente != null)
            {
                // Actualizar los campos del proyecto con los nuevos valores
                proyectoExistente["nombreProyecto"] = proyectoSeleccionado.nombreProyecto;
               // proyectoExistente["imagenProyecto"] = proyectoSeleccionado.imagenProyecto;

                // Actualizar colaboradores
                JArray colaboradoresArray = new JArray(proyectoSeleccionado.colaboradores);
                proyectoExistente["colaboradores"] = colaboradoresArray;

                // Actualizar tareas
                JArray tareasArray = JArray.FromObject(proyectoSeleccionado.tareas);
                proyectoExistente["tareas"] = tareasArray;

                // Guardar cambios en el archivo JSON
                File.WriteAllText("E:\\Aplicacion_Escritorio\\Aplicacion_Escritorio\\JSON\\intermodular.json", jsonData.ToString());
                MessageBox.Show("Proyecto actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró el proyecto con el ID especificado.");
            }
            Form2 newForm = new Form2();
            newForm.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
                                                              // Crea una instancia del nuevo formulario
            this.Hide(); // Oculta el formulario actual
            newForm.Show();

           

        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boton_modificar_tarea_Click(object sender, EventArgs e)
        {

            if (listaTareas.SelectedItem == null)
            {
                MessageBox.Show("No hay ningún elemento seleccionado.");
            }
            else
            {
                tareaSeleccionada = listaTareas.SelectedItem as Tarea;
                fechainiciotarea.Value = tareaSeleccionada.fechaInicio;
                nombreTarea.Text = tareaSeleccionada.nombreTarea;
                fechafinaltarea.Value = tareaSeleccionada.fechaFinal;
                estadoTarea.SelectedItem = tareaSeleccionada.estadoTarea;
                listaColaboradoresTarea.DataSource = tareaSeleccionada.colaboradores;
                mostrarColaboradoresTareaSeleccionada(tareaSeleccionada.colaboradores);
                MessageBox.Show("Va a modificar la tarea "+ tareaSeleccionada.nombreTarea);
                pictureBox3.Visible = false;
                flecha_atras.Visible = true;
                guardarModificaciones.Visible = true;
            }
            mostrarSubtareas();
           

        }

        private void nombreTarea_TextChanged(object sender, EventArgs e)
        {
        }

        private void boton_add_subtarea_Click(object sender, EventArgs e)
        {
           
            // Validar si hay una tarea seleccionada
            if (tareaSeleccionada == null)
            {
                MessageBox.Show("Por favor, selecciona una tarea antes de añadir una subtarea.");
                return;
            }

            // Crear y mostrar el formulario de subtareas
            Subtarea newForm = new Subtarea(colaboradoresAnadir);
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();

            // Obtener la subtarea creada
            tareaRecibir = newForm.subtarea;
            if (tareaRecibir != null)
            {
                // Inicializar la lista de subtareas si está null
                if (tareaSeleccionada.subTareas == null)
                {
                    tareaSeleccionada.subTareas = new List<Tarea>();
                }

                // Añadir la subtarea a la lista en memoria

                tareaSeleccionada.subTareas.Add(tareaRecibir);
                // El nombre que se mostrará
                mostrarSubtareas();

            }
            else
            {
                MessageBox.Show("No se ha creado ninguna subtarea.");
            }
        }

        private void guardarModificaciones_Click(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
            {
                tareaSeleccionada.nombreTarea = nombreTarea.Text;
                tareaSeleccionada.estadoTarea = estadoTarea.Text;
                tareaSeleccionada.colaboradores = colaboradoresAnadir;
                mostrarTareas();
                MessageBox.Show("Se ha modificado la tarea exitosamente");
            }
            else {
                MessageBox.Show("No se ha seleccionado ninguna tarea a la que guardar las modificaciones");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
    
            fechainiciotarea.Value = DateTime.Now;
            nombreTarea.Text = "";
            fechafinaltarea.Value = DateTime.Now;
            estadoTarea.SelectedItem= null;
            listaSubtareas.DataSource = null;
            mostrar_colaboradores(proyectoSeleccionado.colaboradores);
            guardarModificaciones.Visible = false;
            pictureBox3.Visible = true;
            flecha_atras.Visible = false;
        }
    }
}