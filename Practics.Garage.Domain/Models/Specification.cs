using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Models
{
    public class Specification : Entity, IHaveNameEntity
    {
        [DisplayName("Наименование спецификации")]
        public string Name { get; set; }

        [DisplayName("Значение спецификации")]
        public string Value { get; set; }

        [DisplayName("Тип спецификации")]
        public SpecificationType Type { get; set; }
        public Guid IdProduct { get; set; }

        [ComplexProperty]
        public Product Product { get; set; }
    }
}
