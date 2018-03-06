using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Modelos
{
    public struct CursoStruct
    {
        const string NOMBRE_DEF_CURSO = "NO ASIGNADO";
        private string curso;

        public string Curso {
            get {return curso; }
            set { curso = value; }
           
        }
        //Estructura=> tipo valor Clase=> tipo referencia
        //readonly para variables de solo lectura
        public readonly short max_capacidad;

        public CursoStruct(short max_cap)
        {
            max_capacidad = max_cap;
            curso = NOMBRE_DEF_CURSO;
        }

    }
}
