using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Models
{
    public class Manufacturer : Entity
    {
        [DisplayName("Наименование производителя")]
        public string Name { get; set; }

        [DisplayName("Описание производителя")]
        public string Description { get; set; }

        [DisplayName("Адрес, месторасположения производителя")]
        public string Address { get; set; }

        [ComplexProperty]
        public List<Product> Products { get; set; } = new ();
    }
}
