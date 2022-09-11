namespace point_of_sale.Screens.products
{
    partial class Productrecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductNameSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.productRecordGridView = new MetroFramework.Controls.MetroGrid();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.productRecordGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(279, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Search Here For Product Name:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ProductNameSearchBox
            // 
            // 
            // 
            // 
            this.ProductNameSearchBox.CustomButton.Image = null;
            this.ProductNameSearchBox.CustomButton.Location = new System.Drawing.Point(417, 1);
            this.ProductNameSearchBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductNameSearchBox.CustomButton.Name = "";
            this.ProductNameSearchBox.CustomButton.Size = new System.Drawing.Size(28, 26);
            this.ProductNameSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameSearchBox.CustomButton.TabIndex = 1;
            this.ProductNameSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameSearchBox.CustomButton.UseSelectable = true;
            this.ProductNameSearchBox.CustomButton.Visible = false;
            this.ProductNameSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ProductNameSearchBox.Lines = new string[0];
            this.ProductNameSearchBox.Location = new System.Drawing.Point(448, 85);
            this.ProductNameSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductNameSearchBox.MaxLength = 32767;
            this.ProductNameSearchBox.Name = "ProductNameSearchBox";
            this.ProductNameSearchBox.PasswordChar = '\0';
            this.ProductNameSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameSearchBox.SelectedText = "";
            this.ProductNameSearchBox.SelectionLength = 0;
            this.ProductNameSearchBox.SelectionStart = 0;
            this.ProductNameSearchBox.ShortcutsEnabled = true;
            this.ProductNameSearchBox.Size = new System.Drawing.Size(335, 23);
            this.ProductNameSearchBox.TabIndex = 4;
            this.ProductNameSearchBox.UseSelectable = true;
            this.ProductNameSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ProductNameSearchBox.TextChanged += new System.EventHandler(this.ProductNameSearchBox_TextChanged);
            this.ProductNameSearchBox.Click += new System.EventHandler(this.ProductNameBox_Click);
            // 
            // productRecordGridView
            // 
            this.productRecordGridView.AllowUserToAddRows = false;
            this.productRecordGridView.AllowUserToDeleteRows = false;
            this.productRecordGridView.AllowUserToResizeColumns = false;
            this.productRecordGridView.AllowUserToResizeRows = false;
            this.productRecordGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productRecordGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.productRecordGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productRecordGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productRecordGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productRecordGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productRecordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productRecordGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.productRecordGridView.EnableHeadersVisualStyles = false;
            this.productRecordGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productRecordGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productRecordGridView.Location = new System.Drawing.Point(23, 153);
            this.productRecordGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productRecordGridView.Name = "productRecordGridView";
            this.productRecordGridView.ReadOnly = true;
            this.productRecordGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productRecordGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.productRecordGridView.RowHeadersVisible = false;
            this.productRecordGridView.RowHeadersWidth = 51;
            this.productRecordGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productRecordGridView.RowTemplate.Height = 24;
            this.productRecordGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productRecordGridView.Size = new System.Drawing.Size(940, 338);
            this.productRecordGridView.TabIndex = 6;
            this.productRecordGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productRecordGridView_CellClick);
            this.productRecordGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productRecordGridView_CellContentClick);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(820, 78);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 43);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseCustomBackColor = true;
            this.ClearButton.UseCustomForeColor = true;
            this.ClearButton.UseSelectable = true;
            this.ClearButton.UseStyleColors = true;
            this.ClearButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Productrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 556);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.productRecordGridView);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ProductNameSearchBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productrecord";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Productrecord";
            this.Load += new System.EventHandler(this.Productrecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productRecordGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ProductNameSearchBox;
        private MetroFramework.Controls.MetroGrid productRecordGridView;
        private MetroFramework.Controls.MetroButton ClearButton;
    }
}