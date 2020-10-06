using System;
using Prototype.Fabricas;
using Prototype.Persona;

namespace Prototype.Menu
{
    public partial class Menu
    {
        static IFabricaPersonas fabrica;
        public static void OpcionesAgregado()
        {
            Console.Clear();
            string[] textoMenu = {
                "||| Opciones de Agregado |||\n",
                "Elija una opcion:\n",
                "1) Estudiante",
                "2) Docente",
                "3) Director",
                "4) Administrativo",
                "Cualquier Otra) Salir"
            };

            Console.WriteLine(EscribirArray(textoMenu));

            string opcion = Console.ReadLine();

            Persona.Persona nuevaPersona;

            switch (opcion)
            {
                case "1":
                    fabrica = new FabricaEstudiante();
                    nuevaPersona = fabrica.CrearPersona();
                    ListaEstudiantes.Add(nuevaPersona);
                    break;
                case "2":
                    fabrica = new FabricaDocente();
                    nuevaPersona = fabrica.CrearPersona();
                    ListaDocentes.Add(nuevaPersona);
                    break;
                case "3":
                    fabrica = new FabricaDirector();
                    fabrica.CrearPersona();
                    return;
                case "4":
                    fabrica = new FabricaAdministrativo();
                    nuevaPersona = fabrica.CrearPersona();
                    ListaAdministrativos.Add(nuevaPersona);
                    break;
                default:
                    return;
            }

            ListaPersonas.Add(nuevaPersona);


        }
    }
}