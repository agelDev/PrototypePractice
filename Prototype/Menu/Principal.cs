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
                "2) Listar",
                "3) Crear Archivos de Estudiantes",
                "Cualquier Otra) Salir\n"
            };
            
            Console.WriteLine(EscribirArray(textoMenu));

            string opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    OpcionesAgregado();
                    break;
                case "2":
                    OpcionesListado();
                    break;
                case "3":
                    List<Persona.Persona> copia1 = new List<Persona.Persona>();
                    List<Persona.Persona> copia2 = new List<Persona.Persona>();

                    ListaEstudiantes.ForEach(estudiante =>
                    {
                        Estudiante e = (Estudiante)estudiante;
                        copia1.Add((Persona.Persona)e.Clone("Copia 1"));
                        copia2.Add((Persona.Persona)e.Clone("Copia 2"));
                    });


                    Archivar(ListaEstudiantes, "Estudiantes.json");
                    Archivar(copia1, @"Estudiantes-Copia1.json");
                    Archivar(copia2, @"Estudiantes-Copia2.json");
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
            if (lista.Count < 1)
            {
                Console.WriteLine("No hay elementos en la lista");
                return;
            }

            foreach (Persona.Persona per in lista)
            {
                Console.WriteLine(per.ToString());
            }
        }
    }
}
