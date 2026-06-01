using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class txtProducts : Form
    {
        public txtProducts()
        {
            InitializeComponent();

            // ================= GRID SETUP (GOES HERE) =================
            dvgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgProducts.MultiSelect = false;

            dvgParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgParts.MultiSelect = false;

            // ================= SEED DATA =================
            if (!Inventory.AllParts.Any())
            {
                Inventory.AllParts.Add(new InHouse(1, "wheel", 5, 10, 10, 1, 101));
                Inventory.AllParts.Add(new InHouse(2, "seat", 3, 15, 10, 1, 102));
            }

            RefreshParts();
            RefreshProducts();
        }

        // ================= REFRESH METHODS =================
        private void RefreshParts()
        {
            dvgParts.DataSource = null;
            dvgParts.DataSource = Inventory.AllParts;
        }

        private void RefreshProducts()
        {
            dvgProducts.DataSource = null;
            dvgProducts.DataSource = Inventory.Products;
        }

        // ================= EXIT =================
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================= PARTS =================
        private void btnAddParts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Parts clicked");
        }

        private void btnDeleteParts_Click(object sender, EventArgs e)
        {
            if (dvgParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a part first.");
                return;
            }

            Part selectedPart =
                dvgParts.SelectedRows[0].DataBoundItem as Part;

            Inventory.AllParts.Remove(selectedPart);
            RefreshParts();
        }

        private void btnModifyParts_Click(object sender, EventArgs e)
        {
            if (dvgParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a part first.");
                return;
            }

            Part selectedPart =
                dvgParts.SelectedRows[0].DataBoundItem as Part;

            ModifyPartForm form = new ModifyPartForm(selectedPart);
            form.ShowDialog();

            RefreshParts();
        }

        // ================= PRODUCTS =================
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();
            form.ShowDialog();

            RefreshProducts();
        }

        private void btnModifyProducts_Click(object sender, EventArgs e)
        {
            if (dvgProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            var row = dvgProducts.SelectedRows[0];
            Product selectedProduct = row.DataBoundItem as Product;

            if (selectedProduct == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            ModifyProductForm form = new ModifyProductForm(selectedProduct);
            form.ShowDialog();

            RefreshProducts();
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (dvgProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            Product selectedProduct =
                dvgProducts.SelectedRows[0].DataBoundItem as Product;

            Inventory.Products.Remove(selectedProduct);
            RefreshProducts();
        }

        private void bubtnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (dvgProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            Product selectedProduct =
            dvgProducts.SelectedRows[0].DataBoundItem as Product;

            var confirm = MessageBox.Show(
            "Delete this product?",
            "Confirm Delete",
            MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Inventory.Products.Remove(selectedProduct);
                RefreshProducts();
            }
        }

        private void btnModifyParts_Click_1(object sender, EventArgs e)
        {
            if (dvgParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a part first.");
                return;
            }

            Part selectedPart =
            dvgParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            ModifyPartForm form = new ModifyPartForm(selectedPart);
            form.ShowDialog();

            RefreshParts();
        }

        private void btnDeleteParts_Click_1(object sender, EventArgs e)
        {
            if (dvgParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a part first.");
                return;
            }

            Part selectedPart =
            dvgParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            Inventory.AllParts.Remove(selectedPart);
            RefreshParts();
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchParts.Text.ToLower();

            var results = Inventory.AllParts
            .Where(p => p.Name.ToLower().Contains(searchText)
            || p.PartID.ToString().Contains(searchText))
            .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("No parts found.");
                return;
            }

            dvgParts.DataSource = null;
            dvgParts.DataSource = results;
        }
    }
}
