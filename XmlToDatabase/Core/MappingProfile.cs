using AutoMapper;
using XmlToDatabase.Data.Models;

namespace XmlToDatabase.Core;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<OrderDto, Order>();
        CreateMap<ProductDto, Product>();
        CreateMap<UserDto, User>();
    }
}