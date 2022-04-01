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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.costPanel = new System.Windows.Forms.Panel();
            this.labelCost = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.manufacturersPanel = new System.Windows.Forms.Panel();
            this.manufacturersLabel = new System.Windows.Forms.Label();
            this.manufacturersComboBox = new System.Windows.Forms.ComboBox();
            this.specificationContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.specificationsLabel = new System.Windows.Forms.Label();
            this.specificationsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addSpecificationLink = new System.Windows.Forms.LinkLabel();
            this.addButton = new System.Windows.Forms.Button();
            this.addPicture = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.costPanel.SuspendLayout();
            this.manufacturersPanel.SuspendLayout();
            this.specificationContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.namePanel);
            this.mainPanel.Controls.Add(this.descriptionPanel);
            this.mainPanel.Controls.Add(this.costPanel);
            this.mainPanel.Controls.Add(this.manufacturersPanel);
            this.mainPanel.Controls.Add(this.specificationContainerPanel);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 67);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(392, 410);
            this.mainPanel.TabIndex = 17;
            this.mainPanel.WrapContents = false;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Location = new System.Drawing.Point(3, 3);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(358, 44);
            this.namePanel.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(133, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование товара:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameTextBox.Location = new System.Drawing.Point(0, 21);
            this.nameTextBox.MaxLength = 96;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(358, 23);
            this.nameTextBox.TabIndex = 4;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Controls.Add(this.descriptionTextBox);
            this.descriptionPanel.Location = new System.Drawing.Point(3, 53);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(358, 136);
            this.descriptionPanel.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(105, 15);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Описание товара:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 18);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(358, 118);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // costPanel
            // 
            this.costPanel.Controls.Add(this.labelCost);
            this.costPanel.Controls.Add(this.costTextBox);
            this.costPanel.Location = new System.Drawing.Point(3, 195);
            this.costPanel.Name = "costPanel";
            this.costPanel.Size = new System.Drawing.Size(358, 44);
            this.costPanel.TabIndex = 13;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCost.Location = new System.Drawing.Point(0, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(110, 15);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Стоимость товара:";
            // 
            // costTextBox
            // 
            this.costTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.costTextBox.Location = new System.Drawing.Point(0, 21);
            this.costTextBox.MaxLength = 96;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(358, 23);
            this.costTextBox.TabIndex = 8;
            // 
            // manufacturersPanel
            // 
            this.manufacturersPanel.Controls.Add(this.manufacturersLabel);
            this.manufacturersPanel.Controls.Add(this.manufacturersComboBox);
            this.manufacturersPanel.Location = new System.Drawing.Point(3, 245);
            this.manufacturersPanel.Name = "manufacturersPanel";
            this.manufacturersPanel.Size = new System.Drawing.Size(358, 44);
            this.manufacturersPanel.TabIndex = 14;
            // 
            // manufacturersLabel
            // 
            this.manufacturersLabel.AutoSize = true;
            this.manufacturersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.manufacturersLabel.Location = new System.Drawing.Point(0, 0);
            this.manufacturersLabel.Name = "manufacturersLabel";
            this.manufacturersLabel.Size = new System.Drawing.Size(95, 15);
            this.manufacturersLabel.TabIndex = 2;
            this.manufacturersLabel.Text = "Производитель:";
            // 
            // manufacturersComboBox
            // 
            this.manufacturersComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manufacturersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturersComboBox.FormattingEnabled = true;
            this.manufacturersComboBox.Location = new System.Drawing.Point(0, 21);
            this.manufacturersComboBox.Name = "manufacturersComboBox";
            this.manufacturersComboBox.Size = new System.Drawing.Size(358, 23);
            this.manufacturersComboBox.TabIndex = 1;
            // 
            // specificationContainerPanel
            // 
            this.specificationContainerPanel.AutoSize = true;
            this.specificationContainerPanel.Controls.Add(this.specificationsLabel);
            this.specificationContainerPanel.Controls.Add(this.specificationsPanel);
            this.specificationContainerPanel.Controls.Add(this.addSpecificationLink);
            this.specificationContainerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.specificationContainerPanel.Location = new System.Drawing.Point(3, 295);
            this.specificationContainerPanel.Name = "specificationContainerPanel";
            this.specificationContainerPanel.Size = new System.Drawing.Size(118, 36);
            this.specificationContainerPanel.TabIndex = 16;
            // 
            // specificationsLabel
            // 
            this.specificationsLabel.AutoSize = true;
            this.specificationsLabel.Location = new System.Drawing.Point(3, 0);
            this.specificationsLabel.Name = "specificationsLabel";
            this.specificationsLabel.Size = new System.Drawing.Size(61, 15);
            this.specificationsLabel.TabIndex = 10;
            this.specificationsLabel.Text = "Свойства:";
            // 
            // specificationsPanel
            // 
            this.specificationsPanel.AutoSize = true;
            this.specificationsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.specificationsPanel.Location = new System.Drawing.Point(3, 18);
            this.specificationsPanel.Name = "specificationsPanel";
            this.specificationsPanel.Size = new System.Drawing.Size(0, 0);
            this.specificationsPanel.TabIndex = 17;
            // 
            // addSpecificationLink
            // 
            this.addSpecificationLink.AutoSize = true;
            this.addSpecificationLink.Location = new System.Drawing.Point(3, 21);
            this.addSpecificationLink.Name = "addSpecificationLink";
            this.addSpecificationLink.Size = new System.Drawing.Size(112, 15);
            this.addSpecificationLink.TabIndex = 11;
            this.addSpecificationLink.TabStop = true;
            this.addSpecificationLink.Text = "Добавить свойство";
            this.addSpecificationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addSpecificationLink_LinkClicked);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 337);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(358, 36);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить товар";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addPicture
            // 
            this.addPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPicture.BackgroundImage")));
            this.addPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPicture.Location = new System.Drawing.Point(0, 0);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(392, 67);
            this.addPicture.TabIndex = 2;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(392, 477);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.addPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.costPanel.ResumeLayout(false);
            this.costPanel.PerformLayout();
            this.manufacturersPanel.ResumeLayout(false);
            this.manufacturersPanel.PerformLayout();
            this.specificationContainerPanel.ResumeLayout(false);
            this.specificationContainerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.LinkLabel addSpecificationLink;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Panel costPanel;
        private System.Windows.Forms.Panel manufacturersPanel;
        private System.Windows.Forms.FlowLayoutPanel specificationContainerPanel;
        private System.Windows.Forms.FlowLayoutPanel specificationsPanel;
    }
}