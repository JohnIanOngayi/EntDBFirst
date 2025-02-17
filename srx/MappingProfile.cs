using AutoMapper;
using srx.Entities.Dtos;
using srx.Entities.Models;

namespace srx;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Owner, OwnerDto>();
    }
}
