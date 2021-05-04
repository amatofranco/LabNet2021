using EjercicioLINQ.Entities;
using EjercicioLINQ.Entities.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.Extensions
{
    public static class UIExtensions
    {

        public static void PrintProduct(this Products product)
        {

            Console.WriteLine($"Product Id: {product.ProductID}: Name: {product.ProductName} Units in stock: {product.UnitsInStock}");

        }

        public static void PrintList(this List<Products> list)
        {
            foreach (Products product in list)
            {
                PrintProduct(product);
            }

        }

        public static void PrintList(this List<Customers> list)
        {
            foreach (Customers customer in list)
            {
                Console.WriteLine($"Customer Id: {customer.CustomerID}: Company Name: {customer.CompanyName} Region: {customer.Region}");
            }

        }

        public static void PrintList(this List<CustomerOrders> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Customer Id: {item.CustomerId} Company Name: {item.CompanyName} Customer region: {item.CustomerRegion} Order ID: {item.OrderId} Order date: {item.OrderDate})");
            }
        }

        public static void PrintList(this List<string> listCustomers)
        {
            foreach (string customerName in listCustomers)
            {
                Console.WriteLine($"Customer name: {customerName.ToLower()}");
                Console.WriteLine($"Customer name: {customerName.ToUpper()}");

            }
        }

        public static void PrintList(this List<ProductsCategories> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Product Id: {item.ProductId} Product Name: {item.ProductName } Category Id : {item.CategoryId} Category Name: {item.CategoryName }");

            }
        }

        public static void PrintList(this List<CustomerCantOrders> list)
        {
                foreach (var item in list) 
            {
                Console.WriteLine($"CustomerID: {item.CustomerID} Company Name: {item.CompanyName} Orders: {item.CantOrders}");
            }
        }
    }
}
