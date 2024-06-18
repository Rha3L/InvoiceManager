using AutoMapper;
using backend.Persistence.Dtos.User;
using backend.Persistence.Dtos.Company;
using backend.Persistence.Dtos.Invoice;
using backend.Entities;

namespace backend.Persistence.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            //Company
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<Customer, CustomerDto>();

            //Job
            CreateMap<IncomeCreateDto, Income>();
            CreateMap<Income, IncomeDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));

            //User
            CreateMap<UserCreateDto, User>();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));
        }
    }
}
