using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Domain.Interfaces.Repositories;
using BibliotecaVirtual.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Domain.Services
{
    public class LibroService : ServiceBase<Libro>,ILibroService
    {
        private readonly ILibroRepository _libroRepository;

        public LibroService(ILibroRepository _libroRepository)
            : base(_libroRepository)
        {
            this._libroRepository = _libroRepository;
        }
    }
}
