using System;
using Prototype.Fabricas;

namespace Prototype.Menu
{
    public partial class Menu
    {

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
    }
}
