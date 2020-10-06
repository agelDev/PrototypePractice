using System;
namespace Prototype.Persona
{
    public class Curso
    {
        public string[] Asignaturas { get; set; }
        private readonly Grados gradoInicio;
        private Grados grado;

        public Curso(Grados grado)
        {
            gradoInicio = grado;
            this.grado = grado;
        }

        public Grados Grado
        {
            get { return grado; }
        }

        public void Promover()
        {
            if (grado < Grados.Egresado)
                grado++;
        }
    }

    public enum Grados
    {
        Primaria1,
        Primaria2,
        Primaria3,
        Primaria4,
        Primaria5,
        Primaria6,
        Secundaria1,
        Secundaria2,
        Secundaria3,
        Secundaria4,
        Secundaria5,
        Secundaria6,
        Egresado
    }
}
