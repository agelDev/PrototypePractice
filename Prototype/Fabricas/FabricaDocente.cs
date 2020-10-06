using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaDocente : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return new Docente();
        }
    }
}
