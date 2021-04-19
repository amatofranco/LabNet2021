using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExceptions
{
    public class Logic
    {
        public static void ThrowException()
        {
            throw new InvalidOperationException("Se disparo una Excepcion");
            
        }

        public static void ThrowCustomException()
        {
            throw new CustomException("Se disparo una Excepcion");
        }
    }
}
