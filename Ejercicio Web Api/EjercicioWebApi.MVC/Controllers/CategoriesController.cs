using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioWebApi.Logic;
using EjercicioWebApi.Entities;
using EjercicioWebApi.MVC.Models;
using EjercicioWebApi.Logic.Exceptions;

namespace EjercicioWebApi.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        // GET: Categories
        public ActionResult Index()
        {
            List<CategoriesView> categoriesView = null;

            try
            {
                var categoriesList = categoriesLogic.GetList();

                categoriesView = categoriesList.Select(c => new CategoriesView
                {
                    CategoryId = c.CategoryID,
                    CategoryName = c.CategoryName,
                    CategoryDescription = c.Description
                }).ToList();
            }

            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");

            }


            return View(categoriesView);
        }



        public ActionResult InsertUpdate(int? id)
        {

            CategoriesView categoriesView = null;

            if (id != null)
            {
                try
                {
                    Categories category = categoriesLogic.Find((int)id);

                    categoriesView = new CategoriesView
                    {

                        CategoryId = category.CategoryID,
                        CategoryDescription = category.Description,
                        CategoryName = category.CategoryName
                    };
                }

                catch (Exception ex)
                {
                    return RedirectToAction("Index", "Error");

                }
            }


            return View(categoriesView);
        }

        [HttpPost]

        public ActionResult InsertUpdate(CategoriesView categoriesView)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            try
            {
       
                if (categoriesView.CategoryId == null)
                {

                    Categories category = new Categories
                    {
                        CategoryName = categoriesView.CategoryName,
                        Description = categoriesView.CategoryDescription
                    };

                    categoriesLogic.Add(category);
                }

                else
                {
                    categoriesLogic.Update((int)categoriesView.CategoryId, categoriesView.CategoryName, categoriesView.CategoryDescription, default);

                }

                return RedirectToAction("Index");

            }

            catch (Exception ex)
            {
                return RedirectToAction("InsertUpdate", "Error");

            }

        }


        [HttpGet]

        public ActionResult Delete(int id)
        {

            try
            {

                Categories category = categoriesLogic.Delete(id);
                return RedirectToAction("Index");

            }

            catch (DbUpdateException ex)
            {
                return RedirectToAction("Delete", "Error");

            }

            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");

            }

        }
    }
}