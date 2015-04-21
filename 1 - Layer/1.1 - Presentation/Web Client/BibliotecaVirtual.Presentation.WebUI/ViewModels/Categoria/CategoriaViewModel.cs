using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.ViewModels.Categoria
{
    public class CategoriaViewModel
    {        
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}