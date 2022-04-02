extern alias App;

using App::Practics.Garage.Application.Facades;
using Practics.Garage.Domain.Models;
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
    public partial class ManufacturerComboBoxControl : ComboBox
    {
        private readonly ManufacturerFacade _manufacturerFacade;

        public ManufacturerComboBoxControl(ManufacturerFacade manufacturerFacade, int width, int height)
        {
            _manufacturerFacade = manufacturerFacade;

            var manufacturers = _manufacturerFacade
                .Read()
                .Select(manufacturer => manufacturer.ToComboBoxItem())
                .ToList();

            Width = width;
            Height = height;
            DataSource = manufacturers;
            DropDownStyle = ComboBoxStyle.DropDownList;

            InitializeComponent();
        }

        public new Guid SelectedValue => SelectedItem is not null 
            ? (SelectedItem as ComboBoxItem).IdGuid 
            : Guid.Empty;
    }
}
