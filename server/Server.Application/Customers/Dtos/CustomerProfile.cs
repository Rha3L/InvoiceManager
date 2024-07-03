using AutoMapper;
using Server.Domain.Entities;

namespace Server.Application.Customers.Dtos;
public class CustomerProfile: Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerDto>()
            .ForMember(dest => dest.Income, opt => opt.MapFrom(src => src.Income));
    }
}

