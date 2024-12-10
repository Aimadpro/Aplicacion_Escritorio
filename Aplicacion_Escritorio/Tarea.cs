using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio
{
    public class Tarea
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public string nombreTarea {  get; set; }
        public List<Tarea> subtareas = new List<Tarea>();
        public List<String> nombreColaboradores { get; set; }
        public string estadoTarea {  get; set; }

    }
}
