extern alias App;

using App::Practics.Garage.Application.Facades;
using App::Practics.Garage.Application.Facades.Base;
using Practics.Garage.Domain.Models;
using Practics.Garage.Domain.Models.Base;
using Practics.Garage.Domain.Repository.Base;
using Practics.Garage.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics.Garage.Forms.Controls
{
    public partial class ComboBoxControl<TEntity> : ComboBox
        where TEntity : Entity, IHaveNameEntity
    {
        private readonly EntityFacade<TEntity> _entityFacade;

        public ComboBoxControl(EntityFacade<TEntity> entityFacade, int width, int height)
        {
            _entityFacade = entityFacade;

            var entities = _entityFacade
                .Read()
                .Select(entity => entity.ToComboBoxItem())
                .ToList();

            Width = width;
            Height = height;
            DataSource = entities;
            DropDownStyle = ComboBoxStyle.DropDownList;

            InitializeComponent();
        }

        public new Guid SelectedValue => SelectedItem is not null 
            ? (SelectedItem as ComboBoxItem).IdGuid 
            : Guid.Empty;
    }
}
