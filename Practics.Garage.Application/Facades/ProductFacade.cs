using Practics.Garage.Application.Facades.Base;
using Practics.Garage.Domain.Models;
using Practics.Garage.Domain.Repository.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practics.Garage.Application.Facades
{
    public class ProductFacade : EntityFacade<Product>
    {
        public ProductFacade(IRepository<Product> repository) : base(repository) { }
        public async Task<Product> Create(string name, string description, Guid IdManufacturer, List<Specification> specifications = null)
        {
            var product = new Product()
            {
                Name = name,
                Description = description,
                IdManufacturer = IdManufacturer,
                Specifications = specifications
            };
            return await Create(product);
        }
    }
}
