using System;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class ModifyPartForm : Form
    {
        private Part partToModify;

        public ModifyPartForm(Part part)
        {
            InitializeComponent();

            if (part == null)
            {
                MessageBox.Show("No part selected.");
                this.Close();
                return;
            }

            partToModify = part;

            // Load data AFTER form is fully built
            this.Load += ModifyPartForm_Load;

            btnCancelParts.Click += btnCancel_Click;
        }

        // Fill form with existing data
        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            txtID.Text = partToModify.PartID.ToString();
            txtID.ReadOnly = true;

            txtName.Text = partToModify.Name;
            txtinvent.Text = partToModify.InStock.ToString();
            txtPrice.Text = partToModify.Price.ToString();
            txtMaxParts.Text = partToModify.Max.ToString();
            txtMinParts.Text = partToModify.Min.ToString();
        }

        // SAVE changes 
        private void btnSaveParts_Click(object sender, EventArgs e)
        {
            try
            {
                partToModify.Name = txtName.Text;
                partToModify.InStock = int.Parse(txtinvent.Text);
                partToModify.Price = decimal.Parse(txtPrice.Text);
                partToModify.Max = int.Parse(txtMaxParts.Text);
                partToModify.Min = int.Parse(txtMinParts.Text);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




