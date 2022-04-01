using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics.Garage.Forms
{
    public partial class AddForm : Form
    {
        public Entity Entity { get; set; }

        public AddForm(Entity entity)
        {         
            InitializeComponent();
            
            Entity = entity;
            GenerateCreateForm();
        }

        public void GenerateCreateForm()
        {
            var entityProperties = Entity
                .GetType()
                .GetProperties()
                .Where
                (
                    x => !x.CustomAttributes.Select(attribute => attribute.AttributeType).Contains(typeof(ComplexPropertyAttribute)) &&
                          x.CustomAttributes.Select(attribute => attribute.AttributeType).Contains(typeof(DisplayNameAttribute))
                );

            var position = (x: 5, y: 10);

            foreach (var property in entityProperties)
            {
                var value = property.GetValue(Entity);
                var displayNameAttribute = property.GetCustomAttributesData().FirstOrDefault(attribute => attribute.AttributeType == typeof(DisplayNameAttribute));
                var displayName = (string) displayNameAttribute.ConstructorArguments[0].Value;

                var label = EditorExtensions.GenerateLabelFor(displayName, new Point(position.x, position.y));

                position.y += 25;

                var textBox = EditorExtensions.GenerateEditorFor(property.Name, new Point(position.x, position.y));
      
                editorsPanel.Controls.Add(label);
                editorsPanel.Controls.Add(textBox);

                position.y += 50;
            }
        }

    }
}
