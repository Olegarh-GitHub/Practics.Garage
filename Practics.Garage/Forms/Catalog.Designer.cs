namespace Practics.Garage.Forms
{
    partial class CatalogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            this.manufacturerTabPage = new System.Windows.Forms.TabPage();
            this.manufacturerPicture = new System.Windows.Forms.Panel();
            this.catalogManufacturersPanel = new System.Windows.Forms.Panel();
            this.addManufacturerButton = new System.Windows.Forms.Button();
            this.manufacturer = new System.Windows.Forms.ComboBox();
            this.manufacturerOrderByLabel = new System.Windows.Forms.Label();
            this.catalogProductsTabPage = new System.Windows.Forms.TabPage();
            this.catalogPicture = new System.Windows.Forms.Panel();
            this.catalogProductsPanel = new System.Windows.Forms.Panel();
            this.addVehiclePartButton = new System.Windows.Forms.Button();
            this.buyVehiclePartButton = new System.Windows.Forms.Button();
            this.productsOrderByComboBox = new System.Windows.Forms.ComboBox();
            this.productsOrderByLabel = new System.Windows.Forms.Label();
            this.garageTabControl = new System.Windows.Forms.TabControl();
            this.manufacturerTabPage.SuspendLayout();
            this.catalogProductsTabPage.SuspendLayout();
            this.garageTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // manufacturerTabPage
            // 
            this.manufacturerTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.manufacturerTabPage.Controls.Add(this.manufacturerOrderByLabel);
            this.manufacturerTabPage.Controls.Add(this.manufacturer);
            this.manufacturerTabPage.Controls.Add(this.addManufacturerButton);
            this.manufacturerTabPage.Controls.Add(this.catalogManufacturersPanel);
            this.manufacturerTabPage.Controls.Add(this.manufacturerPicture);
            this.manufacturerTabPage.Location = new System.Drawing.Point(4, 24);
            this.manufacturerTabPage.Name = "manufacturerTabPage";
            this.manufacturerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manufacturerTabPage.Size = new System.Drawing.Size(752, 584);
            this.manufacturerTabPage.TabIndex = 2;
            this.manufacturerTabPage.Text = "Производители";
            // 
            // manufacturerPicture
            // 
            this.manufacturerPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manufacturerPicture.BackgroundImage")));
            this.manufacturerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manufacturerPicture.Location = new System.Drawing.Point(-20, -7);
            this.manufacturerPicture.Name = "manufacturerPicture";
            this.manufacturerPicture.Size = new System.Drawing.Size(776, 98);
            this.manufacturerPicture.TabIndex = 1;
            // 
            // catalogManufacturersPanel
            // 
            this.catalogManufacturersPanel.AutoScroll = true;
            this.catalogManufacturersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catalogManufacturersPanel.Location = new System.Drawing.Point(6, 97);
            this.catalogManufacturersPanel.Name = "catalogManufacturersPanel";
            this.catalogManufacturersPanel.Size = new System.Drawing.Size(565, 481);
            this.catalogManufacturersPanel.TabIndex = 2;
            // 
            // addManufacturerButton
            // 
            this.addManufacturerButton.Location = new System.Drawing.Point(577, 97);
            this.addManufacturerButton.Name = "addManufacturerButton";
            this.addManufacturerButton.Size = new System.Drawing.Size(169, 23);
            this.addManufacturerButton.TabIndex = 3;
            this.addManufacturerButton.Text = "Добавить производителя";
            this.addManufacturerButton.UseVisualStyleBackColor = true;
            this.addManufacturerButton.Click += new System.EventHandler(this.addManufacturerButton_Click);
            // 
            // manufacturer
            // 
            this.manufacturer.BackColor = System.Drawing.SystemColors.Control;
            this.manufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturer.FormattingEnabled = true;
            this.manufacturer.Location = new System.Drawing.Point(577, 555);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(169, 23);
            this.manufacturer.TabIndex = 5;
            // 
            // manufacturerOrderByLabel
            // 
            this.manufacturerOrderByLabel.AutoSize = true;
            this.manufacturerOrderByLabel.Location = new System.Drawing.Point(673, 540);
            this.manufacturerOrderByLabel.Name = "manufacturerOrderByLabel";
            this.manufacturerOrderByLabel.Size = new System.Drawing.Size(76, 15);
            this.manufacturerOrderByLabel.TabIndex = 6;
            this.manufacturerOrderByLabel.Text = "Сортировка:";
            // 
            // catalogProductsTabPage
            // 
            this.catalogProductsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.catalogProductsTabPage.Controls.Add(this.productsOrderByLabel);
            this.catalogProductsTabPage.Controls.Add(this.productsOrderByComboBox);
            this.catalogProductsTabPage.Controls.Add(this.buyVehiclePartButton);
            this.catalogProductsTabPage.Controls.Add(this.addVehiclePartButton);
            this.catalogProductsTabPage.Controls.Add(this.catalogProductsPanel);
            this.catalogProductsTabPage.Controls.Add(this.catalogPicture);
            this.catalogProductsTabPage.Location = new System.Drawing.Point(4, 24);
            this.catalogProductsTabPage.Name = "catalogProductsTabPage";
            this.catalogProductsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.catalogProductsTabPage.Size = new System.Drawing.Size(752, 584);
            this.catalogProductsTabPage.TabIndex = 0;
            this.catalogProductsTabPage.Text = "Каталог";
            // 
            // catalogPicture
            // 
            this.catalogPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("catalogPicture.BackgroundImage")));
            this.catalogPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.catalogPicture.Location = new System.Drawing.Point(-20, -7);
            this.catalogPicture.Name = "catalogPicture";
            this.catalogPicture.Size = new System.Drawing.Size(776, 98);
            this.catalogPicture.TabIndex = 1;
            // 
            // catalogProductsPanel
            // 
            this.catalogProductsPanel.AutoScroll = true;
            this.catalogProductsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catalogProductsPanel.Location = new System.Drawing.Point(6, 97);
            this.catalogProductsPanel.Name = "catalogProductsPanel";
            this.catalogProductsPanel.Size = new System.Drawing.Size(565, 481);
            this.catalogProductsPanel.TabIndex = 2;
            // 
            // addVehiclePartButton
            // 
            this.addVehiclePartButton.Location = new System.Drawing.Point(577, 97);
            this.addVehiclePartButton.Name = "addVehiclePartButton";
            this.addVehiclePartButton.Size = new System.Drawing.Size(169, 23);
            this.addVehiclePartButton.TabIndex = 3;
            this.addVehiclePartButton.Text = "Добавить товар";
            this.addVehiclePartButton.UseVisualStyleBackColor = true;
            this.addVehiclePartButton.Click += new System.EventHandler(this.addVehiclePartButton_Click);
            // 
            // buyVehiclePartButton
            // 
            this.buyVehiclePartButton.Location = new System.Drawing.Point(577, 126);
            this.buyVehiclePartButton.Name = "buyVehiclePartButton";
            this.buyVehiclePartButton.Size = new System.Drawing.Size(169, 23);
            this.buyVehiclePartButton.TabIndex = 4;
            this.buyVehiclePartButton.Text = "Приобрести товар";
            this.buyVehiclePartButton.UseVisualStyleBackColor = true;
            // 
            // productsOrderByComboBox
            // 
            this.productsOrderByComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.productsOrderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsOrderByComboBox.FormattingEnabled = true;
            this.productsOrderByComboBox.Location = new System.Drawing.Point(577, 555);
            this.productsOrderByComboBox.Name = "productsOrderByComboBox";
            this.productsOrderByComboBox.Size = new System.Drawing.Size(169, 23);
            this.productsOrderByComboBox.TabIndex = 5;
            // 
            // productsOrderByLabel
            // 
            this.productsOrderByLabel.AutoSize = true;
            this.productsOrderByLabel.Location = new System.Drawing.Point(670, 537);
            this.productsOrderByLabel.Name = "productsOrderByLabel";
            this.productsOrderByLabel.Size = new System.Drawing.Size(76, 15);
            this.productsOrderByLabel.TabIndex = 6;
            this.productsOrderByLabel.Text = "Сортировка:";
            // 
            // garageTabControl
            // 
            this.garageTabControl.Controls.Add(this.catalogProductsTabPage);
            this.garageTabControl.Controls.Add(this.manufacturerTabPage);
            this.garageTabControl.Location = new System.Drawing.Point(12, 12);
            this.garageTabControl.Name = "garageTabControl";
            this.garageTabControl.SelectedIndex = 0;
            this.garageTabControl.Size = new System.Drawing.Size(760, 612);
            this.garageTabControl.TabIndex = 0;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 636);
            this.Controls.Add(this.garageTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин автомобильных запасных частей на Ломжинской 14";
            this.manufacturerTabPage.ResumeLayout(false);
            this.manufacturerTabPage.PerformLayout();
            this.catalogProductsTabPage.ResumeLayout(false);
            this.catalogProductsTabPage.PerformLayout();
            this.garageTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage manufacturerTabPage;
        public System.Windows.Forms.Label manufacturerOrderByLabel;
        public System.Windows.Forms.ComboBox manufacturer;
        public System.Windows.Forms.Button addManufacturerButton;
        public System.Windows.Forms.Panel catalogManufacturersPanel;
        public System.Windows.Forms.Panel manufacturerPicture;
        public System.Windows.Forms.TabPage catalogProductsTabPage;
        public System.Windows.Forms.Label productsOrderByLabel;
        public System.Windows.Forms.ComboBox productsOrderByComboBox;
        public System.Windows.Forms.Button buyVehiclePartButton;
        public System.Windows.Forms.Button addVehiclePartButton;
        public System.Windows.Forms.Panel catalogProductsPanel;
        public System.Windows.Forms.Panel catalogPicture;
        public System.Windows.Forms.TabControl garageTabControl;
    }
}