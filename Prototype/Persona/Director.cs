using System;
namespace Prototype.Persona
{
    public class Director : Persona
    {
        private static Director instancia;
        public string Especializacion { get; set; }

        private Director()
        {
        }

        public static Director GetInstancia()
        {
            return instancia ?? (instancia = new Director());
        }

        public void LlamarTutor(Tutor tutor)
        {
            Console.WriteLine($"Lamando a {tutor.Nombre} {tutor.Apellido}");
        }

        public override string ToString()
        {
            string msg = "DOCENTE\n\n";
            msg += base.ToString();
            msg += Especializacion + "\n";
            return msg;
        }
    }
}
