using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaAdministrativo : IFabricaPersonas<Administrativo>
    {
        public Administrativo CrearPersona()
        {
            return new Administrativo();
        }
    }
}
