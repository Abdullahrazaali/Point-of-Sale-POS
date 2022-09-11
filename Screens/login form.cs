using point_of_sale.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using point_of_sale.Screens;

namespace point_of_sale
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ISvalid())
            {
                using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_login_Verifyingdetails",con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", txt_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());

                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            this.Hide();
                            DashboardForm df = new DashboardForm();

                            df.Show();
                        }
                        else
                        {
                            MessageBox.Show("User name or password is required","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                    }
                }

            }
        }
        private bool ISvalid()
        {
            if (txt_username.Text.Trim()== String.Empty)
            {
                MessageBox.Show("User Name is required", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Focus();
                return false;   
            }
            if (txt_password.Text.Trim()== String.Empty)
            {
                MessageBox.Show("Password is Required", "Form Validation Error");
                txt_password.Focus();   
                return false;
            }
            return true;    
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_Click(object sender, EventArgs e)
        {

        }
    }
}
