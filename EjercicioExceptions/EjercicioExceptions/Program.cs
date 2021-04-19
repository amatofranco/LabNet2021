using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            EjercicioExceptions.divisionUno(5);
            
            // Ejercicio 2
            EjercicioExceptions.divisionDos("1", "0");

            // Ejercicio 3

            try
            {
                Logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine ($"Tipo de excepcion {ex.GetType().Name}");
                Console.WriteLine(ex.Message);
            }

            // Ejercicio 4

            try
            {
                Logic.ThrowCustomException();
            }

            catch (Exception ex)
            {

                Console.WriteLine($"Tipo de excepcion {ex.GetType().Name}");
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();

        }
    }
}
