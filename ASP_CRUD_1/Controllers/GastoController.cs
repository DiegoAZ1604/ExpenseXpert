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
    public class GastoController : Controller
    {
        // GET: Gasto
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                var gastosConCategorias = context.Gasto.Include("Categoria").OrderBy(x => x.Fecha).ToList();
                return View(gastosConCategorias);
            }
        }

        // GET: Gasto/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Gasto.Where(x => x.GastoID == id).FirstOrDefault());
            }
        }

        // GET: Gasto/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                var viewModel = new CreateGastoViewModel
                {
                    gasto = new Gasto(),
                    CategoriasLista = context.Categoria.Select(x => new SelectListItem
                    {
                        Value = SqlFunctions.StringConvert((double)x.CategoriaID).Trim(),
                        Text = x.Nombre
                    }).ToList()
                };
                return View(viewModel);
            }
        }

        // POST: Gasto/Create
        [HttpPost]
        public ActionResult Create(Gasto gasto)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    gasto.UsuarioID = 1;
                    context.Gasto.Add(gasto);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gasto/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Gasto.Where(x => x.GastoID == id).FirstOrDefault());
            }
        }

        // POST: Gasto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Gasto gasto)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(gasto).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gasto/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Gasto.Where(x => x.GastoID == id).FirstOrDefault());
            }
        }

        // POST: Gasto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Gasto gasto)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Gasto gastoToDelete = context.Gasto.Where(x => x.GastoID == id).FirstOrDefault();
                    context.Gasto.Remove(gastoToDelete);
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
