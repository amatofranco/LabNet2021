using EjercicioEF.Entities;
using EjercicioEF.Entities.Extensions;
using EjercicioEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.UI.Extensions

{
    public static class ListExtensions
    {
        public static void Print (this List <Categories> categories)    
        {
            Console.WriteLine("LISTA CATEGORIAS");

           foreach (Categories category in categories)
            {
                {
                    Console.WriteLine (category.GetCategory());
                }

            }
        }

        public static void Print(this List<Shippers> shippers)
        {
            Console.WriteLine("LISTA EXPEDIDORES");


            foreach (Shippers shipper in shippers)
            {
                {
                    Console.WriteLine(shipper.GetShipper());

                }

            }
        }
    }
}
