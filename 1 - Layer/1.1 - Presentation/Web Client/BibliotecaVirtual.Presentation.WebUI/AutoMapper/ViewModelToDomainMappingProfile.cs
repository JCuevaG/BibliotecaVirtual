using AutoMapper;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Presentation.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaVirtual.Presentation.WebUI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Libro, LibroViewModel>();
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}