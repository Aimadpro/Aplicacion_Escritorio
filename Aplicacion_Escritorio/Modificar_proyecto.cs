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
        public Modificar_proyecto(Proyecto proyectoSeleccioando1)
        {
            InitializeComponent();
            proyectoSeleccionado = proyectoSeleccioando1;

            Tools tools = new Tools();
            List<Colaborador> colaboradores = tools.ObtenerColaboradores();
            foreach (var colaborador in colaboradores)
            {
                eleglistaUsuariosirColaboradoresTrea.Items.Add(colaborador.nombre); // Aquí accedes al atributo Nombre
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
            Tarea tarea = new Tarea();  
            tarea.nombreTarea = nombreTarea.Text;
            tarea.fechaInicio = fechainiciotarea.Value;
            tarea.estadoTarea = "TO DO";
            tarea.fechaFinal = fechafinaltarea.Value;
            
            proyectoSeleccionado.tareas.Add(tarea);
            Tools tools = new Tools();
            JObject jsonObject = tools.extraerJSON();
            var proyectosArray = (JArray)jsonObject["Proyectos"];
            var proyecto = proyectosArray.FirstOrDefault(p => (int)p["id"] == proyectoSeleccionado.id);

            if (proyecto != null)
            {
                // Obtener el campo "tareas"
                var tareas = proyecto["tareas"] as JArray;

                // Inicializar el campo "tareas" si está null
                if (tareas == null)
                {
                    tareas = new JArray();
                    proyecto["tareas"] = tareas;
                }

                // Añadir la nueva tarea al array de tareas
                tareas.Add(JObject.FromObject(proyectoSeleccionado));
            }
            else
            {
                Console.WriteLine("Error");
            }
            // Guardar los cambios de vuelta al archivo
            File.WriteAllText("D:\\Aplicacion_Escritorio\\Aplicacion_Escritorio\\JSON\\intermodular.json", jsonObject.ToString((Newtonsoft.Json.Formatting)Formatting.Indented));

        }


    }
}
