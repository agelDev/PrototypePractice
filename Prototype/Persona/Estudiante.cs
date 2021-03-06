﻿using System;
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
            return Clone("");
        }

        public object Clone(string addon)
        {
            Estudiante newClone;

            newClone = (Estudiante)MemberwiseClone();

            newClone.Nombre += " " + addon;
            newClone.Apellido += " " + addon;

            newClone.tutor = new Tutor();
            newClone.tutor.Nombre = tutor.Nombre + " " + addon;
            newClone.tutor.Apellido = tutor.Apellido + " " + addon;
            newClone.tutor.Telefono = tutor.Telefono;
            newClone.tutor.FechaNac = new DateTime(tutor.FechaNac.Year, tutor.FechaNac.Month, tutor.FechaNac.Day);
            newClone.tutor.Domicilio = new Domicilio(Domicilio.Casa, Domicilio.Sector);

            newClone.FechaNac = new DateTime(FechaNac.Year, FechaNac.Month, FechaNac.Day);
            newClone.Domicilio = new Domicilio(Domicilio.Casa, Domicilio.Sector);
            newClone.Curso = new Curso(Grado);

            return newClone;
        }

        public override string ToString()
        {
            string msg = "ESTUDIANTE\n\n";
            msg += base.ToString();
            msg += Curso.ToString();
            msg += $"\nTutor: \nNombre: {tutor.Nombre}  Telefono: {Convert.ToString(tutor.Telefono)}\n";
            return msg;
        }
    }
}
