using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio
{
    public class Tarea
    {
        private DateTime fechaInicio { get; set; }
        private DateTime fechaFinal { get; set; }
        private string nombreTarea {  get; set; }
        private List<Tarea> subtareas = new List<Tarea>();
        private List<String> nombreColaboradores { get; set; }

    }
}
