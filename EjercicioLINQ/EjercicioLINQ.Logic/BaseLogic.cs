using EjercicioLINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.Logic
{
    public class BaseLogic

    {
        protected NorthwindContext context;


        public BaseLogic()
        {
            context = new NorthwindContext();

        }
    }
}
