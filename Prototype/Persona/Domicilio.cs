using System;
namespace Prototype.Persona
{
    public class Domicilio
    {
        private string Casa { get; set; };
        private string Sector { get; set; };

        public Domicilio(string casa, string secotr)
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
