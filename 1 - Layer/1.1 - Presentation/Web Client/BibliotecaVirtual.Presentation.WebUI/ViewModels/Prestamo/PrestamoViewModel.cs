using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.ViewModels.Prestamo
{
    public class PrestamoViewModel
    {
        public int LibroId { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }
    }
}