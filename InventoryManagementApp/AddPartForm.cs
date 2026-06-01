using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementApp
{
    public partial class txtInventory : Form
    {
        public txtInventory()
        {
            InitializeComponent();

            btnCancelParts.Click += btnCancelParts_click;
        }

        private void txtInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveParts_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            int inventory = int.Parse(txtinvent.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int max = int.Parse(txtMaxParts.Text);
            int min = int.Parse(txtMinParts.Text);

            // VALIDATION
            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            Part newPart;

            if (rbInHouse.Checked)
            {
                int machineId = int.Parse(txtMachineID.Text);
                newPart = new InHouse( id,  name, inventory,  price,  max,  min, machineId);
            }
            else
            {
                string companyName = txtMachineID.Text;
                newPart = new Outsourced(id, name, inventory, price, max, min, companyName);
            }

            Inventory.AllParts.Add(newPart);
            this.Close();
        }

        private void btnCancelParts_click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtinvent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
