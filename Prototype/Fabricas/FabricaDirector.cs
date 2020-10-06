using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaDirector : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return Director.GetInstancia();
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

            Director p = (Director)persona;
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.FechaNac = nac;
            p.Domicilio = domicilio;

            return p;
        }
    }
}
