using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.ViewModels
{
    public class LibroViewModel
    {   
      
        [Required(ErrorMessage="El Nombre es Requerido")]
        [MaxLength(50,ErrorMessage="Maximo {0} caracteres")]
        [MinLength(2,ErrorMessage="Minimo {0} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="Seleccione una Categoria")]
        public int CategoriaId { get; set; }
    }
}