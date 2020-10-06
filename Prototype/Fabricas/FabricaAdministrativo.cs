using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaAdministrativo : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return new Administrativo();
        }
    }
}
