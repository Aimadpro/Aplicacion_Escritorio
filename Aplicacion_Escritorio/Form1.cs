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
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            pictureBox1.BackColor = this.BackColor; // Hace que el color de fondo sea el mismo que el del formulario

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(contrasenyaText.Text=="a" && usuarioText.Text == "a") {
                Form2 form2 = new Form2();
                form2.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
                                                                      // Crea una instancia del nuevo formulario
                this.Hide(); // Oculta el formulario actual
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña equivocados");
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
