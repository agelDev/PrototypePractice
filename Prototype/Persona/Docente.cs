using System;
namespace Prototype.Persona
{
    public class Docente : Persona
    {
        public double PagoHora { get; set; }
        public string AsignaturaImpartida { get; set; }

        public void DarClase()
        {
            Console.WriteLine($"Estoy dando mi clase de {AsignaturaImpartida}");
        }

        public void EnviarEstudianteDirector(Estudiante e)
        {
            Console.WriteLine($"El estudiante {e.Nombre} {e.Apellido} se porto mal\nA la oficina del Director !!!");
        }

        public override string ToString()
        {
            string msg = "DOCENTE\n\n";
            msg += base.ToString();
            msg += Convert.ToString(PagoHora) + "\n";
            msg += AsignaturaImpartida + "\n";
            return msg;
        }
    }
}
