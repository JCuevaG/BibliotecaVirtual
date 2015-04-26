using AutoMapper;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Domain.Interfaces.Services;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Libro;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Prestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Presentation.WebUI.Areas.Reserva.Controllers
{
    public class ReservarLibroController : Controller
    {
        private readonly ILibroService _libroService;
        private readonly IPrestamoService _prestamoService;
        public ReservarLibroController(ILibroService _libroService, IPrestamoService _prestamoService)
        {
            this._libroService = _libroService;
            this._prestamoService = _prestamoService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SerchLibro(string nombre = "")
        {
            var searchLibro = Mapper.Map<IEnumerable<Libro>, IEnumerable<LibroSearchViewModel>>(_libroService.Get().Where(x => x.Nombre.Contains(nombre)).AsEnumerable());
            return PartialView("Partial/_SearchLibro",searchLibro);
        }

        [HttpGet]
        public ActionResult PrestamoLibro(int Id)
        {
            PrestamoViewModel model = new PrestamoViewModel();
            model.LibroId = Id;
            model.Usuario = User.Identity.Name;
            return PartialView("Partial/_GestionarPrestamo", model);
        }

        [HttpPost]
        public ActionResult PrestamoLibro(PrestamoViewModel model)
        {
            String resultado = string.Empty;
            if (ModelState.IsValid)
            {
                var prestamoDomain = Mapper.Map<PrestamoViewModel, Prestamo>(model);
                _prestamoService.Add(prestamoDomain);

                LibroViewModel _libro = Mapper.Map<Libro, LibroViewModel>(_libroService.GetById(model.LibroId));
                _libro.Cantidad = _libro.Cantidad - 1;
                _libroService.Update(Mapper.Map<LibroViewModel, Libro>(_libro));
               
            }
            return Content("Se Registro Correctamente");
        }
    }
}