﻿using Practics.Garage.Domain.Models;
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

namespace Practics.Garage
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void FillCatalog()
        {
            var entityis = new Repository<Product>()
        }
    }
}