using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class Supplier
    {
        public static List<string> GetSuppliers()
        {
            return new List<string>
            {
                "Supplier A",
                "Supplier B",
                "Supplier C"
            };
        }
    }
}
