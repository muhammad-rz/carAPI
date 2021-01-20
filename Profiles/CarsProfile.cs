using carApi.Models;
using carApi.Dtos;
using AutoMapper;

namespace carApi.Profiles
{
    public class CarsProfile : Profile
    {
        public CarsProfile()
        {
            CreateMap<Car, CarReadDto>();
            CreateMap<CarCreateDto, Car>();
            CreateMap<CarUpdateDto, Car>();
        }
    }
}