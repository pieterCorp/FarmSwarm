using AutoMapper;
using FarmSwarm.Business.Dto;
using FarmSwarm.data.Entities;

namespace FarmSwarm.Business.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<SensorData, SensorDataDto>().ReverseMap();
            CreateMap<State, StateDto>().ReverseMap();
            CreateMap<Plant, PlantDto>().ReverseMap();
            CreateMap<GreenHouse, GreenHouseDto>().ReverseMap();
        }
    }
}
