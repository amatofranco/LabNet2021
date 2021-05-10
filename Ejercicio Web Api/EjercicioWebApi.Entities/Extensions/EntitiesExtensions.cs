using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioWebApi.Entities.Extensions
{
    public static class EntitiesExtensions
    {
        public static string GetCategory(this Categories category)
        {
            return $"Id: {category.CategoryID}, Categoria: {category.CategoryName}, Descripcion: {category.Description}";

        }

        public static string GetShipper(this Shippers shipper)
        {
            return $"Id: {shipper.ShipperID}, Compañia: {shipper.CompanyName}, Telefono: {shipper.Phone}";

        }

    }
}
