using BibliotecaVirtual.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Presentation.WebUI.Areas.Mantenimiento.Controllers
{
    public class CategoriaController : Controller
    {

        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService _categoriaService)
        {
            this._categoriaService = _categoriaService;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Mantenimiento/Categoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mantenimiento/Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mantenimiento/Categoria/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mantenimiento/Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mantenimiento/Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mantenimiento/Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mantenimiento/Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
