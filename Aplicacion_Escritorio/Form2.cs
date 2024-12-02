using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aplicacion_Escritorio
{
    public partial class Form2 : Form
    {
        List<Proyecto> proyectos= new List<Proyecto>();
        List<Colaborador> colaboradores;
        public Form2()  
        {
            InitializeComponent();
            textoInicio.Font = new Font(textoInicio.Font, FontStyle.Bold);
            textoInicio.ForeColor = Color.LightBlue;
            textoProyecto.ForeColor = Color.White;
            mostrarProyectos();


        }
        private void mostrarProyectos()
        {
            Tools tools = new Tools();
            proyectos = tools.ObtenerProyectos();
            colaboradores = tools.ObtenerColaboradores();

            cuadroProyectos.DataSource = proyectos;
            cuadroProyectos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombreProyecto",
                HeaderText = "Nombre del Proyecto",
                Name = "nombreProyecto"
            });

            // Columna para los colaboradores
            cuadroProyectos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Colaboradores",
                Name = "colaboradores"
            });

            cuadroProyectos.CellFormatting += cuadroProyectos_CellFormatting;
        }
        private void cuadroProyectos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificamos si la columna es la de los colaboradores (por ejemplo, "Colaboradores")
            if (cuadroProyectos.Columns[e.ColumnIndex].Name == "colaboradores")
            {
                // Obtenemos el proyecto correspondiente a la fila actual
                Proyecto proyecto = (Proyecto)cuadroProyectos.Rows[e.RowIndex].DataBoundItem;

                // Obtenemos los IDs de los colaboradores
                List<int> colaboradoresIds = proyecto.colaboradores;

                // Buscamos los nombres de los colaboradores en la lista de colaboradores
                List<string> nombresColaboradores = new List<string>();
                foreach (int id in colaboradoresIds)
                {
                    // Buscamos el colaborador correspondiente al ID
                    Colaborador colaborador = colaboradores.FirstOrDefault(c => c.id == id);
                    if (colaborador != null)
                    {
                        nombresColaboradores.Add(colaborador.nombre);
                    }
                }

                // Asignamos los nombres de los colaboradores (se separan por coma)
                e.Value = string.Join(", ", nombresColaboradores);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void roundedTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            FormNewProject formProject = new FormNewProject();
            formProject.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
                                                                  // Crea una instancia del nuevo formulario
            this.Hide(); // Oculta el formulario actual
            formProject.Show();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            creacion_usuario newForm = new creacion_usuario();
            newForm.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
                                                                  // Crea una instancia del nuevo formulario
            this.Hide(); // Oculta el formulario actual
            newForm.Show();
        }
    }
}
