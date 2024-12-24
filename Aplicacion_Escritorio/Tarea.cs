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
        public string estadoTarea { get; set; }
        public List<Colaborador> colaboradores { get; set; }
        public List<Tarea> subTareas { get; set; }
        public Tarea()
        {
        }

        public Tarea(DateTime fechaInicio, DateTime fechaFinal, string nombreTarea, string estadoTarea, List<Colaborador> colaboradores)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.nombreTarea = nombreTarea;
            this.estadoTarea = estadoTarea;
            this.colaboradores = colaboradores;
            //this.nom
        }
        public Tarea(DateTime fechaInicio, DateTime fechaFinal, string nombreTarea, string estadoTarea, List<Colaborador> colaboradores, List<Tarea>subtareas)
        { 
            this.fechaInicio= fechaInicio;
            this.fechaFinal= fechaFinal;    
            this.nombreTarea= nombreTarea;
            this.estadoTarea= estadoTarea;
            this.colaboradores = colaboradores;
            this.subTareas = subtareas; 
            //this.nom
        }
       
    }
}
