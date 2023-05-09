using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public class Docente : Persona
    {
        public int DocenteId { get; set; }
        public int Antigüedad { get; set; }

        public Docente() { }
        public Docente(int docenteId, string nombre, string apellido)
        {
            DocenteId = docenteId;
            Nombre = nombre;
            Apellido = apellido;

        }
    }
}
