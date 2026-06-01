using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string companyName)
        : base(partID, name, inStock, price, min, max)
        {
            CompanyName = companyName;
        }

        public Outsourced() { }
    }
}
