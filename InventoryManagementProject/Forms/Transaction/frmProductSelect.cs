using InventoryManagementProject.Helpers;
using InventoryManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Reports
{
    public partial class frmProductSelect : Form
    {
        private List<Product> allProducts = new();
        public Product SelectedProduct { get; private set; }

        public frmProductSelect()
        {
            InitializeComponent();
        }
        private async void frmProductSelect_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("All");
            cmbCategory.Items.AddRange(Category.GetCategories().ToArray());
            cmbCategory.SelectedIndex = 0;

            cmbSupplier.Items.Add("All");
            cmbSupplier.Items.AddRange(Supplier.GetSuppliers().ToArray());
            cmbSupplier.SelectedIndex = 0;

            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var helper = new FirebaseHelper();
            allProducts = await helper.GetAllProducts();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            string selectedSupplier = cmbSupplier.SelectedItem?.ToString();

            var filtered = allProducts
                .Where(p => (selectedCategory == "All" || p.Category == selectedCategory) &&
                            (selectedSupplier == "All" || p.Supplier == selectedSupplier))
                .ToList();

            dgvProduct.Rows.Clear();
            dgvProduct.Columns.Clear();

            dgvProduct.Columns.Add("ProductID", "Product ID");
            dgvProduct.Columns.Add("ProductName", "Product Name");
            dgvProduct.Columns.Add("Category", "Category");
            dgvProduct.Columns.Add("Supplier", "Supplier");
            dgvProduct.Columns.Add("Price", "Sell Price");

            var btnAdd = new DataGridViewButtonColumn();
            btnAdd.HeaderText = "";
            btnAdd.Text = "Add";
            btnAdd.UseColumnTextForButtonValue = true;
            btnAdd.Name = "btnAdd";

            dgvProduct.Columns.Add(btnAdd);

            foreach (var p in filtered)
            {
                dgvProduct.Rows.Add(p.ProductID, p.ProductName, p.Category, p.Supplier, p.SellPrice.ToString("0.00"));
            }

            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex].Name == "btnAdd" && e.RowIndex >= 0)
            {
                string productId = dgvProduct.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                SelectedProduct = allProducts.FirstOrDefault(p => p.ProductID == productId);

                if (SelectedProduct != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}

