using InventoryManagementProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Home
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private async void frmHome_Load(object sender, EventArgs e)
        {
            var helper = new FirebaseHelper();

            int productCount = await helper.GetProductCount();
            int transactionCount = await helper.GetTransactionCount();
            int salesCount = await helper.GetSalesCount();
            double totalRevenue = await helper.GetTotalSalesRevenue();

            lblProduct.Text = $"Total Products: {productCount}";
            lblTransactions.Text = $"Total Transactions: {transactionCount}";
            lblSales.Text = $"Total Sales: {salesCount} (Revenue: RM {totalRevenue:N2})";
        }
    }
}
