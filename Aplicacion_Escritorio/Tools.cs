using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Aplicacion_Escritorio
{
    public partial class Tools
    {
        public List<Colaborador> ObtenerColaboradores()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();



            // Parsear el JSON como un JObject
            JObject parsedJson = extraerJSON();

            // Extraer el array "Colaboradores"
            JArray colaboradoresArray = (JArray)parsedJson["Colaboradores"];
            // Convertir el array a una lista de objetos Colaborador
            colaboradores = colaboradoresArray.ToObject<List<Colaborador>>();
            return colaboradores;
        }
        public List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            // Parsear el JSON como un JObject
            JObject parsedJson = extraerJSON();
            // Extraer el array "Colaboradores"
            JArray proyectosArray = (JArray)parsedJson["Proyectos"];
            // Convertir el array a una lista de objetos Colaborador
            proyectos = proyectosArray.ToObject<List<Proyecto>>();
            return proyectos;
        }
        public JObject extraerJSON()
        {
            string jsonPath = "D:\\Aplicacion_Escritorio\\Aplicacion_Escritorio\\JSON\\intermodular.json";
            List<Colaborador> colaboradores = new List<Colaborador>();
            JObject parsedJson = new JObject();
            if (File.Exists(jsonPath))
            {
                string jsonContent = File.ReadAllText(jsonPath);

                // Parsear el JSON como un JObject
                parsedJson = JObject.Parse(jsonContent);

                return parsedJson;


            }
            else
            {

                Console.WriteLine("Archivo JSON no encontrado.");
                return parsedJson;

            }
        }
        public void agregarObjeto(Object os, string jsonName)
        {
            JObject parsedJson = extraerJSON();
            JArray colaboradoresArray = (JArray)parsedJson[jsonName];
            JObject nuevoColaborador = JObject.FromObject(os);
            colaboradoresArray.Add(nuevoColaborador);
           
            File.WriteAllText("D:\\Aplicacion_Escritorio\\Aplicacion_Escritorio\\JSON\\intermodular.json", parsedJson.ToString());


        }
        public void actualizarArchivoJson<T>(List<T> listaElementos, string nombreActualizable)
        {
            try
            {
                JObject jsonObject = extraerJSON(); // Carga el archivo JSON
                JArray listaElementosArray = JArray.FromObject(listaElementos); // Convierte la lista a JArray
                jsonObject[nombreActualizable] = listaElementosArray; // Actualiza la clave correspondiente en el JSON

                // Guarda el JSON actualizado en el archivo
                File.WriteAllText("D:\\Aplicacion_Escritorio\\Aplicacion_Escritorio\\JSON\\intermodular.json", jsonObject.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el archivo JSON: {ex.Message}");
            }
        }

    }
}
