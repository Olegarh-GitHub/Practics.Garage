using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }  
        public Guid IdManufacturer { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Specification> Specifications { get; set; } = new ();
    }
}
