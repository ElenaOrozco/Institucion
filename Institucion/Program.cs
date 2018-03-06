using Institucion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTIÓN DE INSTITUCIÓN");

            Persona[] lista = new Persona[3];

            lista[0] = new Alumno("Elena", "Orozco")
            {
                Id = 1,
                Edad = 23,
                NickName = "Elena1210",
                Telefono = "10186473",
                Email = "elena.orozcoch@gmail.com"
            };

            //alumno1.Id = 1;
            //alumno1.Nombre = "Juan Carlos";

            lista[1] = new Profesor()
            {
                Id = 1,
                Nombre = "Ares",
                Apellido = "Sanchez",
                Edad = 13,
                Telefono = "3678900",
                Catedra = "Matematicas"
            };

            lista[2] = new Profesor()
            {
                Id = 2,
                Nombre = "Ricardo",
                Apellido = "Sanchez",
                Edad = 13,
                Telefono = "3678900",
                Catedra = "Llanterologia"
            };


            //Muestra Error
            //Alumno2 = profesor1;

            //Persona a = profesor1;
            //Persona b = alumno1;

            //Es posible porque ambos los mostre como personas
           // a = b;




            //Una alumno si puede ser una persona pero no al contrario
            // persona1 = alumno1;

            Console.WriteLine(Persona.ContadorPersonas);
            Console.WriteLine("Resumenes");

            //Console.WriteLine(alumno1.ConstruirResumen());
            //Console.WriteLine(profesor1.ConstruirResumen());
            foreach(Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen());

                IEnteInstituto ente = p;

                ente.ConstruirLlaveSecreta("Hola");
            }
            Console.WriteLine("S T R U C T S");
            CursoStruct c = new CursoStruct(70);
            c.Curso = "101-B";

            var newC = new CursoStruct(30);
            newC.Curso = "564-A";

            var cursoFreak = c;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"curso c = {c.Curso}");
            Console.WriteLine($"curso freak = {cursoFreak.Curso}");

            Console.WriteLine($"curso freak = {cursoFreak.Curso}");

            Console.WriteLine("C L A S E S");
            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "101-B";

            var newC_class = new CursoClass(30);
            newC_class.Curso = "564-A";

            var cursoFreak_class = c_class;
            cursoFreak_class.Curso = "666-G";

            Console.WriteLine($"curso c = {c_class.Curso}");
            Console.WriteLine($"curso freak = {cursoFreak_class.Curso}");

            




            Console.ReadLine();
        }
    }
}
