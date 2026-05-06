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

namespace InventoryManagementProject.Forms.Sales
{
    public partial class frmSales : Form
    {
        private List<Transaction> allSales = new();
        public frmSales()
        {
            InitializeComponent();
        }
        private async void frmSales_Load(object sender, EventArgs e)
        {
            var helper = new FirebaseHelper();
            var allTransactions = await helper.GetAllTransactions();

            allSales = allTransactions
                .Where(t => t.Type == "Sale")
                .ToList();

            LoadSalesToGrid();
        }

        private void LoadSalesToGrid()
        {
            dgvSales.Columns.Clear();
            dgvSales.Rows.Clear();

            dgvSales.Columns.Add("RefNo", "Reference No");
            dgvSales.Columns.Add("Date", "Date");
            dgvSales.Columns.Add("Items", "Items Sold");
            dgvSales.Columns.Add("Summary", "Product Summary");
            dgvSales.Columns.Add("Total", "Total Amount");

            // Add the View Details button column
            var btnCol = new DataGridViewButtonColumn();
            btnCol.Name = "ViewDetails";
            btnCol.HeaderText = "Product Details";
            btnCol.Text = "View Details";
            btnCol.UseColumnTextForButtonValue = true;
            dgvSales.Columns.Add(btnCol);

            double totalSales = 0;

            foreach (var sale in allSales)
            {
                int totalItems = sale.Products?.Sum(p => p.Quantity) ?? 0;

                string summary = "";
                if (sale.Products != null && sale.Products.Count > 0)
                {
                    summary = string.Join(", ", sale.Products
                        .Take(3)
                        .Select(p => $"{p.Quantity}x {p.ProductName}"));
                    if (sale.Products.Count > 3)
                        summary += ", ...";
                }
                else
                {
                    summary = "No Products";
                }

                dgvSales.Rows.Add(
                    sale.ReferenceNo,
                    sale.Date.ToShortDateString(),
                    totalItems.ToString(),
                    summary,
                    sale.TotalAmount.ToString("0.00")
                );

                totalSales += sale.TotalAmount;
            }

            lblTotalSales.Text = $"Total Sales: RM {totalSales.ToString("0.00")}";
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSales.Columns[e.ColumnIndex].Name == "ViewDetails")
            {
                string refNo = dgvSales.Rows[e.RowIndex].Cells["RefNo"].Value.ToString();
                var selectedTransaction = allSales.FirstOrDefault(t => t.ReferenceNo == refNo);

                if (selectedTransaction != null && selectedTransaction.Products != null)
                {
                    string message = "Products:\n";

                    foreach (var p in selectedTransaction.Products)
                    {
                        message += $"- {p.ProductName} x{p.Quantity} @ RM {p.UnitPrice:0.00}\n";
                    }

                    MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No product details found.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
