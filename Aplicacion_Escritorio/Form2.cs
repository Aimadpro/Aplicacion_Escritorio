using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion_Escritorio
{
    public partial class Form2 : Form
    {
        private static readonly string Key = "123456"; // 16 caracteres para AES-128
        Tools tools = new Tools();
        public static List<Proyecto> proyectos= new List<Proyecto>();
        public static  List<Colaborador> colaboradores;
        Boolean cargado = false;
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
                cargado = false;    
            

            cuadroProyectos.AutoGenerateColumns = false;
            cuadroProyectos.DataSource = proyectos;
            cuadroProyectos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nombreProyecto",
                HeaderText = "Nombre del Proyecto",
                Name = "nombreProyecto",
                Width = 150
            });

            // Columna para los colaboradores
            cuadroProyectos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Colaboradores",
                Name = "colaboradores",
                Width = 300 // Ajusta el ancho según tus necesidades

            });
            cuadroProyectos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tareas",
                Name = "tareas",
                Width = 300
            });
         

            cuadroProyectos.CellFormatting += cuadroProyectos_CellFormatting;
        }
        private void cuadroProyectos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || cuadroProyectos.Rows[e.RowIndex].DataBoundItem == null)
            {
                return; // Salimos si no hay datos
            }

            var fila = cuadroProyectos.Rows[e.RowIndex];
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
            // Tareas
            if (cuadroProyectos.Columns[e.ColumnIndex].Name == "tareas")
            {
                Proyecto proyecto = (Proyecto)cuadroProyectos.Rows[e.RowIndex].DataBoundItem;
                if (proyecto.tareas != null)
                {
                    List<string> nombresTareas = proyecto.tareas
                        .Select(t => t.nombreTarea)
                        .Where(nombre => !string.IsNullOrEmpty(nombre))
                        .ToList();

                    e.Value = string.Join(", ", nombresTareas);
                }
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            List<Proyecto> proyectosEliminar = new List<Proyecto>();
            foreach (DataGridViewRow row in cuadroProyectos.SelectedRows)
            {

                if (row.DataBoundItem is Proyecto proyecto)
                {
                    proyectosEliminar.Add(proyecto);
                }
            }

            foreach(var proyecto in proyectosEliminar)
            {
                proyectos.Remove(proyecto);

            }
            cuadroProyectos.DataSource = null;
            cuadroProyectos.DataSource = proyectos;
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Proyecto proyectoSeleccionado;  
            if (cuadroProyectos.SelectedRows.Count ==1)
            {
                // Obtener la primera fila seleccionada
                DataGridViewRow filaSeleccionada = cuadroProyectos.SelectedRows[0];

                // Obtener el objeto asociado a la fila (si está enlazada a datos)
                proyectoSeleccionado = filaSeleccionada.DataBoundItem as Proyecto;
                Modificar_proyecto newForm = new Modificar_proyecto(proyectoSeleccionado);
             
                newForm.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
                
                                                                        // Crea una instancia del nuevo formulario
                this.Hide(); // Oculta el formulario actual
                newForm.Show();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            saveJson();
            /* LOGIA PARA ENCRIPTAR JSON
           JObject parsedJson = tools.extraerJSON();
          string json= parsedJson.ToString();
                 EncryptJson(json); */
            MessageBox.Show("Se ha almacenado correctamente en el Json");
        }
        public static string EncryptJson(string json)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = new byte[16]; // Vector de inicialización (16 bytes en AES-128)

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var writer = new StreamWriter(cs))
                    {
                        writer.Write(json);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
        private void saveJson()
        {
            tools.actualizarArchivoJson(proyectos,"Proyectos");
            tools.actualizarArchivoJson(colaboradores, "Colaboradores");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
