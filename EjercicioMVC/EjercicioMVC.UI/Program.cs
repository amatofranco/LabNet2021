using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using EjercicioMVC.Entities;
using EjercicioMVC.Entities.Extensions;
using EjercicioMVC.Logic;
using EjercicioMVC.Logic.Exceptions;
using EjercicioMVC.UI.Extensions;

namespace EjercicioMVC.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Mostrar lista de categorias

            CategoriesLogic categoriesLogic = new CategoriesLogic();
            ShippersLogic shippersLogic = new ShippersLogic();
            string categoryName;
            string categoryDesc;
            int categoryId;
            int option;

     

            do
            {

                Menu.printMenu();

                int.TryParse(Console.ReadLine(), out option);


                switch (option)
                {
                    case 1: // Mostrar lista de categorias 

                        categoriesLogic.GetList().Print();
                        break;

                    case 2: // Mostrar lista de expedidores 

                        shippersLogic.GetList().Print();
                        break;

                    case 3: // insertar una categoria

                        try
                        {

                            Console.WriteLine("Ingrese nombre de categoria");
                            categoryName = Console.ReadLine();
                            Console.WriteLine("Ingrese descripcion");
                            categoryDesc = Console.ReadLine();

                            Categories category = new Categories
                            {
                                CategoryName = categoryName,
                                Description = categoryDesc,
                            };

                            categoriesLogic.Add(category);

                            Console.WriteLine($"Se agrego: {category.GetCategory()}");

                            categoriesLogic.GetList().Print();
                        } 
                        
                        catch (ArgumentException)
                        {
                            Console.WriteLine("No pudo agregarse el producto");
                            continue;
                        }

                        
                        break;


                    case 4: // Eliminar Categoria por Id

                        try
                        {
                            Console.WriteLine("Ingrese Id de categoria a eliminar");

                            int.TryParse(Console.ReadLine(), out categoryId);


                            Categories category = categoriesLogic.Delete(categoryId);

                            Console.WriteLine($"Se elimino: {category.GetCategory()}");

                            categoriesLogic.GetList().Print();
                        }



                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Error. El elemento seleccionado no existe");
                            continue;
                        }


                        catch (UpdateException)
                        {
                            Console.WriteLine("Error. El elemento seleccionado comparte informacion con otros datos");
                            continue;
                        }


                        break;

                    case 5: // Editar una categoria

                        try
                        {

                            Console.WriteLine("Ingrese Id de categoria a editar");

                            int.TryParse(Console.ReadLine(), out categoryId);

                            Console.WriteLine("Ingrese nuevo nombre de categoria");
                            categoryName = Console.ReadLine();
                            Console.WriteLine("Ingrese nueva descripcion");
                            categoryDesc = Console.ReadLine();

                            Categories category = categoriesLogic.Update(categoryId, categoryName, categoryDesc, default);

                            Console.WriteLine($"Se edito: {category.GetCategory()}");

                            categoriesLogic.GetList().Print();
                        }

                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Error. El elemento seleccionado no existe");
                            continue;
                        }


                        break;

                }

                Menu.clearMenu();

            } while (option != 6);
            
        }
    }
}
