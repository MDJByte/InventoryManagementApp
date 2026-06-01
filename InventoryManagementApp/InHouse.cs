using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
        :base(partID, name, inStock, price, max, min)
        {
            MachineID = machineID;
        }

        public InHouse() { }
    }
}
