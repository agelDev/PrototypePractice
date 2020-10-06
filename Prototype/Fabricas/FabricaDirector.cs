using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaDirector : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return Director.GetInstancia();
        }
    }
}
