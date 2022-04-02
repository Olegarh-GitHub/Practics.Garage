using Practics.Garage.Application.Facades.Base;
using Practics.Garage.Domain.Models;
using Practics.Garage.Domain.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Application.Facades
{
    public class ManufacturerFacade : EntityFacade<Manufacturer>
    {
        public ManufacturerFacade(IRepository<Manufacturer> repository) : base(repository){ }

        public async Task<Manufacturer> Create(string name, string description, string address)
        {
            var manufacturer = new Manufacturer()
            {
                Name = name,
                Description = description,
                Address = address
            };
            return await Create(manufacturer);
        }
    }
}
