using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.ViewModels.Categoria
{
    public class CategoriaViewModel
    {
        [Required(ErrorMessage="Ingrese Descripción es Requerido")]
        [MaxLength(50,ErrorMessage="Maximo {0} caracteres")]
        [MinLength(2,ErrorMessage="Minimo {0} caracteres")]
        public string Descripcion { get; set; }
    }
}