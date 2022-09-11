namespace point_of_sale.Screens.products
{
    partial class DefineProductScreen
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
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.CategoryBox = new MetroFramework.Controls.MetroComboBox();
            this.ProductNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SupplierBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.PurchasePriceBox = new MetroFramework.Controls.MetroTextBox();
            this.SalePriceBox = new MetroFramework.Controls.MetroTextBox();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.DefineNewButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SelectAllSizeGrid = new MetroFramework.Controls.MetroButton();
            this.DeselectAllSizeGrid = new MetroFramework.Controls.MetroButton();
            this.ProductSizeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSizeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(70, 347);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(216, 58);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseCustomBackColor = true;
            this.SaveButton.UseCustomForeColor = true;
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.AllowDrop = true;
            this.CategoryBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CategoryBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.ItemHeight = 24;
            this.CategoryBox.Location = new System.Drawing.Point(235, 145);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(192, 30);
            this.CategoryBox.TabIndex = 1;
            this.CategoryBox.UseSelectable = true;
            // 
            // ProductNameBox
            // 
            // 
            // 
            // 
            this.ProductNameBox.CustomButton.Image = null;
            this.ProductNameBox.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.ProductNameBox.CustomButton.Name = "";
            this.ProductNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameBox.CustomButton.TabIndex = 1;
            this.ProductNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameBox.CustomButton.UseSelectable = true;
            this.ProductNameBox.CustomButton.Visible = false;
            this.ProductNameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ProductNameBox.Lines = new string[0];
            this.ProductNameBox.Location = new System.Drawing.Point(235, 100);
            this.ProductNameBox.MaxLength = 32767;
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.PasswordChar = '\0';
            this.ProductNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameBox.SelectedText = "";
            this.ProductNameBox.SelectionLength = 0;
            this.ProductNameBox.SelectionStart = 0;
            this.ProductNameBox.ShortcutsEnabled = true;
            this.ProductNameBox.Size = new System.Drawing.Size(192, 23);
            this.ProductNameBox.TabIndex = 0;
            this.ProductNameBox.UseSelectable = true;
            this.ProductNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Product Name:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(167, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Product Category:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 246);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(141, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Purchase Price:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 199);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(167, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Product Suppliers:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // SupplierBox
            // 
            this.SupplierBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SupplierBox.FormattingEnabled = true;
            this.SupplierBox.ItemHeight = 24;
            this.SupplierBox.Location = new System.Drawing.Point(235, 194);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.Size = new System.Drawing.Size(192, 30);
            this.SupplierBox.TabIndex = 2;
            this.SupplierBox.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(23, 291);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 25);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Sale Price:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // PurchasePriceBox
            // 
            // 
            // 
            // 
            this.PurchasePriceBox.CustomButton.Image = null;
            this.PurchasePriceBox.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.PurchasePriceBox.CustomButton.Name = "";
            this.PurchasePriceBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PurchasePriceBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PurchasePriceBox.CustomButton.TabIndex = 1;
            this.PurchasePriceBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PurchasePriceBox.CustomButton.UseSelectable = true;
            this.PurchasePriceBox.CustomButton.Visible = false;
            this.PurchasePriceBox.Lines = new string[0];
            this.PurchasePriceBox.Location = new System.Drawing.Point(235, 248);
            this.PurchasePriceBox.MaxLength = 32767;
            this.PurchasePriceBox.Name = "PurchasePriceBox";
            this.PurchasePriceBox.PasswordChar = '\0';
            this.PurchasePriceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PurchasePriceBox.SelectedText = "";
            this.PurchasePriceBox.SelectionLength = 0;
            this.PurchasePriceBox.SelectionStart = 0;
            this.PurchasePriceBox.ShortcutsEnabled = true;
            this.PurchasePriceBox.Size = new System.Drawing.Size(115, 23);
            this.PurchasePriceBox.TabIndex = 3;
            this.PurchasePriceBox.UseSelectable = true;
            this.PurchasePriceBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PurchasePriceBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SalePriceBox
            // 
            // 
            // 
            // 
            this.SalePriceBox.CustomButton.Image = null;
            this.SalePriceBox.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.SalePriceBox.CustomButton.Name = "";
            this.SalePriceBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalePriceBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalePriceBox.CustomButton.TabIndex = 1;
            this.SalePriceBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalePriceBox.CustomButton.UseSelectable = true;
            this.SalePriceBox.CustomButton.Visible = false;
            this.SalePriceBox.Lines = new string[0];
            this.SalePriceBox.Location = new System.Drawing.Point(235, 293);
            this.SalePriceBox.MaxLength = 32767;
            this.SalePriceBox.Name = "SalePriceBox";
            this.SalePriceBox.PasswordChar = '\0';
            this.SalePriceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalePriceBox.SelectedText = "";
            this.SalePriceBox.SelectionLength = 0;
            this.SalePriceBox.SelectionStart = 0;
            this.SalePriceBox.ShortcutsEnabled = true;
            this.SalePriceBox.Size = new System.Drawing.Size(115, 23);
            this.SalePriceBox.TabIndex = 4;
            this.SalePriceBox.UseSelectable = true;
            this.SalePriceBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalePriceBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CloseButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(70, 411);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(216, 58);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseCustomBackColor = true;
            this.CloseButton.UseCustomForeColor = true;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.UseStyleColors = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DefineNewButton
            // 
            this.DefineNewButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DefineNewButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DefineNewButton.ForeColor = System.Drawing.Color.White;
            this.DefineNewButton.Location = new System.Drawing.Point(522, 347);
            this.DefineNewButton.Name = "DefineNewButton";
            this.DefineNewButton.Size = new System.Drawing.Size(216, 58);
            this.DefineNewButton.TabIndex = 8;
            this.DefineNewButton.Text = "Define New";
            this.DefineNewButton.UseCustomBackColor = true;
            this.DefineNewButton.UseCustomForeColor = true;
            this.DefineNewButton.UseSelectable = true;
            this.DefineNewButton.Click += new System.EventHandler(this.DefineNewButton_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(556, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(155, 25);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Set Product Size:";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // SelectAllSizeGrid
            // 
            this.SelectAllSizeGrid.BackColor = System.Drawing.Color.Silver;
            this.SelectAllSizeGrid.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SelectAllSizeGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectAllSizeGrid.Location = new System.Drawing.Point(790, 100);
            this.SelectAllSizeGrid.Name = "SelectAllSizeGrid";
            this.SelectAllSizeGrid.Size = new System.Drawing.Size(46, 41);
            this.SelectAllSizeGrid.TabIndex = 10;
            this.SelectAllSizeGrid.Text = "S";
            this.SelectAllSizeGrid.UseCustomBackColor = true;
            this.SelectAllSizeGrid.UseCustomForeColor = true;
            this.SelectAllSizeGrid.UseSelectable = true;
            this.SelectAllSizeGrid.UseStyleColors = true;
            this.SelectAllSizeGrid.Click += new System.EventHandler(this.SelectAllSizeGrid_Click);
            // 
            // DeselectAllSizeGrid
            // 
            this.DeselectAllSizeGrid.BackColor = System.Drawing.Color.Silver;
            this.DeselectAllSizeGrid.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DeselectAllSizeGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeselectAllSizeGrid.Location = new System.Drawing.Point(790, 145);
            this.DeselectAllSizeGrid.Name = "DeselectAllSizeGrid";
            this.DeselectAllSizeGrid.Size = new System.Drawing.Size(46, 41);
            this.DeselectAllSizeGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.DeselectAllSizeGrid.TabIndex = 11;
            this.DeselectAllSizeGrid.Text = "D";
            this.DeselectAllSizeGrid.UseCustomBackColor = true;
            this.DeselectAllSizeGrid.UseCustomForeColor = true;
            this.DeselectAllSizeGrid.UseSelectable = true;
            this.DeselectAllSizeGrid.UseStyleColors = true;
            this.DeselectAllSizeGrid.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ProductSizeGrid
            // 
            this.ProductSizeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductSizeGrid.Location = new System.Drawing.Point(522, 100);
            this.ProductSizeGrid.Name = "ProductSizeGrid";
            this.ProductSizeGrid.RowHeadersWidth = 51;
            this.ProductSizeGrid.RowTemplate.Height = 24;
            this.ProductSizeGrid.Size = new System.Drawing.Size(240, 171);
            this.ProductSizeGrid.TabIndex = 12;
            this.ProductSizeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductSizeGrid_CellContentClick_2);
            // 
            // DefineProductScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(852, 562);
            this.Controls.Add(this.ProductSizeGrid);
            this.Controls.Add(this.DeselectAllSizeGrid);
            this.Controls.Add(this.SelectAllSizeGrid);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.DefineNewButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SalePriceBox);
            this.Controls.Add(this.PurchasePriceBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.SupplierBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.SaveButton);
            this.MaximizeBox = false;
            this.Name = "DefineProductScreen";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Define Product";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSizeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroComboBox CategoryBox;
        private MetroFramework.Controls.MetroTextBox ProductNameBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox SupplierBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox PurchasePriceBox;
        private MetroFramework.Controls.MetroTextBox SalePriceBox;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroButton DefineNewButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton SelectAllSizeGrid;
        private MetroFramework.Controls.MetroButton DeselectAllSizeGrid;
        private System.Windows.Forms.DataGridView ProductSizeGrid;
    }
}