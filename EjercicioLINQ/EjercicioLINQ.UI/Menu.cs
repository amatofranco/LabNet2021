using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ
{
    public class Menu
    {
        public void printMenu()
        {
            Console.WriteLine("Ingresar numero de consulta:");
            Console.WriteLine("1 - Devolver objeto customer");
            Console.WriteLine("2 - Devolver productos Sin Stock");
            Console.WriteLine("3 - Devolver productos Con Stock y Precio Mayor a 3");
            Console.WriteLine("4-  Devolver todos los Customers de Washington");
            Console.WriteLine("5 - Devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine("6 - Devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine("7 - Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997");
            Console.WriteLine("8 - Devolver los primeros 3 Customers de Washington");
            Console.WriteLine("9 - Devolver lista de productos ordenados por nombre");
            Console.WriteLine("10 - Devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine("11 - Devolver las distintas categorías asociadas a los productos");
            Console.WriteLine("12 - Devolver el primer elemento de una lista de productos");
            Console.WriteLine("13 - Devolver los customer con la cantidad de ordenes asociadas");
            Console.WriteLine("14 - Salir");

        }
    }
}
