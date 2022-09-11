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

namespace point_of_sale.Screens.products
{
    public partial class Productrecord : MetroFramework.Forms.MetroForm
    {
        public Productrecord()
        {
            InitializeComponent();
        }

        private void Productrecord_Load(object sender, EventArgs e)
        {

            LoadAllPeoductsIntoDataGridView();
        }

        private void LoadAllPeoductsIntoDataGridView()
        {
            if (productRecordGridView.Columns.Contains("Delete"))
            {
                productRecordGridView.Columns.Remove("Delete");
            }

            productRecordGridView.DataSource = GetData();
           productRecordGridView.Columns[0].Visible = false;

            DataGridViewButtonColumn dv = new DataGridViewButtonColumn();

            dv.HeaderText = "Delete";
            dv.Name = "Delete";
            dv.Text = "Delete";

            

        productRecordGridView.Columns.Add(dv);
        }

        private DataTable GetData()
        {
            
                DataTable dtrecords = new DataTable();

                using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("loadAllProductsInProductREcordGrid", con))
                    {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dtrecords.Load(sdr);

                    }

                }

                return dtrecords;
            }

        private void ProductNameBox_Click(object sender, EventArgs e)
        {


            if (ProductNameSearchBox.Text.Trim()==String.Empty)
            {
                LoadAllPeoductsIntoDataGridView();
            }

            else
            {
                productRecordGridView.DataSource = GetProductByProductID();
            }
        }

       private DataTable GetProductByProductID()
        {
            DataTable dtrecords = new DataTable();

            using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loadAllProductsInProductREcordSearchbar", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", ProductNameSearchBox.Text.Trim());
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtrecords.Load(sdr);

                }

            }

            return dtrecords;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ProductNameSearchBox.Clear();
        }

        private void productRecordGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productRecordGridView.CurrentCell.ColumnIndex==7)
            {
                int _id = Convert.ToInt32(productRecordGridView.SelectedRows[0].Cells[0].Value);

                if (_id>0)
                {
                    using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_product_DeleteProduct", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ProductID",_id );


                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product No. " + _id.ToString() + " is deleted from the system","Warning",MessageBoxButtons.YesNo);

                            LoadAllPeoductsIntoDataGridView();
                        }

                    }
                }
            }

        }

        private void productRecordGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadAllPeoductsIntoDataGridView();
        }
    }
    }

