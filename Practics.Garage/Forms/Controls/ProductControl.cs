using Practics.Garage.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics.Garage.Forms.Controls
{
    public partial class ProductControl : Panel
    {
        private readonly Product _product;
        private readonly FlowLayoutPanel _rightSide = new ();
        private readonly FlowLayoutPanel _leftSide = new ();

        public ProductControl(Product product, int width)
        {
            _product = product;
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

            FillProduct();
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

        private void FillProduct()
        {
            var nameLabel = new LinkLabel()
            {
                Text = _product?.Name,
                Size = new Size(250, 25),
                MaximumSize = new Size(250, 0),
                Font = new Font("Verdana", 8f, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Top                
            };

            nameLabel.Click += MainContainerClick;

            var costLabel = new Label()
            {
                Text = $"{_product?.Cost} руб.",
                Size = new Size(250, 25),
                MaximumSize = new Size(250, 0),
                Font = new Font("Verdana", 10f, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Top
            };

            var descriptionLabel = new Label()
            {
                Text = _product?.Description,
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
            MessageBox.Show($"{_product.Name}");
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
