using InventoryManagementProject.Helpers;
using InventoryManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.Reports
{
    public partial class frmReport : Form
    {
        private FirebaseHelper helper = new FirebaseHelper();
        private ReportList reportList = new ReportList();
        public frmReport()
        {
            InitializeComponent();
        }
        private async void frmReports_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.AddRange(new[] { "All", "Sales", "Stock" });
            cmbReportType.SelectedIndex = 0;

            await LoadReportsFromFirebase();
            DisplayReports();
        }

        private async Task LoadReportsFromFirebase()
        {
            var reports = await helper.GetAllReports();
            reportList.SetReports(reports);
        }

        private void DisplayReports(string filter = "All")
        {
            dgvReport.Columns.Clear();
            dgvReport.Rows.Clear();

            if (filter == "Sales")
            {
                dgvReport.Columns.Add("RefNo", "Report ID");
                dgvReport.Columns.Add("Date", "Date");
                dgvReport.Columns.Add("TotalAmount", "Total Sale");
                dgvReport.Columns.Add("TransactionCount", "Sale Transactions");

                var transactions = reportList
                    .GetAllReports()
                    .OfType<SalesReport>()
                    .OrderByDescending(r => r.ReportDate)
                    .ToList();

                foreach (var sale in transactions)
                {
                    dgvReport.Rows.Add(
                        sale.ReportID,
                        sale.ReportDate.ToShortDateString(),
                        sale.TotalSales.ToString("0.00"),
                        ExtractTransactionCount(sale.Content)
                    );
                }
            }
            else if (filter == "Stock")
            {
                dgvReport.Columns.Add("RefNo", "Report ID");
                dgvReport.Columns.Add("Date", "Date");
                dgvReport.Columns.Add("TotalProducts", "Total Products");
                dgvReport.Columns.Add("LowStock", "Low Stock Items");

                var stockReports = reportList
                    .GetAllReports()
                    .OfType<StockReport>()
                    .OrderByDescending(r => r.ReportDate)
                    .ToList();

                foreach (var stock in stockReports)
                {
                    dgvReport.Rows.Add(
                        stock.ReportID,
                        stock.ReportDate.ToShortDateString(),
                        stock.TotalItems,
                        stock.LowStockItems
                    );
                }
            }
            else 
            {
                dgvReport.Columns.Add("Type", "Type");
                dgvReport.Columns.Add("Date", "Date");

                var all = reportList
                    .GetAllReports()
                    .OrderByDescending(r => r.ReportDate)
                    .ToList();

                foreach (var r in all)
                {
                    dgvReport.Rows.Add(r.ReportType, r.ReportDate.ToShortDateString());
                }
            }

            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private string ExtractTransactionCount(string content)
        {
            // Assumes content format like: "Total Sales Transactions: 4, Total Revenue: RM 123.45"
            var match = Regex.Match(content, @"Total Sales Transactions:\s*(\d+)");
            return match.Success ? match.Groups[1].Value : "N/A";
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbReportType.SelectedItem.ToString();
            DisplayReports(selectedType);
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            string selected = cmbReportType.SelectedItem.ToString();

            if (selected == "Sales")
            {
                await GenerateSalesReport();
            }
            else if (selected == "Stock")
            {
                await GenerateStockReport();
            }

            await LoadReportsFromFirebase();
            DisplayReports(cmbReportType.SelectedItem.ToString());
        }

        private async Task GenerateSalesReport()
        {
            var transactions = await helper.GetAllTransactions();
            var sales = transactions.Where(t => t.Type == "Sale").ToList();

            double total = sales.Sum(s => s.TotalAmount);
            string summary = $"Total Sales Transactions: {sales.Count}, Total Revenue: RM {total:0.00}";

            var report = new SalesReport(Guid.NewGuid().ToString(), summary, total);
            await helper.AddReport(report);
        }

        private async Task GenerateStockReport()
        {
            var products = await helper.GetAllProducts();
            int totalItems = products.Count;
            int lowStock = products.Count(p => p.Quantity <= 5);

            string summary = $"Total Products: {totalItems}, Low Stock Items: {lowStock}";

            var report = new StockReport(Guid.NewGuid().ToString(), summary, totalItems, lowStock);
            await helper.AddReport(report);
        }
        private async void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvReport.Columns[e.ColumnIndex].Name != "btnDelete")
                return;

            string reportType = cmbReportType.SelectedItem.ToString();

            string reportID = "";

            if (reportType == "Sales")
            {
                // ReportID is the first column
                reportID = dgvReport.Rows[e.RowIndex].Cells["RefNo"].Value?.ToString();
            }
            else if (reportType == "All")
            {
                // Try getting from internal ReportList
                var date = dgvReport.Rows[e.RowIndex].Cells["Date"].Value?.ToString();
                var type = dgvReport.Rows[e.RowIndex].Cells["Type"].Value?.ToString();

                var match = reportList.GetAllReports()
                    .FirstOrDefault(r => r.ReportType == type && r.ReportDate.ToShortDateString() == date);

                if (match != null)
                    reportID = match.ReportID;
            }

            if (!string.IsNullOrEmpty(reportID))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this report?", "Delete Report", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    await helper.DeleteReport(reportID);
                    await LoadReportsFromFirebase();
                    DisplayReports(reportType);
                }
            }
            else
            {
                MessageBox.Show("Unable to determine Report ID for deletion.");
            }
        }
    }
}
