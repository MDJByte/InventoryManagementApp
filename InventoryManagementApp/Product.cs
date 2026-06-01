using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public List<Part> AssociatedParts { get; set; } = new List<Part>();


        // CONSTRUCTOR
        public Product(int id, string name, int inventory, decimal price, int max, int min)
        {
            ProductID = id;
            Name = name;
            InStock = inventory;
            Price = price;
            Max = max;
            Min = min;
        }


        // METHODS
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(Part part)
        {
            return AssociatedParts.Remove(part);
        }

        public List<Part> LookupAssociatedPart(string searchTerm)
        {
            return AssociatedParts
            .Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()))
            .ToList();
        }
    }


}
