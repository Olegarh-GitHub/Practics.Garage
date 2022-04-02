extern alias App;

using App::Practics.Garage.Application.Facades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practics.Garage.Forms
{
    public partial class AddManufacturer : Form
    {
        private readonly ManufacturerFacade _manufacturerFacade;
        private readonly Form _parent;

        public AddManufacturer(Form parent, ManufacturerFacade manufacturerFacade)
        {
            _manufacturerFacade = manufacturerFacade;
            _parent = parent;

            InitializeComponent();
        }
        private string GetName()
        {
            return nameTextBox.Text;
        }

        private string GetDescription()
        {
            return descriptionTextBox.Text;
        }

        private string GetAddress()
        {
            return addressTextBox.Text;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var name = GetName();
            var description = GetDescription();
            var address = GetAddress();

            await _manufacturerFacade.Create(name, description, address);

            Close();
            _parent.Enabled = true;
        }

        private void AddManufacturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Enabled = true;
        }
    }
}
