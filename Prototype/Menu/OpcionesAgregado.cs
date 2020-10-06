using System;
using Prototype.Fabricas;

namespace Prototype.Menu
{
    public partial class Menu
    {
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

            switch (opcion)
            {
                case "1":
                    Agregado.AgregadoEstudiante.Crear(new FabricaEstudiante());
                    break;
                case "2":
                    Agregado.AgregadoDocente.Crear(new FabricaDocente());
                    break;
                case "3":
                    Agregado.AgregadoDirector.Crear(new FabricaDirector());
                    break;
                case "4":
                    Agregado.AgregadoAdministrativo.Crear(new FabricaAdministrativo());
                    break;
                default:
                    return;
            }
        }
    }
}