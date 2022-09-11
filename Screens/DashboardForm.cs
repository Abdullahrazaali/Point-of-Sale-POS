using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Properties;
using point_of_sale.Screens.CustomersF;
using point_of_sale.Screens.products;

namespace point_of_sale.Screens
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
              
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_4(object sender, EventArgs e)
        {
            DefineProductScreen dps = new DefineProductScreen();

            dps.Show();


        }

        private void metroButton11_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Productrecord prd = new Productrecord();
            prd.Show();

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            NewCustomerForm newcustomer = new NewCustomerForm();
            newcustomer.Show();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            CustomerRecordForm crf = new CustomerRecordForm();
            crf.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
