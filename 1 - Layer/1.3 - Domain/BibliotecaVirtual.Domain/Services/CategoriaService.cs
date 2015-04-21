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
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        public readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository _categoriaRepository)
            : base(_categoriaRepository)
        {
            this._categoriaRepository = _categoriaRepository;
        }
    }
}
