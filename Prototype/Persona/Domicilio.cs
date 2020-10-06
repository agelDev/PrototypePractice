using System;
namespace Prototype.Persona
{
    public class Domicilio
    {
        public string Casa { get; set; }
        public string Sector { get; set; }

        public Domicilio(string casa, string sector)
        {
            Casa = casa;
            Sector = sector;
        }

        public override string ToString()
        {
            return $"{Casa}, {Sector}";
        }
    }
}
