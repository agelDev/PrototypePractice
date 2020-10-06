using System;
using Prototype.Fabricas;
using Prototype.Persona;
using System.Collections.Generic;

namespace Prototype.Menu
{
    public partial class Menu
    {
        private static List<Persona.Persona> ListaPersonas = new List<Persona.Persona>();
        private static List<Persona.Persona> ListaEstudiantes = new List<Persona.Persona>();
        private static List<Persona.Persona> ListaDocentes = new List<Persona.Persona>();
        private static List<Persona.Persona> ListaAdministrativos = new List<Persona.Persona>();

        public static void MenuPrincipal()
        {
            Console.Clear();
            string[] textoMenu = {
                "||| Bienvenido al Gestor de cuentas del Politecnico Tuplop |||\n",
                "Elija una opcion:\n",
                "1) Agregar",
                "Cualquier Otra) Salir\n"
            };
            
            Console.WriteLine(EscribirArray(textoMenu));

            string opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    OpcionesAgregado();
                    break;
                default:
                    return;
            }
        }

        static string EscribirArray(string[] textos)
        {
            string textoFinal = "";
            foreach (string texto in textos)
            {
                textoFinal += texto + "\n";
            }

            return textoFinal;
        }

        static void ListarPersonas(List<Persona.Persona> lista)
        {
            foreach (Persona.Persona per in lista)
            {
                Console.WriteLine(per.ToString());
            }
        }
    }
}
