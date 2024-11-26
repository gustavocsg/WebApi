using AutoMapper;
using WebApi.Application.DTOs;
using WebApi.Domain.Model;

namespace WebApi.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, opt => opt.MapFrom(src => src.name));
                //.ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.photo));
        }
    }
}
