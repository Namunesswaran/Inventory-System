using InventoryManagementProject.Forms.Authentication;
using InventoryManagementProject.Forms.Categories;
using InventoryManagementProject.Forms.Home;
using InventoryManagementProject.Forms.Inventory;
using InventoryManagementProject.Forms.Reports;
using InventoryManagementProject.Forms.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        private Form? activeForm = null;

        private void OpenFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHome());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmInventory());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmProducts());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmTransactions());
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmHome());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmSales());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmReport());
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log Out", "Confirm Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
