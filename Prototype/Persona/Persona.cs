using System;
namespace Prototype.Persona
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaNac { get; set; }
        public Domicilio Domicilio { get; set; }

        protected string telefono;

        public string Telefono
        {
            get { return telefono; }

            set
            {
                if (value.Length == 10)
                    telefono = value;
            }
        }
    }
}
