using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Modelos
{
    class Alumno: Persona
    {
        //private solo desde la clase
        //protected desde las clases que hereden pero no de program
        //sealed sellada - ya no puede heredar

        public string Email { get; set; }
        public string NickName { get; set; }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string ListaInasistencias()
        {
            return Inasistencias.ToString();
        }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto}, {NickName}, {Telefono}";
        }

        public override string NombreCompleto
        {
            get
            {
                return base.NombreCompleto.ToUpper();
            }
        }
    }
}
