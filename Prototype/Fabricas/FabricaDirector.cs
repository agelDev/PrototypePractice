using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaDirector : IFabricaPersonas<Director>
    {
        public Director CrearPersona()
        {
            return Director.GetInstancia();
        }
    }
}
