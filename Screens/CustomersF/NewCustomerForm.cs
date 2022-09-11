using point_of_sale.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_of_sale.Screens.CustomersF
{
    public partial class NewCustomerForm : MetroFramework.Forms.MetroForm
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }
        public int CustomerID { get; set; }
        public bool IsUpdate { get; set; }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                LoadDataAndMapIntoControls();
            }
        }

        // jesi hum customer record pr click karain gai tw uss line ka data yai form mai refill kar dai ga yai method 
        private void LoadDataAndMapIntoControls()
        {
            DataTable dtrecords = GetCustomerData();
            DataRow row;
            row = dtrecords.Rows[0];

            CustomerNameTextBox.Text = row["Name"].ToString();
            MobileTextBox.Text = row["Mobile"].ToString();
            AddressTextBox.Text = row["Address"].ToString();


        }

        private DataTable GetCustomerData()
        {
            DataTable dtdata = new DataTable();

            using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("Usp_GetCustomerdatabucustomerid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", this.CustomerID);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtdata.Load(sdr);

                }

            }

            return dtdata;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (this.IsUpdate)
                {
                    using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("Usp_customer_updatecustomerByCustomerId", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@Mobile", MobileTextBox.Text);
                            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                            cmd.Parameters.AddWithValue("@CustomerID", this.CustomerID);

                            con.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer details are Updated sucessfully in the system", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Clearfornewproducts();
                        }
                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_customer_InsertNewCustomer", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@Mobile", MobileTextBox.Text);
                            cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);

                            con.Open();
                            int id = Convert.ToInt32(cmd.ExecuteScalar());
                            //cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer No. " + id + " is saved sucessfully in the system", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                }
            }
        }

        private bool IsValid()
        {
            if (CustomerNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerNameTextBox.Focus();
                return false;
            }

            return true;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {

            Clearfornewproducts();



        }

        private void Clearfornewproducts()
        {

            CustomerNameTextBox.Clear();
            MobileTextBox.Clear();
            AddressTextBox.Clear();

            CustomerNameTextBox.Focus();

            this.IsUpdate = false;
            this.CustomerID = 0;
        }
    } 
}
