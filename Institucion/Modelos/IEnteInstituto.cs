using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Modelos
{
    interface IEnteInstituto
    {
        //La interfaz no tiene implementacion de nada clase abstrasta es interfaz, clase padre es interfaz
        //Las nterfaces no tienen modificadores de acceso porque por default son publicas
        //La herencia multiple en c# No Existe 
        string CodigoInterno { get; set; }

        string ConstruirLlaveSecreta(string NombreEnte);
    }
}
