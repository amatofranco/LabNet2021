using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExceptions
{
    public class CustomException : Exception
    {
        public override string Message
        {
            get
            {
                return $"Mensaje de la Custom Exception: {base.Message}";
            }
        }

        public CustomException(string mensaje) : base(mensaje)
        {


        }

    }
}
