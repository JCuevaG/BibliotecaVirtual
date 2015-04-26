using AutoMapper;
using BibliotecaVirtual.Domain.Entities;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Categoria;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Libro;
using BibliotecaVirtual.Presentation.WebUI.ViewModels.Prestamo;
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
            Mapper.CreateMap<Libro, LibroSearchViewModel>();
            Mapper.CreateMap<Prestamo, PrestamoViewModel>();
        }
    }
}