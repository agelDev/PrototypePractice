using System;
using Prototype.Persona;
using Prototype.Fabricas;

namespace Prototype.Menu.Agregado
{
    public class AgregadoDocente
    {
        public static Docente Crear(IFabricaPersonas fabrica)
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

            Console.Write("Pago x Hora: ");
            double pagoHora = double.Parse(Console.ReadLine());

            Console.Write("Asignatura: ");
            string asignatura = Console.ReadLine();

            Docente p = (Docente)fabrica.CrearPersona();
            p.Nombre = nombre;
            p.Apellido = apellido;
            p.FechaNac = nac;
            p.Domicilio = domicilio;
            p.PagoHora = pagoHora;
            p.AsignaturaImpartida = asignatura;

            return p;

        }
    }
}
