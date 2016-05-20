using AutoMapper;
using UkrainianEnterprises.Common.Entities;
using UkrainianEnterprises.Identity;
using UkrainianEnterprises.Models;
using UkrainianEnterprises.Models.Employee;

namespace UkrainianEnterprises
{
    public static class AutoMapperConfiguration
    {
        private static IMapper _mapper;

        public static IMapper Mapper
        {
            get
            {
                return _mapper;
            }
        }

        public static void Init()
        {
            var enterpriseConfig = new MapperConfiguration(cfg => 
            {
                cfg.CreateMap<Enterprise, EnterpriseViewModel>();
                cfg.CreateMap<Location, LocationPreviewViewModel>();
                cfg.CreateMap<NewEnterpriseViewModel, Enterprise>();
                cfg.CreateMap<IdentityUser, User>().BeforeMap((s, d) => d.EmailConfirmed = false);
                cfg.CreateMap<User, IdentityUser>();
                cfg.CreateMap<RegisterViewModel, IdentityUser>();
                cfg.CreateMap<Employee, EmployeePreviewViewModel>()
                .ForMember(
                    dest => dest.FullName, 
                    opt => opt.MapFrom(src => string.Join(" ", src.FirstName, src.LastName)));
                cfg.CreateMap<Employee, EmployeeProfileViewModel>()
                .ForMember(
                    dest => dest.FullName, 
                    opt => opt.MapFrom(src => string.Join(" ", src.FirstName, src.Patronymic, src.LastName)));
                cfg.CreateMap<NewEmployeeViewModel, Employee>();
                cfg.CreateMap<NewPositionViewModel, Position>();
            });

            _mapper = enterpriseConfig.CreateMapper();
        }
    }
}