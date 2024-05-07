using AutoMapper;
using backend.Persistence.Dtos.User;
using backend.Persistence.Dtos.Company;
using backend.Persistence.Dtos.Job;
using backend.Entities;

namespace backend.Persistence.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            //Company
            CreateMap<CompanyCreateDto, Company>();
            CreateMap<Company, CompanyDto>();

            //Job
            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));

            //User
            CreateMap<UserCreateDto, User>();
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));
        }
    }
}
