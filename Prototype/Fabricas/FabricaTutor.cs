using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaTutor : IFabricaPersonas<Tutor>
    {
        public Tutor CrearPersona()
        {
            return new Tutor();
        }
    }
}
