using System;
namespace Prototype.Persona
{
    public class Docente
    {
        public double PagoHora { get; set; }
        public string AsignaturaImpartida { get; set; }

        public Docente()
        {
        }

        public void DarClase()
        {
            Console.WriteLine($"Estoy dando mi clase de {AsignaturaImpartida}");
        }

        public void EnviarEstudianteDirector(Estudiante e)
        {
            Console.WriteLine($"El estudiante {e.Nombre} {e.Apellido} se porto mal\nA la oficina del Director !!!")
        }
    }
}
