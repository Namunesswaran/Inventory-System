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
    public partial class frmTransactions : Form
    {
        private List<Transaction> allTransactions = new();
        public frmTransactions()
        {
            InitializeComponent();
        }
        private async void frmTransactions_Load(object sender, EventArgs e)
        {
            cmbTrans.Items.Clear();
            cmbTrans.Items.Add("All");
            cmbTrans.Items.Add("Stock In");
            cmbTrans.Items.Add("Sale");
            cmbTrans.SelectedIndex = 0;
            dtpTrans.Value = DateTime.Today;
            await LoadTransactions();
        }

        private async Task LoadTransactions()
        {
            var helper = new FirebaseHelper();
            allTransactions = await helper.GetAllTransactions();
            FilterTransactions();
        }

        private void FilterTransactions()
        {
            string selectedType = cmbTrans.SelectedItem?.ToString();
            DateTime selectedDate = dtpTrans.Value.Date;

            var filtered = allTransactions
                .Where(t => (selectedType == "All" || t.Type == selectedType) &&
                            t.Date.Date == selectedDate)
                .ToList();

            dgvTransactions.Rows.Clear();
            dgvTransactions.Columns.Clear();

            dgvTransactions.Columns.Add("ReferenceNo", "Reference No");
            dgvTransactions.Columns.Add("Type", "Type");
            dgvTransactions.Columns.Add("Date", "Date");
            dgvTransactions.Columns.Add("TotalAmount", "Total Amount (RM)");

            foreach (var t in filtered)
            {
                dgvTransactions.Rows.Add(
                    t.ReferenceNo,
                    t.Type,
                    t.Date.ToString("yyyy-MM-dd"),
                    t.TotalAmount.ToString("0.00")
                );
            }

            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void dtpTrans_ValueChanged(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private async void btnTransaction_Click(object sender, EventArgs e)
        {
            using (var entryForm = new frmTransactionEntry())
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadTransactions(); // Reload to reflect changes
                }
            }
        }
    }
}
