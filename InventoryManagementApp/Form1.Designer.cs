namespace InventoryManagementApp
{
    partial class txtProducts
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbParts = new System.Windows.Forms.Label();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.dvgParts = new System.Windows.Forms.DataGridView();
            this.lbProducts = new System.Windows.Forms.Label();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearcProducts = new System.Windows.Forms.Button();
            this.dvgProducts = new System.Windows.Forms.DataGridView();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.btnModifyParts = new System.Windows.Forms.Button();
            this.btnDeleteParts = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnModifyProducts = new System.Windows.Forms.Button();
            this.bubtnDeleteProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(603, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(595, 46);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Inventory Management System";
            // 
            // lbParts
            // 
            this.lbParts.AutoSize = true;
            this.lbParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParts.Location = new System.Drawing.Point(31, 101);
            this.lbParts.Name = "lbParts";
            this.lbParts.Size = new System.Drawing.Size(106, 40);
            this.lbParts.TabIndex = 1;
            this.lbParts.Text = "Parts";
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Location = new System.Drawing.Point(237, 101);
            this.txtSearchParts.Multiline = true;
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(435, 40);
            this.txtSearchParts.TabIndex = 2;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchParts.Location = new System.Drawing.Point(772, 101);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(116, 40);
            this.btnSearchParts.TabIndex = 3;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // dvgParts
            // 
            this.dvgParts.AllowUserToAddRows = false;
            this.dvgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgParts.Location = new System.Drawing.Point(237, 178);
            this.dvgParts.Name = "dvgParts";
            this.dvgParts.RowHeadersWidth = 62;
            this.dvgParts.RowTemplate.Height = 28;
            this.dvgParts.Size = new System.Drawing.Size(790, 150);
            this.dvgParts.TabIndex = 4;
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.Location = new System.Drawing.Point(31, 563);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(167, 40);
            this.lbProducts.TabIndex = 5;
            this.lbProducts.Text = "Products";
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(237, 563);
            this.txtSearchProducts.Multiline = true;
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(435, 40);
            this.txtSearchProducts.TabIndex = 6;
            // 
            // btnSearcProducts
            // 
            this.btnSearcProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearcProducts.Location = new System.Drawing.Point(761, 563);
            this.btnSearcProducts.Name = "btnSearcProducts";
            this.btnSearcProducts.Size = new System.Drawing.Size(149, 41);
            this.btnSearcProducts.TabIndex = 7;
            this.btnSearcProducts.Text = "Search";
            this.btnSearcProducts.UseVisualStyleBackColor = true;
            // 
            // dvgProducts
            // 
            this.dvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProducts.Location = new System.Drawing.Point(237, 639);
            this.dvgProducts.Name = "dvgProducts";
            this.dvgProducts.RowHeadersWidth = 62;
            this.dvgProducts.RowTemplate.Height = 28;
            this.dvgProducts.Size = new System.Drawing.Size(790, 150);
            this.dvgProducts.TabIndex = 8;
            // 
            // btnAddParts
            // 
            this.btnAddParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParts.Location = new System.Drawing.Point(237, 383);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(133, 50);
            this.btnAddParts.TabIndex = 9;
            this.btnAddParts.Text = "Add";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // btnModifyParts
            // 
            this.btnModifyParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyParts.Location = new System.Drawing.Point(544, 383);
            this.btnModifyParts.Name = "btnModifyParts";
            this.btnModifyParts.Size = new System.Drawing.Size(128, 50);
            this.btnModifyParts.TabIndex = 10;
            this.btnModifyParts.Text = "Modify";
            this.btnModifyParts.UseVisualStyleBackColor = true;
            this.btnModifyParts.Click += new System.EventHandler(this.btnModifyParts_Click_1);
            // 
            // btnDeleteParts
            // 
            this.btnDeleteParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteParts.Location = new System.Drawing.Point(910, 383);
            this.btnDeleteParts.Name = "btnDeleteParts";
            this.btnDeleteParts.Size = new System.Drawing.Size(117, 50);
            this.btnDeleteParts.TabIndex = 11;
            this.btnDeleteParts.Text = "Delete";
            this.btnDeleteParts.UseVisualStyleBackColor = true;
            this.btnDeleteParts.Click += new System.EventHandler(this.btnDeleteParts_Click_1);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.Location = new System.Drawing.Point(237, 844);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(133, 56);
            this.btnAddProducts.TabIndex = 12;
            this.btnAddProducts.Text = "Add";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnModifyProducts
            // 
            this.btnModifyProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProducts.Location = new System.Drawing.Point(544, 844);
            this.btnModifyProducts.Name = "btnModifyProducts";
            this.btnModifyProducts.Size = new System.Drawing.Size(128, 56);
            this.btnModifyProducts.TabIndex = 13;
            this.btnModifyProducts.Text = "Modify";
            this.btnModifyProducts.UseVisualStyleBackColor = true;
            this.btnModifyProducts.Click += new System.EventHandler(this.btnModifyProducts_Click);
            // 
            // bubtnDeleteProducts
            // 
            this.bubtnDeleteProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubtnDeleteProducts.Location = new System.Drawing.Point(910, 844);
            this.bubtnDeleteProducts.Name = "bubtnDeleteProducts";
            this.bubtnDeleteProducts.Size = new System.Drawing.Size(117, 56);
            this.bubtnDeleteProducts.TabIndex = 14;
            this.bubtnDeleteProducts.Text = "Delete";
            this.bubtnDeleteProducts.UseVisualStyleBackColor = true;
            this.bubtnDeleteProducts.Click += new System.EventHandler(this.bubtnDeleteProducts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1689, 950);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 41);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 1003);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bubtnDeleteProducts);
            this.Controls.Add(this.btnModifyProducts);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.btnDeleteParts);
            this.Controls.Add(this.btnModifyParts);
            this.Controls.Add(this.btnAddParts);
            this.Controls.Add(this.dvgProducts);
            this.Controls.Add(this.btnSearcProducts);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.dvgParts);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.lbParts);
            this.Controls.Add(this.lbTitle);
            this.Name = "txtProducts";
            this.Text = "0";
            ((System.ComponentModel.ISupportInitialize)(this.dvgParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbParts;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.DataGridView dvgParts;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Button btnSearcProducts;
        private System.Windows.Forms.DataGridView dvgProducts;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Button btnModifyParts;
        private System.Windows.Forms.Button btnDeleteParts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnModifyProducts;
        private System.Windows.Forms.Button bubtnDeleteProducts;
        private System.Windows.Forms.Button btnExit;
    }
}

