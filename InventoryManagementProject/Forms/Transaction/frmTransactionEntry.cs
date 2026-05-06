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

namespace InventoryManagementProject.Forms.Reports
{
    public partial class frmTransactionEntry : Form
    {
        private List<TransactionProduct> addedProducts = new List<TransactionProduct>();

        public frmTransactionEntry()
        {
            InitializeComponent();
        }
        private void frmTransactionEntry_Load(object sender, EventArgs e)
        {
            // Fill Transaction Type
            cmbTransactionType.DataSource = TransactionType.GetTypes();

            // Generate Reference No
            txtReferenceNo.Text = GenerateRefNo();
            txtReferenceNo.ReadOnly = true;

            // Set default date
            dtpTransactionDate.Value = DateTime.Today;

            UpdateTotalAmount();
        }

        private string GenerateRefNo()
        {
            return $"TRX-{DateTime.Now.ToString("yyyyMMddHHmmss")}";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var productSelect = new frmProductSelect())
            {
                if (productSelect.ShowDialog() == DialogResult.OK)
                {
                    var selected = productSelect.SelectedProduct;
                    if (selected != null)
                    {
                        var existing = addedProducts.FirstOrDefault(p => p.ProductID == selected.ProductID);
                        if (existing != null)
                        {
                            existing.Quantity += 1;
                        }
                        else
                        {
                            addedProducts.Add(new TransactionProduct
                            {
                                ProductID = selected.ProductID,
                                ProductName = selected.ProductName,
                                Quantity = 1,
                                UnitPrice = selected.SellPrice
                            });
                        }

                        LoadAddedProducts();
                        UpdateTotalAmount();
                    }
                }
            }
        }

        private void LoadAddedProducts()
        {
            dgvAddedProduct.Rows.Clear();

            if (dgvAddedProduct.Columns.Count == 0)
            {
                dgvAddedProduct.Columns.Add("ProductID", "Product ID");
                dgvAddedProduct.Columns.Add("ProductName", "Product Name");
                dgvAddedProduct.Columns.Add("Quantity", "Quantity");
                dgvAddedProduct.Columns.Add("UnitPrice", "Unit Price");
            }

            foreach (var p in addedProducts)
            {
                dgvAddedProduct.Rows.Add(p.ProductID, p.ProductName, p.Quantity, p.UnitPrice.ToString("0.00"));
            }

            dgvAddedProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateTotalAmount()
        {
            double total = addedProducts.Sum(p => p.Quantity * p.UnitPrice);
            lblTotalAmount.Text = $"Total: RM {total.ToString("0.00")}";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTransactionType.Text) ||
                addedProducts.Count == 0)
            {
                MessageBox.Show("Please complete all fields and add at least one product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var transaction = new Transaction
            {
                ReferenceNo = txtReferenceNo.Text,
                Type = cmbTransactionType.Text,
                Date = dtpTransactionDate.Value,
                Products = addedProducts,
                TotalAmount = addedProducts.Sum(p => p.Quantity * p.UnitPrice)
            };

           

            var helper = new FirebaseHelper();
            await helper.SaveTransaction(transaction);
            if (transaction.Type == "Sale")
            {
                await helper.SaveSale(transaction); // <-- Add this
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
