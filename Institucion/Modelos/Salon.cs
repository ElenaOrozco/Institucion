using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Modelos
{
    class Salon : IEnteInstituto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string CodigoInterno { get; set; }

        public string ConstruirLlaveSecreta(string NombreEnte)
        {
            return "SAL ON";
        }
    }
}
