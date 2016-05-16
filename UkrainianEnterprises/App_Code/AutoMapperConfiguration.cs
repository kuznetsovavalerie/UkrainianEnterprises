using AutoMapper;
using UkrainianEnterprises.Common.Entities;
using UkrainianEnterprises.Identity;
using UkrainianEnterprises.Models;

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
            });

            _mapper = enterpriseConfig.CreateMapper();
        }
    }
}