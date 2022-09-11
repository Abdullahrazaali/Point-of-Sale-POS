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
using point_of_sale.General;



namespace point_of_sale.Screens.products
{
    public partial class DefineProductScreen : MetroFramework.Forms.MetroForm 

    { 
        public DefineProductScreen()
        {
            InitializeComponent();
        }


        public bool Isupdate { get; set; }

        private List<int> SizesCart = new List<int>();

        private void DefineProductScreen_Load(object sender, EventArgs e)
        {
            if (!this.Isupdate)
            {

            }
            LoadAllsizeinGrid();
            loadDataIntoCombobox();
            
        }   
            
          
        private void loadDataIntoCombobox()
        {   
            CategoryBox.DataSource = GetComboBoxData(3);
            CategoryBox.DisplayMember = "Description";
            CategoryBox.ValueMember = "ID";

            SupplierBox.DataSource = GetComboBoxData(2);
            SupplierBox.DisplayMember = "Description";
            SupplierBox.ValueMember = "ID";
        }

        private void LoadAllsizeinGrid() //fn hai yai data ko load karanai ka grid mai
        {

            using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("loaddataingridview", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State != ConnectionState.Open)
                    con.Open();


                    DataTable dtrecords = new DataTable();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            dtrecords.Load(sdr);
                            ProductSizeGrid.DataSource = dtrecords;
                            ProductSizeGrid.Columns[0].Visible = false;
                            
                        }
                        else
                        {
                            ProductSizeGrid.DataSource = null;
                        }
                    }
                    

                }
            }


        }

        private DataTable GetComboBoxData(int listTypeID)
        {
            DataTable dtsizes = new DataTable();

           using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
          {
               using (SqlCommand cmd = new SqlCommand("usp_ListTypeData_loadDataIntoComboBox", con))
            {
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.AddWithValue("@LIstTypeID", listTypeID);
                  con.Open();
                  SqlDataReader sdr = cmd.ExecuteReader();
                  dtsizes.Load(sdr);

              }

              }

              return dtsizes;
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductSizeGrid.Rows)
            {
                row.Cells["Select"].Value = false;
            } 
       }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefineNewButton_Click(object sender, EventArgs e)
        {
            ClearControls();

        }
        private void ClearControls()
        {
            ProductNameBox.Clear();
            CategoryBox.SelectedIndex = -1;
            SupplierBox.SelectedIndex = -1;
            PurchasePriceBox.Clear();
            SalePriceBox.Clear();


            foreach (DataGridViewRow row in ProductSizeGrid.Rows)
            {

                row.Cells["Select"].Value = 0;

            } 

            ProductNameBox.Focus();
        }

        private void ProductSizeGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ProductSizeGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductSizeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectAllSizeGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductSizeGrid.Rows)
            {
                row.Cells["Select"].Value = true;
            }
        }


        private void ProductSizeGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
          
            if (IsValid())
            {
                SizesCart.Clear();
                LoadDataIntoSizesCart();

                using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_products_InsertNewProductss", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", ProductNameBox.Text);
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@SupplieID", SupplierBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@PurchasePrice", PurchasePriceBox.Text);
                        cmd.Parameters.AddWithValue("@SalePrice", SalePriceBox.Text);

                        con.Open();
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        SaveSizes(id);
                        MessageBox.Show("Product No. "+id.ToString() + " is saved sucessfully in the system","Sucess", MessageBoxButtons.OK,MessageBoxIcon.Information);
                       ClearControls();

                    }

                }
            }

        }

        private void SaveSizes(int _id)
        {
            using (SqlConnection con = new SqlConnection(Application_settting.connectionString()))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                foreach (int sizeID in SizesCart)
                {
                    using (SqlCommand cmd = new SqlCommand("usp_product_InsertProductSizes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", _id);
                        cmd.Parameters.AddWithValue("@SizeID", sizeID);
                 
                       cmd.ExecuteNonQuery();


                    }

                }

            }

            }

        private void LoadDataIntoSizesCart()
        {
            foreach (DataGridViewRow  row in ProductSizeGrid.Rows)
            {
                if (row.Cells["Select"].Value !=null && !DBNull.Value.Equals(row.Cells["Select"].Value)&& Convert.ToBoolean(row.Cells["Select"].Value)==true)
                {
                    SizesCart.Add((int)row.Cells["ID"].Value);
                }
            }
        }

        private bool IsValid() 

        {
            if (ProductNameBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Product Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductNameBox.Focus();
                return false;
            }
            if (PurchasePriceBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purchase price is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PurchasePriceBox.Focus();
                return false;
            }
            return true;
        }


        private void ProductSizeGrid_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }   

    }

}







