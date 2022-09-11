namespace point_of_sale.Screens.CustomersF
{
    partial class CustomerRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            this.CustomerRecordGridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CustomerNameSearchBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(861, 70);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 43);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseCustomBackColor = true;
            this.ClearButton.UseCustomForeColor = true;
            this.ClearButton.UseSelectable = true;
            this.ClearButton.UseStyleColors = true;
            // 
            // CustomerRecordGridView
            // 
            this.CustomerRecordGridView.AllowUserToAddRows = false;
            this.CustomerRecordGridView.AllowUserToDeleteRows = false;
            this.CustomerRecordGridView.AllowUserToResizeColumns = false;
            this.CustomerRecordGridView.AllowUserToResizeRows = false;
            this.CustomerRecordGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerRecordGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.CustomerRecordGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerRecordGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CustomerRecordGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerRecordGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerRecordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerRecordGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerRecordGridView.EnableHeadersVisualStyles = false;
            this.CustomerRecordGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerRecordGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomerRecordGridView.Location = new System.Drawing.Point(64, 145);
            this.CustomerRecordGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerRecordGridView.Name = "CustomerRecordGridView";
            this.CustomerRecordGridView.ReadOnly = true;
            this.CustomerRecordGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerRecordGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerRecordGridView.RowHeadersVisible = false;
            this.CustomerRecordGridView.RowHeadersWidth = 51;
            this.CustomerRecordGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerRecordGridView.RowTemplate.Height = 24;
            this.CustomerRecordGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerRecordGridView.Size = new System.Drawing.Size(940, 338);
            this.CustomerRecordGridView.TabIndex = 11;
            this.CustomerRecordGridView.DoubleClick += new System.EventHandler(this.CustomerRecordGridView_DoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(64, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(293, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Search Here For Customer Name:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // CustomerNameSearchBox
            // 
            // 
            // 
            // 
            this.CustomerNameSearchBox.CustomButton.Image = null;
            this.CustomerNameSearchBox.CustomButton.Location = new System.Drawing.Point(417, 1);
            this.CustomerNameSearchBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerNameSearchBox.CustomButton.Name = "";
            this.CustomerNameSearchBox.CustomButton.Size = new System.Drawing.Size(28, 26);
            this.CustomerNameSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerNameSearchBox.CustomButton.TabIndex = 1;
            this.CustomerNameSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerNameSearchBox.CustomButton.UseSelectable = true;
            this.CustomerNameSearchBox.CustomButton.Visible = false;
            this.CustomerNameSearchBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CustomerNameSearchBox.Lines = new string[0];
            this.CustomerNameSearchBox.Location = new System.Drawing.Point(489, 78);
            this.CustomerNameSearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerNameSearchBox.MaxLength = 32767;
            this.CustomerNameSearchBox.Name = "CustomerNameSearchBox";
            this.CustomerNameSearchBox.PasswordChar = '\0';
            this.CustomerNameSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerNameSearchBox.SelectedText = "";
            this.CustomerNameSearchBox.SelectionLength = 0;
            this.CustomerNameSearchBox.SelectionStart = 0;
            this.CustomerNameSearchBox.ShortcutsEnabled = true;
            this.CustomerNameSearchBox.Size = new System.Drawing.Size(335, 23);
            this.CustomerNameSearchBox.TabIndex = 9;
            this.CustomerNameSearchBox.UseSelectable = true;
            this.CustomerNameSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerNameSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CustomerRecordGridView);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CustomerNameSearchBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerRecordForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "CustomerRecordForm";
            this.Load += new System.EventHandler(this.CustomerRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ClearButton;
        private MetroFramework.Controls.MetroGrid CustomerRecordGridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CustomerNameSearchBox;
    }
}