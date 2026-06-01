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
    public partial class AddProductForm : Form
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();

            dvgAllParts.DataSource = Inventory.AllParts;

            dvgPartsWithProducts.DataSource = associatedParts;
        }

        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            try
{
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                int inventory = int.Parse(txtinvent.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                int max = int.Parse(txtMaxParts.Text);
                int min = int.Parse(txtMinParts.Text);

                // Validation
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

                Product newProduct = new Product(id, name, inventory, price, max, min);

                Inventory.Products.Add(newProduct);

                this.Close();
            }
catch
{
                MessageBox.Show("Please enter valid numeric values.");
            }
        }
    }
}
