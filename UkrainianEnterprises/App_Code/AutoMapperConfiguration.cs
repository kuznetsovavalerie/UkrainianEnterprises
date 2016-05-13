using AutoMapper;
using UkrainianEnterprises.Common.Entities;
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
            });

            _mapper = enterpriseConfig.CreateMapper();
        }
    }
}