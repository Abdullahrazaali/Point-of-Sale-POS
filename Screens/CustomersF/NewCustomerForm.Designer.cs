namespace point_of_sale.Screens.CustomersF
{
    partial class NewCustomerForm
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
            this.NewButton = new MetroFramework.Controls.MetroButton();
            this.MobileTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.AddressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CustomerNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NewButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(123, 391);
            this.NewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(164, 71);
            this.NewButton.TabIndex = 4;
            this.NewButton.Text = "New";
            this.NewButton.UseCustomBackColor = true;
            this.NewButton.UseCustomForeColor = true;
            this.NewButton.UseSelectable = true;
            this.NewButton.UseStyleColors = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // MobileTextBox
            // 
            // 
            // 
            // 
            this.MobileTextBox.CustomButton.Image = null;
            this.MobileTextBox.CustomButton.Location = new System.Drawing.Point(273, 2);
            this.MobileTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MobileTextBox.CustomButton.Name = "";
            this.MobileTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.MobileTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MobileTextBox.CustomButton.TabIndex = 1;
            this.MobileTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MobileTextBox.CustomButton.UseSelectable = true;
            this.MobileTextBox.CustomButton.Visible = false;
            this.MobileTextBox.Lines = new string[0];
            this.MobileTextBox.Location = new System.Drawing.Point(327, 162);
            this.MobileTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MobileTextBox.MaxLength = 32767;
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.PasswordChar = '\0';
            this.MobileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MobileTextBox.SelectedText = "";
            this.MobileTextBox.SelectionLength = 0;
            this.MobileTextBox.SelectionStart = 0;
            this.MobileTextBox.ShortcutsEnabled = true;
            this.MobileTextBox.Size = new System.Drawing.Size(231, 28);
            this.MobileTextBox.TabIndex = 1;
            this.MobileTextBox.UseSelectable = true;
            this.MobileTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MobileTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(44, 160);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(155, 25);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Custome Mobile:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(44, 105);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(153, 25);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Customer Name:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(123, 313);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(365, 60);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseCustomBackColor = true;
            this.SaveButton.UseCustomForeColor = true;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CloseButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(324, 391);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(164, 71);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseCustomBackColor = true;
            this.CloseButton.UseCustomForeColor = true;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.UseStyleColors = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddressTextBox
            // 
            // 
            // 
            // 
            this.AddressTextBox.CustomButton.Image = null;
            this.AddressTextBox.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.AddressTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.CustomButton.Name = "";
            this.AddressTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.AddressTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddressTextBox.CustomButton.TabIndex = 1;
            this.AddressTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddressTextBox.CustomButton.UseSelectable = true;
            this.AddressTextBox.CustomButton.Visible = false;
            this.AddressTextBox.Lines = new string[0];
            this.AddressTextBox.Location = new System.Drawing.Point(327, 215);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressTextBox.MaxLength = 32767;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PasswordChar = '\0';
            this.AddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressTextBox.SelectedText = "";
            this.AddressTextBox.SelectionLength = 0;
            this.AddressTextBox.SelectionStart = 0;
            this.AddressTextBox.ShortcutsEnabled = true;
            this.AddressTextBox.Size = new System.Drawing.Size(387, 28);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.UseSelectable = true;
            this.AddressTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddressTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(44, 213);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 25);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Custome Address:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // CustomerNameTextBox
            // 
            // 
            // 
            // 
            this.CustomerNameTextBox.CustomButton.Image = null;
            this.CustomerNameTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.CustomerNameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameTextBox.CustomButton.Name = "";
            this.CustomerNameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.CustomerNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerNameTextBox.CustomButton.TabIndex = 1;
            this.CustomerNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerNameTextBox.CustomButton.UseSelectable = true;
            this.CustomerNameTextBox.CustomButton.Visible = false;
            this.CustomerNameTextBox.Lines = new string[0];
            this.CustomerNameTextBox.Location = new System.Drawing.Point(324, 105);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerNameTextBox.MaxLength = 32767;
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.PasswordChar = '\0';
            this.CustomerNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerNameTextBox.SelectedText = "";
            this.CustomerNameTextBox.SelectionLength = 0;
            this.CustomerNameTextBox.SelectionStart = 0;
            this.CustomerNameTextBox.ShortcutsEnabled = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(231, 28);
            this.CustomerNameTextBox.TabIndex = 18;
            this.CustomerNameTextBox.UseSelectable = true;
            this.CustomerNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 590);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.SaveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "NewCustomer";
            this.Load += new System.EventHandler(this.NewCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton NewButton;
        private MetroFramework.Controls.MetroTextBox MobileTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroTextBox AddressTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CustomerNameTextBox;
    }
}