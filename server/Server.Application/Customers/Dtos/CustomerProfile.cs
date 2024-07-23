using AutoMapper;
using Server.Application.Customers.Commands.CreateCustomer;
using Server.Domain.Entities;

namespace Server.Application.Customers.Dtos;
public class CustomerProfile: Profile
{
    public CustomerProfile()
    {
        CreateMap<CreateCustomerCommand, Customer>();
        
        CreateMap<Customer, CustomerDto>()
            .ForMember(dest => dest.Income, opt => opt.MapFrom(src => src.Income));
    }
}

