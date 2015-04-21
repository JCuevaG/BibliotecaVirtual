using AutoMapper;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Domain.Interfaces.Services;
using BibliotecaVirtual.Presentation.WebUI.ViewModels;
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
    }
}