using System;
namespace Prototype.Menu
{
    public partial class Menu
    {
        public static void OpcionesListado()
        {
            Console.Clear();
            string[] textoMenu = {
                "||| Opciones de Listado |||\n",
                "Elija una opcion:\n",
                "1) Todas las Personas",
                "2) Estudiantes",
                "3) Docentes",
                "4) Administrativos",
                "Cualquier Otra) Salir"
            };

            Console.WriteLine(EscribirArray(textoMenu));

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    ListarPersonas(ListaPersonas);
                    break;
                case "2":
                    ListarPersonas(ListaEstudiantes);
                    break;
                case "3":
                    ListarPersonas(ListaDocentes);
                    break;
                case "4":
                    ListarPersonas(ListaAdministrativos);
                    break;
                default:
                    return;
            }

            Console.WriteLine("\n\nEscribe cualquier tecla para continuar...");
            Console.ReadKey();

        }
    }
}
