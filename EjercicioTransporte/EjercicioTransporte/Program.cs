using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTransporte
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>{

                new Avion(100),
                new Avion(30),
                new Avion(10),
                new Avion(30),
                new Avion(20),

                new Automovil(4),
                new Automovil(2),
                new Automovil(4),
                new Automovil(3),
                new Automovil(4),


            };

            foreach (Transporte item in transportes)
            {
                Console.WriteLine(item.Descripcion());

            }

            Console.ReadKey();
        }
    }
}
