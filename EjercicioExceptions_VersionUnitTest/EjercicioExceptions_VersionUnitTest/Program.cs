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

            try
            {
                EjercicioExceptions.divisionUno(5, 0);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Finalizo la operacion");
                Console.WriteLine("**********************");


            }

            

            // Ejercicio 2

            try
            {
                double resultado = EjercicioExceptions.divisionDos("1", "0");
                Console.WriteLine($"Resultado: {resultado}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Seguro no ingreso nada o ingreso una letra");
                Console.WriteLine(ex.Message);

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris puede dividir por cero!");
                Console.WriteLine(ex.Message);   
            }

            finally
            {
                Console.WriteLine("Finalizo la operacion");
                Console.WriteLine("**********************");

            }
            // Ejercicio 3

            try
            {
                Logic.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tipo de excepcion {ex.GetType().Name}");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("**********************");


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
