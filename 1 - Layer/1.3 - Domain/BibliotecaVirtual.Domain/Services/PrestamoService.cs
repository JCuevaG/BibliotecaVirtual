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
    public class PrestamoService : ServiceBase<Prestamo>, IPrestamoService
    {        
        private readonly IPrestamoRepository _prestamoRepository;
        public PrestamoService(IPrestamoRepository _prestamoRepository)
            : base(_prestamoRepository)
        {
            this._prestamoRepository = _prestamoRepository;
        }
    }
}
