using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Forms.Controls
{
    public class ComboBoxItem
    {
        public Guid IdGuid { get; set; }
        public string DisplayValue { get; set; }

        public ComboBoxItem(Guid idGuid, string displayValue)
        {
            IdGuid = idGuid;
            DisplayValue = displayValue;
        }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}
