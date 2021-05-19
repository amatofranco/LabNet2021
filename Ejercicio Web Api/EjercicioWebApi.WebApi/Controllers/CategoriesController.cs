using EjercicioWebApi.Entities;
using EjercicioWebApi.Logic;
using EjercicioWebApi.Logic.Exceptions;
using EjercicioWebApi.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EjercicioWebApi.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers:"*", methods:"*")]

    public class CategoriesController : ApiController
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        // GET api/categories
        public IEnumerable<CategoriesModel> GetList()
        {

            List<CategoriesModel> categoriesModel = null;

            try
            {
                var categoriesList = categoriesLogic.GetList();

                categoriesModel = categoriesList.Select(c => new CategoriesModel
                {
                    CategoryId = c.CategoryID,
                    CategoryName = c.CategoryName,
                    CategoryDescription = c.Description
                }).ToList();
            }

            catch (Exception ex)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }

            return categoriesModel;
        }

        // GET api/categories/{id}
        public CategoriesModel Get(int id)
        {
            CategoriesModel categoriesModel = null;


            try
            {
                Categories category = categoriesLogic.Find(id);
                categoriesModel = new CategoriesModel
                {
                    CategoryId = category.CategoryID,
                    CategoryDescription = category.Description,
                    CategoryName = category.CategoryName

                };
            }

            catch (Exception ex)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }

            return categoriesModel;
        }

        // POST api/categories
        public HttpResponseMessage PostCategory(CategoriesModel category)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

            }

            try
            {
                Categories newCategory = new Categories
                {
                    CategoryName = category.CategoryName,
                    Description = category.CategoryDescription
                };

                categoriesLogic.Add(newCategory);
                return new HttpResponseMessage(HttpStatusCode.OK);

            }

            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            }

        }


        // PUT api/categories/{id}
        public HttpResponseMessage PutCategory(int id, CategoriesModel category)
        {

            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

            }

            try
            {
                Categories newCategory = new Categories
                {
                    CategoryName = category.CategoryName,
                    Description = category.CategoryDescription
                };

                categoriesLogic.Update(id, category.CategoryName, category.CategoryDescription, default);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            }
        }


        // DELETE api/categories/5
        public HttpResponseMessage DeleteCategory(int id)
        {
            try
            {
                categoriesLogic.Delete(id);
                return new HttpResponseMessage(HttpStatusCode.OK);


            }

            catch (DbUpdateException ex)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict);

            }

            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            }

        }


    }
}
