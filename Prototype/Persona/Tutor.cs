﻿using System;
namespace Prototype.Persona
{
    public class Tutor : Persona
    {

        public Tutor()
        {
        }

        public void IrReunion()
        {
            Console.WriteLine("Yendo a reunion");
        }

        public void BuscarNota()
        {
            Console.WriteLine("Buscando Nota");
        }

        public void ReunionDirector()
        {
            Console.WriteLine("Reuniendose con el director");
        }
    }
}
