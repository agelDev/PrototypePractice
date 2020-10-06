using System;
namespace Prototype.Persona
{
    public class Administrativo : Persona
    {
        public Administrativo()
        {
        }

        public void CobrarEstudiante(Estudiante e)
        {
            Console.WriteLine($"Dando por el cocote al estudiante {e.Nombre} {e.Apellido}");
        }

        public void PagarDocente(Docente d)
        {
            Console.WriteLine($"Dando una chiripa al maestro {d.Nombre} {d.Apellido}");
        }

        public void GEstionarProgramaEducativo()
        {
            Console.WriteLine("Viendo el programa...");
        }
    }
}
