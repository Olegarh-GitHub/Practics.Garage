using AutoMapper;
using Practics.Garage.Domain.Models;


namespace Practics.Garage.Infrastructure.AutoMapping
{
    public class EntityMappingProfile : Profile
    {
        public EntityMappingProfile()
        {
            CreateMap<Manufacturer, Manufacturer>()
                .ForMember(dest => dest.IdGuid, opt => opt.Ignore());

            CreateMap<Product, Product>()
                .ForMember(dest => dest.IdGuid, opt => opt.Ignore());

            CreateMap<Specification, Specification>()
                .ForMember(dest => dest.IdGuid, opt => opt.Ignore());
        }
    }
}
