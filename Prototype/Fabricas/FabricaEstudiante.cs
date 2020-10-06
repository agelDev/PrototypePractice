using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaEstudiante : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return RecopilarDatos(new Estudiante());
        }

        public Persona.Persona RecopilarDatos(Persona.Persona persona)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Fecha de Nacimiento");
            Console.Write("Dia (xx): ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes (xx): ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Año (xxxx): ");
            int agno = int.Parse(Console.ReadLine());

            DateTime nac = new DateTime(agno, mes, dia);

            Console.WriteLine("Domicilio");
            Console.Write("Sector: ");
            string sector = Console.ReadLine();
            Console.Write("Casa: ");
            string casa = Console.ReadLine();

            Domicilio domicilio = new Domicilio(sector, casa);

            Console.WriteLine("Grado");
            Console.WriteLine("1-2\n3-4\n5-6\n7-8\n9-10\n11-12");
            int nGrado = int.Parse(Console.ReadLine());

            Curso curso = new Curso(nGrado);

            FabricaTutor fabrica = new FabricaTutor();
            Tutor tutor = (Tutor) fabrica.CrearPersona();

            Estudiante p = (Estudiante)persona;
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.FechaNac = nac;
            p.Domicilio = domicilio;
            p.Curso = curso;
            p.Tutor = tutor;

            return p;
        }
    }
}
