using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion.Modelos
{
    //Abstract cuando defino un metodo sin su implementacion
    //Si tengo un metodo abstracto tambien la clase debe serlo

    //Virtual  a diferencia de abstract si tiene implementacion y puede ser modificada
    public abstract class Persona: IEnteInstituto
    {
        public static int ContadorPersonas = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Telefono { get; set; }
        protected int Inasistencias { get; set; }


        //Constructor estatico para que se llame 1 sola vez al crear el 1er obj
        //Constructor publico se llama cada que cree un obj persona 
        //ctor    Abreviscion de Contructor
        public Persona()
        {
            ContadorPersonas++;
            //ContadorPersonas +=1;
        }

        //Formatear codigo ctrl + k + d
        public virtual string NombreCompleto
        {
            get
            {
                //return string.Format("{0} {1}", Nombre, Apellido);
                //usando string literals
                return $"{Nombre} {Apellido}";

            }


        }

        public string CodigoInterno {
            get;
            set;
        }

        public abstract string ConstruirResumen();

        public string ConstruirLlaveSecreta(string NombreEnte)
        {
            var rnd = new Random();

            return rnd.Next(1, 9999945).ToString();
        }
    }
}