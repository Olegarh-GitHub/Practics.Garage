namespace Practics.Garage.Forms
{
    partial class AddManufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddManufacturer));
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addPicture = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.namePanel);
            this.mainPanel.Controls.Add(this.descriptionPanel);
            this.mainPanel.Controls.Add(this.mapPanel);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 67);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(392, 410);
            this.mainPanel.TabIndex = 19;
            this.mainPanel.WrapContents = false;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Location = new System.Drawing.Point(3, 3);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(358, 45);
            this.namePanel.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(176, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование производителя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameTextBox.Location = new System.Drawing.Point(0, 22);
            this.nameTextBox.MaxLength = 96;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(358, 23);
            this.nameTextBox.TabIndex = 4;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Controls.Add(this.descriptionLabel);
            this.descriptionPanel.Controls.Add(this.descriptionTextBox);
            this.descriptionPanel.Location = new System.Drawing.Point(3, 54);
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
            this.descriptionLabel.Size = new System.Drawing.Size(148, 15);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Описание производителя";
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
            // mapPanel
            // 
            this.mapPanel.Controls.Add(this.addressTextBox);
            this.mapPanel.Controls.Add(this.addressLabel);
            this.mapPanel.Location = new System.Drawing.Point(3, 196);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(358, 45);
            this.mapPanel.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addressTextBox.Location = new System.Drawing.Point(0, 22);
            this.addressTextBox.MaxLength = 256;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(358, 23);
            this.addressTextBox.TabIndex = 7;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressLabel.Location = new System.Drawing.Point(0, 0);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(126, 15);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Адрес производителя";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 247);
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
            this.addPicture.TabIndex = 18;
            // 
            // AddManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 477);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.addPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddManufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить производителя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddManufacturer_FormClosed);
            this.mainPanel.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel addPicture;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}