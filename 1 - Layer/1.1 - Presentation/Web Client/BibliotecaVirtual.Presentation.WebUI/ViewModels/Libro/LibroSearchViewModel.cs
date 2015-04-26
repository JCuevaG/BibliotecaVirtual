using BibliotecaVirtual.Presentation.WebUI.ViewModels.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.ViewModels.Libro
{
    public class LibroSearchViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CategoriaViewModel Categoria { get; set; }
        public string NombreAutor { get; set; }
        public int Cantidad { get; set; }

    }
}