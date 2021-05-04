using EjercicioLINQ.Extensions;
using EjercicioLINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ProductsLogic productsLogic = new ProductsLogic();

            CustomersLogic customersLogic = new CustomersLogic();

            Menu menu = new Menu();

            int option;


            do
            {

                menu.printMenu();

                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1:

                        // Devolver objeto customer

                        customersLogic.GetFirst().PrintCustomer();

                        break;

                    
                    case 2:

                        // Devolver productos Sin Stock

                        productsLogic.OutOfStock().PrintList();

                        break;

                   
                    case 3:

                        // Devolver productos Con Stock y Precio Mayor a 3

                        productsLogic.StockMayor().PrintList();


                        break;

                   
                    case 4:

                        //  Devolver todos los Customers de Washington
                        customersLogic.Region().PrintList();

                        break;



                    case 5:

                        //  Devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789

                        try
                        {
                            productsLogic.FirstOrDefault().PrintProduct();
                        }

                        catch (NullReferenceException ex)
                        {

                            Console.WriteLine("Error. El producto seleccionado no existe");
                        }

                        break;


                    case 6:

                        // Devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.

                        customersLogic.CustomersName().PrintList();

                        break;


                    case 7:

                        // Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.

                        customersLogic.JoinCustomersOrders().PrintList();

                        break;

                    case 8:

                        // Devolver los primeros 3 Customers de Washington

                        customersLogic.WACustomers().PrintList();

                        break;

                    case 9:

                        // Devolver lista de productos ordenados por nombre

                        productsLogic.OrderByName().PrintList();

                        break;

                    case 10:

                        // Devolver lista de productos ordenados por unit in stock de mayor a menor.

                        productsLogic.OrderByUnitInStock().PrintList();

                        break;

                    case 11:

                        // Devolver las distintas categorías asociadas a los productos

                        productsLogic.ProductsCategories().PrintList();

                        break;

                    case 12:

                        // Devolver el primer elemento de una lista de productos

                        productsLogic.FirstElement().PrintProduct();

                        break;

                    case 13:
                        // Devolver los customer con la cantidad de ordenes asociadas

                        customersLogic.CustomerCantOrders().PrintList();

                        break;

                }

                Console.WriteLine("Presione  Para Continuar");

                Console.ReadKey();

                Console.Clear();

            }

            while (option != 14);


        }
    }
}
