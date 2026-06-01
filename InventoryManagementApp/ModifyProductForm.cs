using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementApp
{
    public partial class ModifyProductForm : Form
    {
        private Product productToModify;

        public ModifyProductForm(Product product)
        {
            InitializeComponent();

            productToModify = product;

            this.Load += ModifyProductForm_Load;
        }

        // ================= LOAD DATA =================
        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            if (productToModify == null)
            {
                MessageBox.Show("No product selected.");
                this.Close();
                return;
            }

            txtID.Text = productToModify.ProductID.ToString();
            txtID.ReadOnly = true;

            txtResult.Text = productToModify.Name;
            txtinvent.Text = productToModify.InStock.ToString();
            txtPrice.Text = productToModify.Price.ToString();

            // SHOW associated parts (THIS IS REQUIRED)
            dvgPartsWithProducts.DataSource = null;
            dvgPartsWithProducts.DataSource = productToModify.AssociatedParts;
        }

        // ================= SAVE =================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // UPDATE existing product (NOT creating a new one)
                productToModify.Name = txtResult.Text;
                productToModify.InStock = int.Parse(txtinvent.Text);
                productToModify.Price = decimal.Parse(txtPrice.Text);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

