using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExceptions
{
    public class EjercicioExceptions
    {

        public static double divisionUno(int dividendo, int divisor)
        {
            
            double resultado = dividendo / divisor;                
           
            return resultado;
        }

        public static double divisionDos(string dividendo, string divisor)
        {
            int dividendoNum;
            int divisorNum;
            double resultado;

            if (int.TryParse (dividendo,out dividendoNum) &&
                int.TryParse(divisor, out divisorNum))
            {
                resultado = dividendoNum/divisorNum;

            }

            else {
                throw new FormatException();
            }

            if (divisorNum == 0)
            {
                throw new DivideByZeroException();
            }
               return resultado;
        }

    }
}
