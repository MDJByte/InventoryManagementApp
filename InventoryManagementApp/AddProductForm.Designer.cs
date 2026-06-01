namespace InventoryManagementApp
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelProducts = new System.Windows.Forms.Button();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.lbMachineID = new System.Windows.Forms.Label();
            this.txtMinParts = new System.Windows.Forms.TextBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.txtMaxParts = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtinvent = new System.Windows.Forms.TextBox();
            this.lbInventory = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.dvgAllParts = new System.Windows.Forms.DataGridView();
            this.dvgPartsWithProducts = new System.Windows.Forms.DataGridView();
            this.btnSearchResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPartsWithProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelProducts
            // 
            this.btnCancelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProducts.Location = new System.Drawing.Point(1039, 892);
            this.btnCancelProducts.Name = "btnCancelProducts";
            this.btnCancelProducts.Size = new System.Drawing.Size(149, 47);
            this.btnCancelProducts.TabIndex = 31;
            this.btnCancelProducts.Text = "Cancel";
            this.btnCancelProducts.UseVisualStyleBackColor = true;
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProducts.Location = new System.Drawing.Point(632, 892);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(138, 47);
            this.btnSaveProducts.TabIndex = 30;
            this.btnSaveProducts.Text = "Save";
            this.btnSaveProducts.UseVisualStyleBackColor = true;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProducts_Click);
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(254, 799);
            this.txtMachineID.Multiline = true;
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(276, 32);
            this.txtMachineID.TabIndex = 29;
            // 
            // lbMachineID
            // 
            this.lbMachineID.AutoSize = true;
            this.lbMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMachineID.Location = new System.Drawing.Point(35, 799);
            this.lbMachineID.Name = "lbMachineID";
            this.lbMachineID.Size = new System.Drawing.Size(166, 32);
            this.lbMachineID.TabIndex = 28;
            this.lbMachineID.Text = "Machine ID";
            // 
            // txtMinParts
            // 
            this.txtMinParts.Location = new System.Drawing.Point(190, 673);
            this.txtMinParts.Multiline = true;
            this.txtMinParts.Name = "txtMinParts";
            this.txtMinParts.Size = new System.Drawing.Size(340, 32);
            this.txtMinParts.TabIndex = 27;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(40, 713);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(63, 32);
            this.lbMin.TabIndex = 26;
            this.lbMin.Text = "Min";
            // 
            // txtMaxParts
            // 
            this.txtMaxParts.Location = new System.Drawing.Point(202, 588);
            this.txtMaxParts.Multiline = true;
            this.txtMaxParts.Name = "txtMaxParts";
            this.txtMaxParts.Size = new System.Drawing.Size(340, 35);
            this.txtMaxParts.TabIndex = 25;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(40, 591);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(70, 32);
            this.lbMax.TabIndex = 24;
            this.lbMax.Text = "Max";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(202, 500);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(340, 32);
            this.txtPrice.TabIndex = 23;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(49, 500);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(84, 32);
            this.lbPrice.TabIndex = 22;
            this.lbPrice.Text = "Price";
            // 
            // txtinvent
            // 
            this.txtinvent.Location = new System.Drawing.Point(202, 322);
            this.txtinvent.Multiline = true;
            this.txtinvent.Name = "txtinvent";
            this.txtinvent.Size = new System.Drawing.Size(340, 36);
            this.txtinvent.TabIndex = 21;
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.Location = new System.Drawing.Point(62, 315);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(139, 32);
            this.lbInventory.TabIndex = 20;
            this.lbInventory.Text = "Inventory";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(202, 225);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(340, 37);
            this.txtID.TabIndex = 19;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(60, 225);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(43, 32);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID";
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(64, 123);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(238, 44);
            this.rbOutsourced.TabIndex = 17;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(64, 28);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(195, 44);
            this.rbInHouse.TabIndex = 16;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            // 
            // dvgAllParts
            // 
            this.dvgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAllParts.Location = new System.Drawing.Point(905, 112);
            this.dvgAllParts.Name = "dvgAllParts";
            this.dvgAllParts.RowHeadersWidth = 62;
            this.dvgAllParts.RowTemplate.Height = 28;
            this.dvgAllParts.Size = new System.Drawing.Size(869, 150);
            this.dvgAllParts.TabIndex = 32;
            // 
            // dvgPartsWithProducts
            // 
            this.dvgPartsWithProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPartsWithProducts.Location = new System.Drawing.Point(905, 473);
            this.dvgPartsWithProducts.Name = "dvgPartsWithProducts";
            this.dvgPartsWithProducts.RowHeadersWidth = 62;
            this.dvgPartsWithProducts.RowTemplate.Height = 28;
            this.dvgPartsWithProducts.Size = new System.Drawing.Size(884, 150);
            this.dvgPartsWithProducts.TabIndex = 33;
            // 
            // btnSearchResult
            // 
            this.btnSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchResult.Location = new System.Drawing.Point(915, 16);
            this.btnSearchResult.Name = "btnSearchResult";
            this.btnSearchResult.Size = new System.Drawing.Size(148, 47);
            this.btnSearchResult.TabIndex = 34;
            this.btnSearchResult.Text = "Search";
            this.btnSearchResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(497, 28);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(340, 35);
            this.txtResult.TabIndex = 35;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(51, 420);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 32);
            this.lbName.TabIndex = 36;
            this.lbName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 420);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 32);
            this.txtName.TabIndex = 37;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 951);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSearchResult);
            this.Controls.Add(this.dvgPartsWithProducts);
            this.Controls.Add(this.dvgAllParts);
            this.Controls.Add(this.btnCancelProducts);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.lbMachineID);
            this.Controls.Add(this.txtMinParts);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.txtMaxParts);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtinvent);
            this.Controls.Add(this.lbInventory);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInHouse);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPartsWithProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelProducts;
        private System.Windows.Forms.Button btnSaveProducts;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.Label lbMachineID;
        private System.Windows.Forms.TextBox txtMinParts;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.TextBox txtMaxParts;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtinvent;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.DataGridView dvgAllParts;
        private System.Windows.Forms.DataGridView dvgPartsWithProducts;
        private System.Windows.Forms.Button btnSearchResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
    }
}