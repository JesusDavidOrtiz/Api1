using Api1.DTOs;
using Api1.Entidades;
using AutoMapper;

namespace Api1.Utilidades
{
    public class AutoMapperProfiles :Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Productos, ProductosDTO>()
                .ReverseMap();
            CreateMap<ProductoAddDTO, Productos>();
            CreateMap<ProductoUpdateDTO, Productos>();
        }

    }
}
