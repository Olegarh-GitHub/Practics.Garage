﻿extern alias App;

using App::Practics.Garage.Application.Facades;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly ManufacturerFacade _manufacturerFacade;
        private readonly ProductFacade _productFacade;

        public CatalogForm()
        {
            _manufacturerFacade = Program.ServiceProvider.GetService<ManufacturerFacade>();
            _productFacade = Program.ServiceProvider.GetService<ProductFacade>();

            InitializeComponent();
        }

        private void FillCatalog()
        {

        }

        private void addVehiclePartButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm(this, _manufacturerFacade, _productFacade);
            addForm.Show();
            Enabled = false;
        }
    }
}