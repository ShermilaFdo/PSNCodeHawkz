using AutoMapper;
using SimpleCodingChallenge.Common.DTO;
using SimpleCodingChallenge.DataAccess.Entity;

namespace SimpleCodingChallenge.Business.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ReverseMap();
        }
    }
}
