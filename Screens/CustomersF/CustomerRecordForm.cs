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
    public partial class CustomerRecordForm : MetroFramework.Forms.MetroForm
    {
        public CustomerRecordForm()
        {  
            InitializeComponent();
        }

        private void CustomerRecordForm_Load(object sender, EventArgs e)
        {
            LoadAllCustomerRecordIntoGridView();
            //CustomerRecordGridView.Columns[0].Visible= false;
            
        }



        private void LoadAllCustomerRecordIntoGridView()
        {
            CustomerRecordGridView.DataSource = GetData();
        }



        private DataTable GetData()
        {
            DataTable dtrecords = new DataTable();

            using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_customer_LoadDataIntoCustomerRecordGrid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecords.Load(sdr);

                }

            }

            return dtrecords;
        }

        private void CustomerRecordGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int row = CustomerRecordGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int customerID =Convert.ToInt32(CustomerRecordGridView.Rows[row].Cells[0].Value);

                if (customerID >0)
                {
                    NewCustomerForm ncf = new NewCustomerForm();
                    ncf.IsUpdate = true;    
                    ncf.CustomerID = customerID;    
                    ncf.ShowDialog();
                    LoadAllCustomerRecordIntoGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
        }
    }
}
