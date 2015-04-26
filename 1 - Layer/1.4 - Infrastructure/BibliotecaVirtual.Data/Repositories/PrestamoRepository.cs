using BibliotecaVirtual.Data.Context;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Data.Repositories
{
    public class PrestamoRepository : RepositoryBase<Prestamo, BibliotecaVirtualContext>, IPrestamoRepository
    {
        public PrestamoRepository(BibliotecaVirtualContext context)
            : base(context)
        {
        }
    }
}
