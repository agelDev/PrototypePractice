using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaTutor : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return new Tutor();
        }
    }
}
