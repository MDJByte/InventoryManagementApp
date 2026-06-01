using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace InventoryManagementApp
{
    public static class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static List<Product> Products = new List<Product>();
    }
}
