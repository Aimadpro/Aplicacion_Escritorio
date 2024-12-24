using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio
{
    public class Proyecto
    {
        public string nombreProyecto { get; set; }
        public int id { get; set; }
        public List<int> colaboradores { get; set; }
        public int imagenProyecto {  set; get; }  
        public List<Tarea> tareas { set; get; }
   
        public Proyecto(string nombreProyecto, int id, List<int> colaboradores, List<Tarea> tareas) {
            this.nombreProyecto= nombreProyecto;
            this.id = id;
            this.colaboradores = colaboradores;
            this.tareas = tareas;

        }

        
    }
}
