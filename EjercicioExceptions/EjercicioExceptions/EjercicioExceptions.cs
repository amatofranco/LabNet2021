using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExceptions
{
    public class EjercicioExceptions
    {

        public static void divisionUno (int numero)
        {
            double resultado;

            try
            {

                resultado = numero/0;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Finalizo la operacion");
            } 
        }

        public static void divisionDos(string dividendo, string divisor)
        {
            int dividendoNum;
            int divisorNum;
            double resultado;

            try
            {

                dividendoNum = int.Parse(dividendo);
                divisorNum = int.Parse(divisor);
                resultado = dividendoNum / divisorNum;
                Console.WriteLine($"Resultado: {resultado}");
            }
           

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Seguro ingreso una letra o nada!");
            }
         
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Solo Chuck Norris puede dividir por 0!");
            }

            finally
            {
                Console.WriteLine("Finalizo la operacion");
            }

          

        }



    }
}
