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
            this.garageTabControl = new System.Windows.Forms.TabControl();
            this.catalogTabPage = new System.Windows.Forms.TabPage();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.buyVehiclePartButton = new System.Windows.Forms.Button();
            this.addVehiclePartButton = new System.Windows.Forms.Button();
            this.catalogPanel = new System.Windows.Forms.Panel();
            this.catalogPicture = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.garageTabControl.SuspendLayout();
            this.catalogTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // garageTabControl
            // 
            this.garageTabControl.Controls.Add(this.catalogTabPage);
            this.garageTabControl.Controls.Add(this.tabPage2);
            this.garageTabControl.Location = new System.Drawing.Point(12, 12);
            this.garageTabControl.Name = "garageTabControl";
            this.garageTabControl.SelectedIndex = 0;
            this.garageTabControl.Size = new System.Drawing.Size(760, 612);
            this.garageTabControl.TabIndex = 0;
            // 
            // catalogTabPage
            // 
            this.catalogTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.catalogTabPage.Controls.Add(this.orderByLabel);
            this.catalogTabPage.Controls.Add(this.orderByComboBox);
            this.catalogTabPage.Controls.Add(this.buyVehiclePartButton);
            this.catalogTabPage.Controls.Add(this.addVehiclePartButton);
            this.catalogTabPage.Controls.Add(this.catalogPanel);
            this.catalogTabPage.Controls.Add(this.catalogPicture);
            this.catalogTabPage.Location = new System.Drawing.Point(4, 24);
            this.catalogTabPage.Name = "catalogTabPage";
            this.catalogTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.catalogTabPage.Size = new System.Drawing.Size(752, 584);
            this.catalogTabPage.TabIndex = 0;
            this.catalogTabPage.Text = "Каталог";
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(670, 537);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(76, 15);
            this.orderByLabel.TabIndex = 6;
            this.orderByLabel.Text = "Сортировка:";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(577, 555);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(169, 23);
            this.orderByComboBox.TabIndex = 5;
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
            // catalogPanel
            // 
            this.catalogPanel.AutoScroll = true;
            this.catalogPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catalogPanel.Location = new System.Drawing.Point(6, 97);
            this.catalogPanel.Name = "catalogPanel";
            this.catalogPanel.Size = new System.Drawing.Size(565, 481);
            this.catalogPanel.TabIndex = 2;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
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
            this.garageTabControl.ResumeLayout(false);
            this.catalogTabPage.ResumeLayout(false);
            this.catalogTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl garageTabControl;
        public System.Windows.Forms.TabPage catalogTabPage;
        public System.Windows.Forms.Label orderByLabel;
        public System.Windows.Forms.ComboBox orderByComboBox;
        public System.Windows.Forms.Button buyVehiclePartButton;
        public System.Windows.Forms.Button addVehiclePartButton;
        public System.Windows.Forms.Panel catalogPanel;
        public System.Windows.Forms.Panel catalogPicture;
        public System.Windows.Forms.TabPage tabPage2;
    }
}