using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class Transaction
    {
        public string ReferenceNo { get; set; }
        public string Type { get; set; } // e.g., "Purchase", "Sale"
        public DateTime Date { get; set; }
        public string Category { get; set; } // Optional: for filtering
        public string Supplier { get; set; } // Optional: for filtering
        public List<TransactionProduct> Products { get; set; } = new List<TransactionProduct>();
        public double TotalAmount { get; set; }
    }

    public class TransactionProduct
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Subtotal => Quantity * UnitPrice;
    }
}
