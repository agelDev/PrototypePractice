using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public interface IFabricaPersonas
    {
        Persona.Persona CrearPersona();
        Persona.Persona RecopilarDatos(Persona.Persona persona);
    }
}
