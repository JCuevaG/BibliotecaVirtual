using AutoMapper;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Categoria;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LibroViewModel, Libro>();
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            
        }
        
    }
}