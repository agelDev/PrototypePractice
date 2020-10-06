using System;
namespace Prototype.Persona
{
    public class Estudiante : Persona, ICloneable
    {
        public Curso Curso { get;  set; } = null;
        private Tutor tutor = null;
        public Tutor Tutor { set { tutor = value; } }

        public Estudiante()
        {
        }

        public string NombreTutor
        {
            get { return tutor.Nombre; }
        }

        public string ApellidoTutor
        {
            get { return tutor.Apellido; }
        }

        public Grados Grado
        {
            get { return Curso.Grado; }
        }

        public void Promover()
        {
            if (Curso != null)
                Curso.Promover();
        }

        public object Clone()
        {
            Estudiante newClone = new Estudiante();

            newClone = (Estudiante) MemberwiseClone();

            newClone.tutor = new Tutor();
            newClone.tutor.Nombre = tutor.Nombre;
            newClone.tutor.Apellido = tutor.Apellido;
            newClone.tutor.Telefono = tutor.Telefono;
            newClone.tutor.FechaNac = new DateTime(tutor.FechaNac.Year, tutor.FechaNac.Month, tutor.FechaNac.Day);
            newClone.tutor.Domicilio = new Domicilio(Domicilio.Casa, Domicilio.Sector);

            newClone.FechaNac = new DateTime(FechaNac.Year, FechaNac.Month, FechaNac.Day);
            newClone.Domicilio = new Domicilio(Domicilio.Casa, Domicilio.Sector);
            newClone.Curso = new Curso(Grado);
            
            return newClone;
        }
    }
}
