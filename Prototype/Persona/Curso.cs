using System;
namespace Prototype.Persona
{
    public class Curso
    {
        public string[] Asignaturas { get; set; }
        private readonly Grados gradoInicio;
        private Grados grado;

        public Curso(int numero) : this((Grados)numero)
        {
            
        }

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

        public override string ToString()
        {
            string msg = "";

            switch (grado)
            {
                case Grados.Primaria1:
                    msg = "1ro Primaria";
                    break;
                case Grados.Primaria2:
                    msg = "2do Primaria";
                    break;
                case Grados.Primaria3:
                    msg = "3ro Primaria";
                    break;
                case Grados.Primaria4:
                    msg = "4to Primaria";
                    break;
                case Grados.Primaria5:
                    msg = "5to Primaria";
                    break;
                case Grados.Primaria6:
                    msg = "6to Primaria";
                    break;
                case Grados.Secundaria1:
                    msg = "1ro Secundaria";
                    break;
                case Grados.Secundaria2:
                    msg = "2do Secundaria";
                    break;
                case Grados.Secundaria3:
                    msg = "3ro Secundaria";
                    break;
                case Grados.Secundaria4:
                    msg = "4to Secundaria";
                    break;
                case Grados.Secundaria5:
                    msg = "5to Secundaria";
                    break;
                case Grados.Secundaria6:
                    msg = "6to Secundaria";
                    break;
                default:
                    msg = "Egresado";
                    break;
            }

            return msg;
        }
    }

    public enum Grados
    {
        Primaria1 = 1,
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
