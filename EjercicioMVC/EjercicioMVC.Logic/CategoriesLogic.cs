using EjercicioMVC.Entities;
using EjercicioMVC.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetList()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public Categories Add(Categories category)
        {
            try
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                throw new NullReferenceException();

            }

            return category;
        }

        public Categories Delete(int idCategory)
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
                throw new DbUpdateException();

            }


            return category;

        }

        public Categories Update(int id, string name, string description, byte[] picture)
        {

            Categories categoryUpdate = null;

            try
            {

                categoryUpdate = context.Categories.Find(id);

                categoryUpdate.CategoryName = name;
                categoryUpdate.Description = description;
                categoryUpdate.Picture = picture;
                context.SaveChanges();
            }

            catch (NullReferenceException)
            {
                throw ;
            }

            return categoryUpdate;
        }


        public Categories Find(int id)
        {
            Categories category = null;

            try
            {
               category = context.Categories.Find(id);

            }
            catch (NullReferenceException ex) {

                throw;
            }

            return category;
        }





    }
}
