using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class Category
    {
            public static List<string> GetCategories()
            {
                return new List<string>
            {
                "Eletronics",
                "Toys",
                "Home Appliances",
                "Furniture",
                "Office Supplies",
                "Stationery",
            };
            }
        
    }
}
