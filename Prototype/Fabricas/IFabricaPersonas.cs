using System;
using Prototype.Persona;

namespace Prototype.Fabricas
{
    public interface IFabricaPersonas<T> where T : Persona.Persona
    {
        T CrearPersona();
    }
}
