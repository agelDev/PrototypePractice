using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaEstudiante : IFabricaPersonas
    {
        public Persona.Persona CrearPersona()
        {
            return new Estudiante();
        }
    }
}
