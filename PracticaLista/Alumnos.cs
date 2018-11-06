using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLista
{
    class Alumnos
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Carrera { get; set; }

        public Alumnos()
        {
            Nombre = " ";
            Matricula = "";
            Carrera = "";
        }

        public Alumnos( string nombre, string matricula, string carrera)
        {
            Nombre = nombre;
            Carrera = carrera;
            Matricula = matricula;
        }
    }
}
