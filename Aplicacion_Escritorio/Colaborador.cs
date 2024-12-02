using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio
{
    public class Colaborador
    {
        public string nombre {  get; set; }
        public int id { get; set; }

        private List<Proyecto> proyectos { get; set; }
        private List<Tarea> tareas { get; set; }
       //private string claveAES { get; set; }
        private string contrasena { get; set; }
        

        public Colaborador(int id, string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
            this.id = id;   

        }
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetContrasena()
        {
            return contrasena;
        }

        public void SetContrasena(string contrasena)
        {
            this.contrasena = contrasena;
        }

        public List<Proyecto> GetProyectos()
        {
            return proyectos;
        }

        public void SetProyectos(List<Proyecto> proyectos)
        {
            this.proyectos = proyectos;
        }

        public List<Tarea> GetTareas()
        {
            return tareas;
        }

        public void SetTareas(List<Tarea> tareas)
        {
            this.tareas = tareas;
        }

        // Métodos para agregar proyectos y tareas
        public void AddTarea(Tarea tarea)
        {
            this.tareas.Add(tarea);
        }

        public void AddProyecto(Proyecto proyecto)
        {
            this.proyectos.Add(proyecto);
        }
    }

}

