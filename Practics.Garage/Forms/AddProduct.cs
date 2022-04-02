extern alias App;

using Practics.Garage.Domain.Models;
using Practics.Garage.Forms.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

using System;
using App::Practics.Garage.Application.Facades;
using System.Linq;

namespace Practics.Garage.Forms
{
    public partial class AddProductForm : Form
    {
        private readonly ProductFacade _productFacade;
        private readonly ManufacturerFacade _manufacturerFacade;
        private ComboBoxControl<Manufacturer> _manufacturerComboBoxControl;
        private readonly Form _parent;
        public AddProductForm(Form parent, ManufacturerFacade manufacturerFacade, ProductFacade productFacade)
        {
            _parent = parent;

            _productFacade = productFacade;
            _manufacturerFacade = manufacturerFacade;
            _manufacturerComboBoxControl = new ComboBoxControl<Manufacturer>(manufacturerFacade, 358, 23);
            
            InitializeComponent();
            manufacturersPanel.Controls.Add(_manufacturerComboBoxControl);
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void addSpecificationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            specificationsPanel.Controls.Add(new CreateSpecificationControl());
        }

        private List<Specification> GetSpecifications()
        {

            var result = new List<Specification>();
            foreach(var specification in specificationsPanel.Controls)
            {
                result.Add((specification as CreateSpecificationControl).GetSpecification());
            }
            return result;
        }

        private string GetName()
        {
            return nameTextBox.Text;
        }

        private string GetDescription()
        {
            return descriptionTextBox.Text;
        }

        private decimal GetCost()
        {
            var tryParse = decimal.TryParse(costTextBox.Text, out var result);

            if (tryParse) return result;

            return 0m;
        }

        private Manufacturer GetManufacturer()
        {
            var idManufacturer = _manufacturerComboBoxControl.SelectedValue;

            return _manufacturerFacade
                .Read()
                .FirstOrDefault(x => x.IdGuid == idManufacturer);
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var specifications = GetSpecifications();
            var name = GetName();
            var description = GetDescription();
            var cost = GetCost();
            var manufacturer = GetManufacturer();

            await _productFacade.Create(name, description, cost, manufacturer.IdGuid, specifications);

            Close();
            _parent.Enabled = true;
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Enabled = true;
        }
    }
}
