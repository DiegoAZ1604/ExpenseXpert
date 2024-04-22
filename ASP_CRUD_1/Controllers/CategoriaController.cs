using ASP_CRUD_1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_CRUD_1.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            using (DbModels context = new DbModels()) 
            {
                return View(context.Categoria.ToList());
            }
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Categoria.Where(x => x.CategoriaID == id).FirstOrDefault());
            }
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Categoria.Add(categoria);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Categoria.Where(x => x.CategoriaID == id).FirstOrDefault());
            }
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Categoria categoria)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(categoria).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Categoria.Where(x => x.CategoriaID == id).FirstOrDefault());
            }
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Categoria categoria)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Categoria categoriaToDelete = context.Categoria.Where(x => x.CategoriaID == id).FirstOrDefault();
                    context.Categoria.Remove(categoriaToDelete);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
