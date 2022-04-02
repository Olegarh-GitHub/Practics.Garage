extern alias App;

using App::Practics.Garage.Application.Facades.Base;
using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Forms.Controls;
using System.Windows.Forms;

namespace Practics.Garage.Forms.Controls
{
    public partial class CatalogControl<TEntity, TControl> : FlowLayoutPanel 
        where TEntity : Entity, IHaveNameEntity 
        where TControl : Control
    {
        private readonly EntityFacade<TEntity> _TFacade;
        private readonly TControl _parent;

        public CatalogControl(EntityFacade<TEntity> productFacade, TControl parent)
        {
            _TFacade = productFacade;
            _parent = parent;

            Dock = DockStyle.Fill;

            InitializeComponent();

            FillCatalog();
        }

        private void FillCatalog()
        {
            var entities = _TFacade.Read();
            foreach (var entity in entities)
            {
                var productControl = new BaseControl<TEntity>(entity, _parent.Width)
                {
                    Dock = DockStyle.Top,
                };

                Controls.Add(productControl);
            }
        }
    }
}
