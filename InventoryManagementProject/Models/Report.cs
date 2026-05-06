using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class Report
    {
        public string ReportID { get; set; }
        public string ReportType { get; set; }
        public DateTime ReportDate { get; set; }
        public string Content { get; set; }

        public Report(string id, string type, string content)
        {
            ReportID = id;
            ReportType = type;
            ReportDate = DateTime.Now;
            Content = content;
        }

        public Report() { }
    }

    public class SalesReport : Report
    {
        public double TotalSales { get; set; }

        public SalesReport()
        {
            ReportType = "Sales";
        }

        public SalesReport(string id, string content, double totalSales)
            : base(id, "Sales", content)
        {
            TotalSales = totalSales;
        }
    }

    public class StockReport : Report
    {
        public int TotalItems { get; set; }
        public int LowStockItems { get; set; }

        public StockReport()
        {
            ReportType = "Stock";
        }

        public StockReport(string id, string content, int totalItems, int lowStockItems)
            : base(id, "Stock", content)
        {
            TotalItems = totalItems;
            LowStockItems = lowStockItems;
        }
    }
}
