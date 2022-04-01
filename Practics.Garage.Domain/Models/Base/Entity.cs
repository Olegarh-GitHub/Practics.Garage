using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Domain.Models.Base
{
    public abstract class Entity
    {
        public Guid IdGuid { get; set; } = Guid.NewGuid();
        
        [DisplayName("Создан в: ")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DisplayName("Обновлен в: ")]
        public DateTime? UpdatedAt { get; set; }

        [DisplayName("Удален")]
        public bool Deleted { get; set; }
    }
}
