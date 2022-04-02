extern alias App;

using App::Practics.Garage.Application.Facades;
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
    public partial class ProductCatalogControl : FlowLayoutPanel
    {
        private readonly ProductFacade _productFacade;
        private readonly Control _parent;

        public ProductCatalogControl(ProductFacade productFacade, Control parent)
        {
            _productFacade = productFacade;
            _parent = parent;

            Dock = DockStyle.Fill;

            InitializeComponent();

            FillCatalog();
        }

        private void FillCatalog()
        {
            var products = _productFacade.Read();
            foreach (var product in products)
            {
                var productControl = new ProductControl(product, _parent.Width)
                {
                    Dock = DockStyle.Top,
                };

                Controls.Add(productControl);
            }
        }
    }
}
