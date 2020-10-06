using System;
namespace Prototype.Persona
{
    public class Director : Persona
    {
        private Director instancia;
        public string Especializacion { get; set; }

        private Director()
        {
        }

        public Director GetInstancia()
        {
            return instancia ?? (instancia = new Director());
        }

        public void LlamarTutor(Tutor tutor)
        {
            Console.WriteLine($"Lamando a {tutor.Nombre} {tutor.Apellido}");
        }
    }
}
