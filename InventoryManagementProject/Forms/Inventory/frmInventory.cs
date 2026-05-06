using Firebase.Database;
using Firebase.Database.Query;
using InventoryManagementProject.Helpers;
using InventoryManagementProject.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Inventory
{
    public partial class frmInventory : Form
    {
        private FirebaseHelper helper = new FirebaseHelper();
        private List<Product> allProducts = new List<Product>();

        public frmInventory()
        {
            InitializeComponent();
        }

        private async void frmInventory_Load(object sender, EventArgs e)
        {
            allProducts = await helper.GetAllProducts();
            LoadFilterOptions();
            LoadInventoryGrid(allProducts);
        }

        private void LoadFilterOptions()
        {
            var categories = Category.GetCategories(); // use predefined categories
            var suppliers = Supplier.GetSuppliers();   // use predefined suppliers

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            cmbCategory.Items.AddRange(categories.ToArray());
            cmbCategory.SelectedIndex = 0;

            cmbSupplier.Items.Clear();
            cmbSupplier.Items.Add("All");
            cmbSupplier.Items.AddRange(suppliers.ToArray());
            cmbSupplier.SelectedIndex = 0;

            cmbCategory.SelectedIndexChanged += FilterChanged;
            cmbSupplier.SelectedIndexChanged += FilterChanged;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            var filtered = allProducts.AsEnumerable();

            if (cmbCategory.SelectedItem.ToString() != "All")
                filtered = filtered.Where(p => p.Category == cmbCategory.SelectedItem.ToString());

            if (cmbSupplier.SelectedItem.ToString() != "All")
                filtered = filtered.Where(p => p.Supplier == cmbSupplier.SelectedItem.ToString());

            LoadInventoryGrid(filtered.ToList());
        }

        private void LoadInventoryGrid(List<Product> products)
        {
            dgvInventory.Columns.Clear();
            dgvInventory.Rows.Clear();

            dgvInventory.Columns.Add("ProductID", "Product ID");
            dgvInventory.Columns.Add("ProductName", "Product Name");
            dgvInventory.Columns.Add("Category", "Category");
            dgvInventory.Columns.Add("Supplier", "Supplier");
            dgvInventory.Columns.Add("Quantity", "Quantity in Stock");

            DataGridViewButtonColumn adjustCol = new DataGridViewButtonColumn
            {
                Name = "Adjust",
                HeaderText = "Adjust",
                Text = "Update",
                UseColumnTextForButtonValue = true
            };
            dgvInventory.Columns.Add(adjustCol);

            foreach (var p in products)
            {
                dgvInventory.Rows.Add(p.ProductID, p.ProductName, p.Category, p.Supplier, p.Quantity);
            }

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventory.Columns[e.ColumnIndex].Name == "Adjust" && e.RowIndex >= 0)
            {
                string productId = dgvInventory.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new quantity:", "Update Stock");

                if (int.TryParse(input, out int newQty))
                {
                    await helper.UpdateProductQuantity(productId, newQty);
                    MessageBox.Show("Stock updated.");
                    allProducts = await helper.GetAllProducts();
                    FilterChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Invalid quantity entered.");
                }
            }

        }
    }
}
