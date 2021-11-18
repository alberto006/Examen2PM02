using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2PM02.Clases
{
    class Alumno
    {
        public string alumno_rne { get; set; }
        public string alumno_nombre1 { get; set; }
        public string alumno_nombre2 { get; set; }
        public string alumno_ape1 { get; set; }
        public string alumno_ape2 { get; set; }
        public string alumno_genero { get; set; }
        public string alumno_fnac { get; set; }

        public string grado_nombre { get; set; }

        public string nombreCompleto => $"{alumno_nombre1} {alumno_nombre2} {alumno_ape1} {alumno_ape2}";

    }
}
