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

        public override string ToString()
        {
            string msg = "";

            msg += $"Nombre: {Nombre}\n";
            msg += $"Apellido: {Apellido}\n";
            msg += $"Telefono: {Convert.ToString(Telefono)}\n";
            msg += $"Fecha de Nacimiento: {FechaNac.Day}/{FechaNac.Month}/{FechaNac.Year}\n";
            msg += $"Domicilio: #{Domicilio.Casa}, {Domicilio.Sector}\n";

            return msg;
        }
    }
}
