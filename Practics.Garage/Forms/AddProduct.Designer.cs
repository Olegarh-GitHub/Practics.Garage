namespace Practics.Garage.Forms
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.editorsPanel = new System.Windows.Forms.Panel();
            this.specificationsLabel = new System.Windows.Forms.Label();
            this.specificationsPanel = new System.Windows.Forms.Panel();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.manufacturersLabel = new System.Windows.Forms.Label();
            this.manufacturersComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addPicture = new System.Windows.Forms.Panel();
            this.specificationsContainer = new System.Windows.Forms.Panel();
            this.addSpecificationLink = new System.Windows.Forms.LinkLabel();
            this.editorsPanel.SuspendLayout();
            this.specificationsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorsPanel
            // 
            this.editorsPanel.AutoScroll = true;
            this.editorsPanel.Controls.Add(this.specificationsContainer);
            this.editorsPanel.Controls.Add(this.specificationsLabel);
            this.editorsPanel.Controls.Add(this.costTextBox);
            this.editorsPanel.Controls.Add(this.labelCost);
            this.editorsPanel.Controls.Add(this.descriptionTextBox);
            this.editorsPanel.Controls.Add(this.descriptionLabel);
            this.editorsPanel.Controls.Add(this.nameTextBox);
            this.editorsPanel.Controls.Add(this.nameLabel);
            this.editorsPanel.Controls.Add(this.manufacturersLabel);
            this.editorsPanel.Controls.Add(this.manufacturersComboBox);
            this.editorsPanel.Controls.Add(this.addButton);
            this.editorsPanel.Location = new System.Drawing.Point(9, 75);
            this.editorsPanel.Name = "editorsPanel";
            this.editorsPanel.Size = new System.Drawing.Size(465, 377);
            this.editorsPanel.TabIndex = 3;
            // 
            // specificationsLabel
            // 
            this.specificationsLabel.AutoSize = true;
            this.specificationsLabel.Location = new System.Drawing.Point(11, 277);
            this.specificationsLabel.Name = "specificationsLabel";
            this.specificationsLabel.Size = new System.Drawing.Size(61, 15);
            this.specificationsLabel.TabIndex = 10;
            this.specificationsLabel.Text = "Свойства:";
            // 
            // specificationsPanel
            // 
            this.specificationsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.specificationsPanel.Location = new System.Drawing.Point(0, 0);
            this.specificationsPanel.Name = "specificationsPanel";
            this.specificationsPanel.Size = new System.Drawing.Size(251, 10);
            this.specificationsPanel.TabIndex = 9;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(14, 209);
            this.costTextBox.MaxLength = 96;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(251, 23);
            this.costTextBox.TabIndex = 8;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(11, 191);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(110, 15);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Стоимость товара:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 71);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(251, 118);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 53);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(105, 15);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Описание товара:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(14, 27);
            this.nameTextBox.MaxLength = 96;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 23);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование товара:";
            // 
            // manufacturersLabel
            // 
            this.manufacturersLabel.AutoSize = true;
            this.manufacturersLabel.Location = new System.Drawing.Point(11, 234);
            this.manufacturersLabel.Name = "manufacturersLabel";
            this.manufacturersLabel.Size = new System.Drawing.Size(95, 15);
            this.manufacturersLabel.TabIndex = 2;
            this.manufacturersLabel.Text = "Производитель:";
            // 
            // manufacturersComboBox
            // 
            this.manufacturersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturersComboBox.FormattingEnabled = true;
            this.manufacturersComboBox.Location = new System.Drawing.Point(14, 252);
            this.manufacturersComboBox.Name = "manufacturersComboBox";
            this.manufacturersComboBox.Size = new System.Drawing.Size(251, 23);
            this.manufacturersComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(14, 335);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(420, 31);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить товар";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // addPicture
            // 
            this.addPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPicture.BackgroundImage")));
            this.addPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPicture.Location = new System.Drawing.Point(-8, -1);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(493, 67);
            this.addPicture.TabIndex = 2;
            // 
            // specificationsContainer
            // 
            this.specificationsContainer.Controls.Add(this.addSpecificationLink);
            this.specificationsContainer.Controls.Add(this.specificationsPanel);
            this.specificationsContainer.Location = new System.Drawing.Point(14, 295);
            this.specificationsContainer.Name = "specificationsContainer";
            this.specificationsContainer.Size = new System.Drawing.Size(251, 30);
            this.specificationsContainer.TabIndex = 10;
            // 
            // addSpecificationLink
            // 
            this.addSpecificationLink.AutoSize = true;
            this.addSpecificationLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addSpecificationLink.Location = new System.Drawing.Point(0, 15);
            this.addSpecificationLink.Name = "addSpecificationLink";
            this.addSpecificationLink.Size = new System.Drawing.Size(112, 15);
            this.addSpecificationLink.TabIndex = 11;
            this.addSpecificationLink.TabStop = true;
            this.addSpecificationLink.Text = "Добавить свойство";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.editorsPanel);
            this.Controls.Add(this.addPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить товар";
            this.editorsPanel.ResumeLayout(false);
            this.editorsPanel.PerformLayout();
            this.specificationsContainer.ResumeLayout(false);
            this.specificationsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editorsPanel;
        private System.Windows.Forms.Panel addPicture;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label manufacturersLabel;
        private System.Windows.Forms.ComboBox manufacturersComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label specificationsLabel;
        private System.Windows.Forms.Panel specificationsPanel;
        private System.Windows.Forms.Panel specificationsContainer;
        private System.Windows.Forms.LinkLabel addSpecificationLink;
    }
}