namespace InventoryManagementApp
{
    partial class txtInventory
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
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbInventory = new System.Windows.Forms.Label();
            this.txtinvent = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.txtMaxParts = new System.Windows.Forms.TextBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.txtMinParts = new System.Windows.Forms.TextBox();
            this.lbMachineID = new System.Windows.Forms.Label();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.btnSaveParts = new System.Windows.Forms.Button();
            this.btnCancelParts = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(55, 44);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(195, 44);
            this.rbInHouse.TabIndex = 0;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(55, 139);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(238, 44);
            this.rbOutsourced.TabIndex = 1;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(51, 241);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(43, 32);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(193, 241);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(340, 37);
            this.txtID.TabIndex = 3;
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.Location = new System.Drawing.Point(53, 331);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(139, 32);
            this.lbInventory.TabIndex = 4;
            this.lbInventory.Text = "Inventory";
            // 
            // txtinvent
            // 
            this.txtinvent.Location = new System.Drawing.Point(193, 338);
            this.txtinvent.Multiline = true;
            this.txtinvent.Name = "txtinvent";
            this.txtinvent.Size = new System.Drawing.Size(340, 36);
            this.txtinvent.TabIndex = 5;
            this.txtinvent.TextChanged += new System.EventHandler(this.txtinvent_TextChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(49, 492);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(84, 32);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(193, 512);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(340, 32);
            this.txtPrice.TabIndex = 7;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(49, 617);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(70, 32);
            this.lbMax.TabIndex = 8;
            this.lbMax.Text = "Max";
            // 
            // txtMaxParts
            // 
            this.txtMaxParts.Location = new System.Drawing.Point(193, 605);
            this.txtMaxParts.Multiline = true;
            this.txtMaxParts.Name = "txtMaxParts";
            this.txtMaxParts.Size = new System.Drawing.Size(340, 35);
            this.txtMaxParts.TabIndex = 9;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(49, 703);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(63, 32);
            this.lbMin.TabIndex = 10;
            this.lbMin.Text = "Min";
            // 
            // txtMinParts
            // 
            this.txtMinParts.Location = new System.Drawing.Point(193, 703);
            this.txtMinParts.Multiline = true;
            this.txtMinParts.Name = "txtMinParts";
            this.txtMinParts.Size = new System.Drawing.Size(340, 32);
            this.txtMinParts.TabIndex = 11;
            // 
            // lbMachineID
            // 
            this.lbMachineID.AutoSize = true;
            this.lbMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMachineID.Location = new System.Drawing.Point(55, 805);
            this.lbMachineID.Name = "lbMachineID";
            this.lbMachineID.Size = new System.Drawing.Size(166, 32);
            this.lbMachineID.TabIndex = 12;
            this.lbMachineID.Text = "Machine ID";
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(257, 794);
            this.txtMachineID.Multiline = true;
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(276, 43);
            this.txtMachineID.TabIndex = 13;
            // 
            // btnSaveParts
            // 
            this.btnSaveParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveParts.Location = new System.Drawing.Point(631, 887);
            this.btnSaveParts.Name = "btnSaveParts";
            this.btnSaveParts.Size = new System.Drawing.Size(138, 47);
            this.btnSaveParts.TabIndex = 14;
            this.btnSaveParts.Text = "Save";
            this.btnSaveParts.UseVisualStyleBackColor = true;
            this.btnSaveParts.Click += new System.EventHandler(this.btnSaveParts_Click);
            // 
            // btnCancelParts
            // 
            this.btnCancelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelParts.Location = new System.Drawing.Point(1014, 889);
            this.btnCancelParts.Name = "btnCancelParts";
            this.btnCancelParts.Size = new System.Drawing.Size(149, 42);
            this.btnCancelParts.TabIndex = 15;
            this.btnCancelParts.Text = "Cancel";
            this.btnCancelParts.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(53, 410);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 32);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 417);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 40);
            this.txtName.TabIndex = 17;
            // 
            // txtInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1000);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCancelParts);
            this.Controls.Add(this.btnSaveParts);
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
            this.Name = "txtInventory";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.txtInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.TextBox txtinvent;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.TextBox txtMaxParts;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.TextBox txtMinParts;
        private System.Windows.Forms.Label lbMachineID;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.Button btnSaveParts;
        private System.Windows.Forms.Button btnCancelParts;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
    }
}