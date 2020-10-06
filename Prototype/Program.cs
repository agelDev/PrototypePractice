using System;
using Prototype.Menu;

namespace Prototype
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool seguir;

            do
            {
                Menu.Menu.MenuPrincipal();

                Console.Clear();

                Console.Write("Continuar? (S) ");
                string opcion = Console.ReadLine();

                seguir = opcion.ToLower() == "s";

            } while (seguir);
        }
    }
}
