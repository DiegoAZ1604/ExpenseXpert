using ASP_CRUD_1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_CRUD_1.Controllers
{
    public class IngresoController : Controller
    {
        // GET: Ingreso
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                var ingresosConCategorias = context.Ingreso.Include("Categoria").OrderBy(x => x.Fecha).ToList();
                return View(ingresosConCategorias);
            }
        }

        // GET: Ingreso/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ingreso.Where(x => x.IngresoID == id).FirstOrDefault());
            }
        }

        // GET: Ingreso/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                var viewModel = new CreateIngresoViewModel
                {
                    ingreso = new Ingreso(),
                    CategoriasLista = context.Categoria.Select(x => new SelectListItem
                    {
                        Value = SqlFunctions.StringConvert((double)x.CategoriaID).Trim(),
                        Text = x.Nombre
                    }).ToList()
                };
                return View(viewModel);
            }
        }


        // POST: Ingreso/Create
        [HttpPost]
        public ActionResult Create(Ingreso ingreso)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    ingreso.UsuarioID = 1;
                    context.Ingreso.Add(ingreso);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Ingreso/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ingreso.Where(x => x.IngresoID == id).FirstOrDefault());
            }
        }

        // POST: Ingreso/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ingreso ingreso)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(ingreso).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingreso/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ingreso.Where(x => x.IngresoID == id).FirstOrDefault());
            }
        }

        // POST: Ingreso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Ingreso ingreso)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Ingreso ingresoToDelete = context.Ingreso.Where(x => x.IngresoID == id).FirstOrDefault();
                    context.Ingreso.Remove(ingresoToDelete);
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
