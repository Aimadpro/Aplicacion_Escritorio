using System;
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
    public partial class crear_tarea : Form
    {
        public crear_tarea()
        {
            InitializeComponent();
            List<Colaborador> colaboradores = new List<Colaborador>();

            // Crear colaboradores con nombres y contraseñas específicas
            colaboradores.Add(new Colaborador(1,"JuanPerez", "Pass1234"));
            colaboradores.Add(new Colaborador(2,"MariaLopez", "SecurePass1"));
            colaboradores.Add(new Colaborador(3, "PedroGarcia", "MyPassword"));
            colaboradores.Add(new Colaborador(4,"AnaMartinez", "Ana2024"));
            colaboradores.Add(new Colaborador(5,"CarlosSanchez", "Carlos@123"));
            colaboradores.Add(new Colaborador(6,"LuciaFernandez", "LuciaPass"));
            colaboradores.Add(new Colaborador(7,"MiguelHernandez", "Miguel01"));
            colaboradores.Add(new Colaborador(8,"LauraGutierrez", "StrongP@ss"));
            colaboradores.Add(new Colaborador(9,"JavierDiaz", "Javi9876"));
            colaboradores.Add(new Colaborador(10,"SaraJimenez", "SaraSecure"));
            elegirColaboradoresTrea.Items.Clear();
            foreach (var colaborador in colaboradores)
            {
                // Crear un nuevo elemento con solo el nombre
                ListViewItem item = new ListViewItem(colaborador.GetNombre());
                elegirColaboradoresTrea.Items.Add(item); // Añadir el elemento al ListView
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
