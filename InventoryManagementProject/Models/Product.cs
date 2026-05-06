using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class Product
    {
        public string ProductID { get; set; } // Unique identifier
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double CostPrice { get; set; }
        public double SellPrice { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
    }
}
