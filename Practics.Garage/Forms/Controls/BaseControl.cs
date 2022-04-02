using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisplayNameAttribute = Practics.Garage.Domain.Models.Base.DisplayNameAttribute;

namespace Practics.Garage.Forms.Controls
{
    public partial class BaseControl<TEntity> : Panel 
        where TEntity : Entity, IHaveNameEntity
    {
        private readonly TEntity _entity;
        private readonly FlowLayoutPanel _rightSide = new();
        private readonly FlowLayoutPanel _leftSide = new();

        public BaseControl(TEntity product, int width)
        {
            _entity = product;
            Width = width;

            _leftSide.Dock = DockStyle.Fill;
            _leftSide.AutoSize = true;
            _leftSide.Padding = new Padding(10);
            _leftSide.WrapContents = false;
            _leftSide.FlowDirection = FlowDirection.TopDown;

            _rightSide.Dock = DockStyle.Right;
            _rightSide.AutoSize = true;
            _rightSide.Padding = new Padding(10);

            Paint += RenderBorders;
            Click += MainContainerClick;
            Padding = new Padding(10);

            InitializeComponent();

            Controls.Add(_rightSide);
            Controls.Add(_leftSide);

            FillPanelControl();
        }

        private void RenderBorders(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder
            (
                e.Graphics,
                ClientRectangle,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.DimGray, 1, ButtonBorderStyle.Solid,
                Color.DimGray, 1, ButtonBorderStyle.Solid
            );
        }

        private void FillPanelControl()
        {
            var entityProperties = _entity.GetType().GetProperties().Where
                (
                    x => !x.CustomAttributes.Select(attribute => attribute.AttributeType).Contains(typeof(ComplexPropertyAttribute)) &&
                          x.CustomAttributes.Select(attribute => attribute.AttributeType).Contains(typeof(DisplayNameAttribute))
                ).ToList();
            var nameLabel = new LinkLabel()
            {
                Text = entityProperties[0].GetValue(_entity).ToString(),
                Size = new Size(250, 25),
                MaximumSize = new Size(250, 0),
                Font = new Font("Verdana", 8f, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Top
            };

            nameLabel.Click += MainContainerClick;

            var costLabel = new Label()
            {
                Text = entityProperties[2].GetValue(_entity).ToString(),
                Size = new Size(250, 25),
                MaximumSize = new Size(250, 0),
                Font = new Font("Verdana", 10f, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Top
            };

            var descriptionLabel = new Label()
            {
                Text = entityProperties[1].GetValue(_entity).ToString(),
                Size = new Size(250, 250),
                MaximumSize = new Size(250, 0),
                AutoSize = true,
                Dock = DockStyle.Top
            };

            _leftSide.Controls.Add(nameLabel);
            _leftSide.Controls.Add(descriptionLabel);
            _rightSide.Controls.Add(costLabel);
        }

        private void MainContainerClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{_entity.Name}");
        }

        public TEntity GetItem()
        {
            return _entity;
        }
    }
}
