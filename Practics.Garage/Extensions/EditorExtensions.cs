using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics.Garage.Extensions
{
    public static class EditorExtensions
    {
        public static Label GenerateLabelFor(string labelText, Point position)
        {
            var label = new Label
            {
                Text = labelText,
                Size = new Size(250, 20),
                Location = position
            };
           
            return label;
        }

        public static TextBox GenerateEditorFor(string property, Point position)
        {
            var textBox = new TextBox
            {
                Text = property,
                Size = new Size(250, 50),
                Location = position
            };

            return textBox;
        }

        public static ComboBoxItem ToComboBoxItem<TEntity>(this TEntity entity) 
            where TEntity : Entity, IHaveNameEntity
        {
            var entityName = entity.Name;
            var entityIdGuid = entity.IdGuid;

            return new ComboBoxItem(entityIdGuid, entityName);
        }
    }
}
