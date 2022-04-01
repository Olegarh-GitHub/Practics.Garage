using Practics.Garage.Domain.Models;
using Practics.Garage.Forms.Controls;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Practics.Garage.Application.Facades;
using System;

namespace Practics.Garage.Forms
{
    public partial class AddProductForm : Form
    {
        private ProductFacade _productFacade;
        public AddProductForm()
        {
            InitializeComponent();
            
        }

        private void AddProductForm_Load(object sender, System.EventArgs e)
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

        private Manufacturer GetManufacturer()
        {
            throw new NotImplementedException();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var specifications = GetSpecifications();
            var name = GetName();
            var description = GetDescription();
            Manufacturer manufacturer = GetManufacturer();


            await _productFacade.Create(name, description, manufacturer.IdGuid, specifications);
        }
    }
}
