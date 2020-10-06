using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaDocente : IFabricaPersonas<Docente>
    {
        public Docente CrearPersona()
        {
            return new Docente();
        }
    }
}
