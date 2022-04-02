using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Models
{
    public class Product : Entity, IHaveNameEntity
    {
        [DisplayName("Наименование товара")]
        public string Name { get; set; }

        [DisplayName("Описание товара")]
        public string Description { get; set; } 
        
        [DisplayName("Стоимость товара")]
        public decimal Cost { get; set; }

        public Guid IdManufacturer { get; set; }

        [ComplexProperty]
        public Manufacturer Manufacturer { get; set; }

        [ComplexProperty]
        public List<Specification> Specifications { get; set; } = new ();
    }
}
