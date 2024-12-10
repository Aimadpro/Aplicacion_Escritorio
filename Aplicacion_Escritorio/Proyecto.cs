using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio
{
    public class Proyecto
    {
        public string nombreProyecto { get; set; }
        public int id { get; set; }
        public List<int> colaboradores { get; set; }
        public int imagenProyecto {  set; get; }
  
        
        
        public List<Tarea> tareas = new List<Tarea>();  
        public Proyecto(string nombreProyecto, int id, List<int> colaboradores ) {
            this.nombreProyecto= nombreProyecto;
            this.id = id;
            this.colaboradores = colaboradores;

        }

        
    }
}
