using Application.Dto;
using AutoMapper;
using Entity;

namespace Mapper
{
    public class  MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Recuest, RecuestDto>().ReverseMap();
        }
    }
}
