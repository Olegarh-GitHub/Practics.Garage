using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Models
{
    public class Specification : Entity
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public SpecificationType Type { get; set; }
        public Guid IdProduct { get; set; }
        public Product Product { get; set; }
    }
}
