using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public class FabricaEstudiante : IFabricaPersonas<Estudiante>
    {
        public Estudiante CrearPersona()
        {
            return new Estudiante();
        }
    }
}
