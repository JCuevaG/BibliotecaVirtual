using BibliotecaVirtual.Presentation.WebUI.ViewModels.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.ViewModels.Libro
{
    public class LibroViewModel
    {
        public string Nombre { get; set; }

        [Display(Name="Categoria")]
        public int CategoriaId { get; set; }
        public CategoriaViewModel Categoria { get; set; }
        [Display(Name = "Nombre del Autor")]
        public string NombreAutor { get; set; }
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
    }
}