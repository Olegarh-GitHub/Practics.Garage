using Practics.Garage.Domain.Models;
using System.Windows.Forms;

namespace Practics.Garage.Forms.Controls
{
    public class CreateSpecificationControl : FlowLayoutPanel
    {
        private InputControl _name;
        private InputControl _value;
        public CreateSpecificationControl()
        {
            Width = 300;
            _name = new InputControl("Спецификация");
            _value = new InputControl("Значение");
            Controls.Add(_name);
            Controls.Add(_value);
        }

        public Specification GetSpecification()
        {
            return new Specification()
            {
                Name = _name.Text ?? "",
                Value = _value.Text ?? "",
                Type = GetSpecificationType()
            };
        }

        private SpecificationType GetSpecificationType()
        {
            return int.TryParse(_value.GetData(), out _) 
                ? SpecificationType.Number 
                : SpecificationType.String; 
        }
    }
}
