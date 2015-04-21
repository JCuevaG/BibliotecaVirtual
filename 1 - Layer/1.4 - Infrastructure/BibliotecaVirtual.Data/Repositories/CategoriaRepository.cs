using BibliotecaVirtual.Data.Context;
using BibliotecaVirtual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria,BibliotecaVirtualContext>
    {
        public CategoriaRepository(BibliotecaVirtualContext context) : base(context)
        {
        }
    }
}
