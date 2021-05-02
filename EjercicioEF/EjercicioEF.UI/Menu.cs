using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.UI
{
    public static class Menu
    {
        public static void printMenu ()
        {
            Console.WriteLine("SELECCIONE UNA OPCION:");
            Console.WriteLine("1 - Listar Categorias");
            Console.WriteLine("2 - Listar Expedidores");
            Console.WriteLine("3 - Agregar Categoria");
            Console.WriteLine("4 - Eliminar Categoria");
            Console.WriteLine("5 - Editar Categoria");
            Console.WriteLine("6 - Salir");


        }
        public static void clearMenu()
        {

            Console.WriteLine("Presione para continuar");

            Console.ReadKey();

            Console.Clear();
        }


    }
}
