using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Escritorio
{
    public partial class Subtarea : Form
    {
        public Tarea subtarea { get; set; }
        public Subtarea(List<Colaborador>colaboradoresAnadir)
        {
            InitializeComponent();
            listaColaboradoresSubTarea.DataSource = colaboradoresAnadir;
            listaColaboradoresSubTarea.DisplayMember = "Nombre";
            listaColaboradoresSubTarea.ValueMember = "id";
        }

        private void boton_add_subtarea_Click(object sender, EventArgs e)
        {
            loadTarea();
        }
        private void loadTarea()
        {

            List<Colaborador> colaboradoresSeleccionados = listaColaboradoresSubTarea.Items.Cast<Colaborador>().ToList();
            if (fechainicioSubtarea.Value == null ||
                fechafinalSubtarea.Value == null ||
                string.IsNullOrWhiteSpace(nombreSubTarea.Text) ||
                string.IsNullOrWhiteSpace(estadoSubTarea.Text) ||
                !colaboradoresSeleccionados.Any())
            {
                MessageBox.Show("Faltan valores en uno o más campos. Por favor, completa todos los campos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            else {
                subtarea = new Tarea(fechainicioSubtarea.Value, fechafinalSubtarea.Value, nombreSubTarea.Text, estadoSubTarea.Text, colaboradoresSeleccionados);
                MessageBox.Show("SubTarea añadida correctamente");
                this.Close();
            }
            
           
        }

        private void Subtarea_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nombreTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechainiciotarea_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fechafinaltarea_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void estadoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listaColaboradoresTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaSubtareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
