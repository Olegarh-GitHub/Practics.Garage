using Practics.Garage.Domain.Models;
using Practics.Garage.Infrastructure.Repositories;
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
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void FillCatalog()
        {

        }

        private void addVehiclePartButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(new Product() { Name = "Пиво" });
            addForm.Show();
        }
    }
}