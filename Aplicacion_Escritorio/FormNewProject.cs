using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicacion_Escritorio
{
    public partial class FormNewProject : Form
    {
        List<Proyecto> proyectos;
        public FormNewProject()
        {
            InitializeComponent();
            // Lista de colaboradores
            Tools tools = new Tools();
            BindingList<Colaborador> colaboradores = new BindingList<Colaborador>(tools.ObtenerColaboradores());

            // Configurar el ListView
            elegirColaboradoresProyecto.DataSource = colaboradores;
            elegirColaboradoresProyecto.DisplayMember = "Nombre";
            elegirColaboradoresProyecto.ValueMember = "id";


        }

        private void FormNewProject_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }
        private List<int> obtenerIdColaboradores()
        {
            List<int> selectedIds = new List<int>();

            // Recorremos los elementos seleccionados en el ListBox (o ListView)
            foreach (var item in elegirColaboradoresProyecto.SelectedItems)
            {
                // Hacemos un cast al tipo Colaborador, que es el tipo de los elementos en el BindingList
                Colaborador colaborador = (Colaborador)item;

                // Añadimos el ValueMember (id) a la lista de seleccionados
                selectedIds.Add(colaborador.id);
            }
            return selectedIds;



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(projectName.Text))

            {
                Tools tools = new Tools();
                BindingList<Proyecto> proyectos = new BindingList<Proyecto>(tools.ObtenerProyectos());
                Proyecto proyectoUltimo = proyectos.Last();
                List<int> selectedIds = obtenerIdColaboradores();
                Proyecto proyecto = new Proyecto(projectName.Text, proyectoUltimo.id + 1, selectedIds);
                proyectos.Add(proyecto);

                tools.agregarObjeto(proyecto, "Proyectos");
                foreach (var proyectoW in proyectos)
                {
                    Console.WriteLine($"Nombre: {proyectoW.nombreProyecto}, ID: {proyectoW.id}, selectedIds: {selectedIds}");

                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void elegirColaboradoresProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
                                                                  // Crea una instancia del nuevo formulario
            this.Hide(); // Oculta el formulario actual
            form2.Show();
        }
    }
}