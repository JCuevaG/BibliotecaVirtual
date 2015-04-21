using AutoMapper;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Domain.Interfaces.Services;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Presentation.WebUI.Areas.Mantenimiento.Controllers
{
    public class LibroController : Controller
    {

        private readonly ILibroService _libroService;


        public LibroController(ILibroService _libroService)
        {
            this._libroService = _libroService;
        }

        // GET: Mantenimiento/Libro
        public ActionResult Index()
        {   
            var clienteViewModel = Mapper.Map<IEnumerable<Libro>, IEnumerable<LibroViewModel>>(_libroService.GetAll());
            return View(clienteViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LibroViewModel libroViewModel)
        {
            if (ModelState.IsValid)
            {
                var libroDomain = Mapper.Map<LibroViewModel, Libro>(libroViewModel);
                _libroService.Add(libroDomain);
                return RedirectToAction("Index");
            }
            return View(libroViewModel);
        }
    }
}