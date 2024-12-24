using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;
using System.IO;


namespace Aplicacion_Escritorio
{
    public partial class creacion_usuario : Form
    {
       
        Tools tools = new Tools();

        List<Colaborador> colaboradores = new List<Colaborador>();
        public creacion_usuario()
        {
            InitializeComponent();
            Tools tools = new Tools();
            colaboradores = Form2.colaboradores;
            mostrarListaUsuaros();
        }


        private void mostrarListaUsuaros()
        {
            listaUsuarios.DataSource = null;
            listaUsuarios.DataSource = colaboradores;
            listaUsuarios.DisplayMember = "nombre";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void creacion_usuario_Load(object sender, EventArgs e)
        {

        }

        private void contrasenyaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            if (String.IsNullOrWhiteSpace(usuariocreateText.Text) && String.IsNullOrWhiteSpace(contrasenyacreateText.Text))
            {

                MessageBox.Show("Introduce algún nombre de usuario");


            }
            else
            {
                if (contrasenyacreateText.Text == contrasenyaconfirmText.Text)
                {
                    saveUserData();
                }
                else
                {
                    MessageBox.Show("La validación de la contraseña no es correcta");

                }
            }

        }
        private void saveUserData()
        {
            //String claveAES = generarClaveAES();
            Colaborador ColaboradorFinal = colaboradores.Last();
            Colaborador colaborador = new Colaborador(ColaboradorFinal.id + 1, usuariocreateText.Text, contrasenyaconfirmText.Text);
            colaboradores.Add(colaborador);
            mostrarListaUsuaros();// Aquí accedes al atributo Nombre

            tools.actualizarArchivoJson(colaboradores, "Colaboradores");
            MessageBox.Show("Se ha creado el usuario correctamente");
            postCreation();


        }

        private void postCreation()
        {
            usuariocreateText.Text = "";
            contrasenyaconfirmText.Text = "";
            contrasenyacreateText.Text = "";
        }






        private String generarClaveAES()
        {
            Random random = new Random();
            int numAleatorioAES = random.Next(1, 99999999);
            int numAleatorioAES2 = random.Next(1, 99999999);
            String numAES = numAleatorioAES.ToString() + numAleatorioAES2.ToString();
            return numAES;
        }
        private void encriptar_contraseña(String clave)
        {
            byte[] key = Encoding.UTF8.GetBytes(clave);
            byte[] iv = new byte[16]; // Vector de inicialización de 16 bytes (por defecto ceros)
            //byte[] plainBytes = Encoding.UTF8.GetBytes(contrasenyaconfirmText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var encryptor = aes.CreateEncryptor())
                {
                    //byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    // return Convert.ToBase64String(encryptedBytes); // Devolver en base64
                }
            }



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario en la pantalla
            tools.actualizarArchivoJson(colaboradores, "Colaboradores");                           // Crea una instancia del nuevo formulario
            this.Hide(); // Oculta el formulario actual
            form2.Show();

        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {

            if (listaUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }
            string usuarioSeleccionado = listaUsuarios.SelectedItem.ToString();

            // Buscamos el colaborador correspondiente en la lista
            Colaborador colaboradorAEliminar = colaboradores.FirstOrDefault(c => c.nombre == usuarioSeleccionado);

            if (colaboradorAEliminar != null)
            {
                // Eliminamos el colaborador de la lista
                colaboradores.Remove(colaboradorAEliminar);

                // Actualizamos el ListBox
                listaUsuarios.Items.Remove(usuarioSeleccionado);

            }
        }
    }
}
    


