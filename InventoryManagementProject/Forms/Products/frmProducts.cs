using InventoryManagementProject.Forms.Inventory;
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

namespace InventoryManagementProject.Forms.Categories
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        private async void frmProducts_Load(object sender, EventArgs e)
        {
            await LoadProductsToGrid();
            AddDeleteButtonToGrid();
        }

        private async Task LoadProductsToGrid()
        {
            var helper = new FirebaseHelper();
            var products = await helper.GetAllProducts();

            dgvProducts.Columns.Clear();
            dgvProducts.Rows.Clear();

            // Add image column first
            AddImageColumnToGrid();

            // Add other columns manually
            dgvProducts.Columns.Add("ProductID", "Product ID");
            dgvProducts.Columns.Add("ProductName", "Product Name");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Quantity", "Quantity");
            dgvProducts.Columns.Add("CostPrice", "Cost Price");
            dgvProducts.Columns.Add("SellPrice", "Sell Price");
            dgvProducts.Columns.Add("Supplier", "Supplier");
            dgvProducts.Columns.Add("Description", "Description");

            // Add delete button column
            AddDeleteButtonToGrid();

            dgvProducts.RowTemplate.Height = 70;

            foreach (var p in products)
            {
                Image thumb = null;
                string fullImagePath = Path.Combine(Application.StartupPath, p.ImageFile);

                if (File.Exists(fullImagePath))
                {
                    using (var img = Image.FromFile(fullImagePath))
                    {
                        thumb = new Bitmap(img, new Size(60, 60));
                    }
                }

                dgvProducts.Rows.Add(thumb, p.ProductID, p.ProductName, p.Category, p.Quantity,
                                     p.CostPrice, p.SellPrice, p.Supplier, p.Description);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddProduct addForm = new frmAddProduct())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadProductsToGrid(); // Refresh grid after adding
                }
            }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadProductsToGrid();
        }
        private void AddDeleteButtonToGrid()
        {
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvProducts.Columns.Add(btnDelete);
        }
        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "btnDelete" && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var row = dgvProducts.Rows[e.RowIndex];
                    var selectedProduct = new Product
                    {
                        ProductID = row.Cells["ProductID"].Value?.ToString(),
                        ProductName = row.Cells["ProductName"].Value?.ToString(),
                        Category = row.Cells["Category"].Value?.ToString(),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0),
                        CostPrice = Convert.ToDouble(row.Cells["CostPrice"].Value ?? 0),
                        SellPrice = Convert.ToDouble(row.Cells["SellPrice"].Value ?? 0),
                        Supplier = row.Cells["Supplier"].Value?.ToString(),
                        Description = row.Cells["Description"].Value?.ToString()
                    };
                    await DeleteProductFromFirebase(selectedProduct);
                    await LoadProductsToGrid(); // Refresh after deletion
                }
            }
        }
        private async Task DeleteProductFromFirebase(Product product)
        {
            var helper = new FirebaseHelper();
            await helper.DeleteProductByProductID(product.ProductID);
        }
        private void AddImageColumnToGrid()
        {
            if (!dgvProducts.Columns.Contains("Thumbnail"))
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "Thumbnail";
                imgCol.HeaderText = "Image";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvProducts.Columns.Insert(0, imgCol); // insert at first column
            }
        }
    }
}
