namespace point_of_sale
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.Login = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txt_username.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txt_username.CustomButton.Name = "";
            this.txt_username.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txt_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_username.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txt_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_username.CustomButton.UseSelectable = true;
            this.txt_username.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txt_username.Lines = new string[0];
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PromptText = "Enter User Name";
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.UseSelectable = true;
            this.txt_username.WaterMark = "Enter User Name";
            this.txt_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Login.UseCustomBackColor = true;
            this.Login.UseSelectable = true;
            this.Login.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Name = "metroLabel2";
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txt_password.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txt_password.Lines = new string[0];
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PromptText = "Enter Password";
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMark = "Enter Password";
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Name = "Exit";
            this.Exit.UseCustomBackColor = true;
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroButton Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

