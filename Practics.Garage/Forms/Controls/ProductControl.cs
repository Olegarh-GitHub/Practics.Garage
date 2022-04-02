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
    public partial class ProductControl : FlowLayoutPanel
    {
        private readonly Product _product;

        public ProductControl(Product product, int width)
        {
            _product = product;
            Width = width;
            AutoSize = true;

            InitializeComponent();

            FillProduct();
        }

        private void FillProduct()
        {
            var nameLabel = new Label()
            {
                Text = _product?.Name,
                Size = new Size(250, 25),
                MaximumSize = new Size(250, 0),
                AutoSize = true,
                Dock = DockStyle.Left
            };

            var costLabel = new Label()
            {
                Text = $"{_product?.Cost} руб.",
                Size = new Size(250, 25),
                MaximumSize = new Size(250, 0),
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

            Controls.Add(nameLabel);
            Controls.Add(costLabel);
            Controls.Add(descriptionLabel);
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
