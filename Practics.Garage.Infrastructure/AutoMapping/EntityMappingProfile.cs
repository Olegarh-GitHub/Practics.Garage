using AutoMapper;
using Practics.Garage.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
