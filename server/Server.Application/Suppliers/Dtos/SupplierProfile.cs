using AutoMapper;
using Server.Domain.Entities;

namespace Server.Application.Suppliers.Dtos;
public class SupplierProfile: Profile
{
    public SupplierProfile()
    {
        CreateMap<Supplier, SupplierDto>()
            .ForMember(dest => dest.Expenses, opt => opt.MapFrom(src => src.Expenses));
    }
}

