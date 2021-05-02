using EjercicioEF.Entities;
using EjercicioEF.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetList()
        {
           return context.Categories.ToList();
        }

        

        public Categories Add (Categories category)
        {

            context.Categories.Add(category);
            context.SaveChanges();

            return category;
        }

        public Categories Delete (int idCategory)
        {
            Categories category = null;

            try
            {

                category = context.Categories.Find(idCategory);
                context.Categories.Remove(category);
                context.SaveChanges();
            }



            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                throw new UpdateException();

            }
           

            return category;

        }

        public Categories Update (int id, string name, string description, byte[] picture)
        {

            Categories categoryUpdate = context.Categories.Find(id);

            categoryUpdate.CategoryName = name;
            categoryUpdate.Description = description;
            categoryUpdate.Picture = picture;
            context.SaveChanges();

            return categoryUpdate;
        }
        
       
    }
}
