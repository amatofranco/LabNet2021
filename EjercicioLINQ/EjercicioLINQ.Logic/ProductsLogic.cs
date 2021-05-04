using EjercicioLINQ.Entities;
using EjercicioLINQ.Entities.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.Logic
{
    public class ProductsLogic : BaseLogic, IListLogic<Products>
    {
        public List<Products> GetList()
        {
            return context.Products.ToList();
        }

        public List<Products> OutOfStock()
        {
            var query = context.Products.Where(x => x.UnitsInStock == 0);

            return query.ToList();

        }
        public List<Products> StockMayor()
         {
                var query = context.Products.Where(x => x.UnitsInStock>0 && x.UnitPrice > 3);

                return query.ToList();
         }

        public Products FirstOrDefault()
        {
            var query = context.Products.FirstOrDefault(x => x.ProductID == 789);

            return query;
        }

        public List <Products> OrderByName()
        {
            var query = from products in context.Products
                        orderby products.ProductName ascending
                        select products;

            return query.ToList();
        }

        public List<Products> OrderByUnitInStock()
        {
            var query = from products in context.Products
                        orderby products.UnitsInStock descending
                        select products;

            return query.ToList();
        }

        
        public List<ProductsCategories> ProductsCategories()
        {
            var query = from products in context.Products
                        join categories in context.Categories
                        on products.CategoryID equals categories.CategoryID

                        select new ProductsCategories
                        {
                            ProductId = products.ProductID,
                            ProductName = products.ProductName,
                            CategoryId = products.CategoryID,
                            CategoryName = categories.CategoryName
                        };

            return query.ToList();
        }
        

        public Products FirstElement()
        {
            var query = from products in context.Products
                        orderby products.UnitsInStock descending
                        select products;

            return query.First();
        }

    }

   
}
