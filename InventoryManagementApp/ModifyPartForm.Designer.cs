namespace InventoryManagementApp
{
    partial class ModifyPartForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCancelParts = new System.Windows.Forms.Button();
            this.btnSaveParts = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(352, 321);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 40);
            this.txtName.TabIndex = 35;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(212, 314);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 32);
            this.lbName.TabIndex = 34;
            this.lbName.Text = "Name";
            // 
            // btnCancelParts
            // 
            this.btnCancelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelParts.Location = new System.Drawing.Point(1173, 793);
            this.btnCancelParts.Name = "btnCancelParts";
            this.btnCancelParts.Size = new System.Drawing.Size(149, 42);
            this.btnCancelParts.TabIndex = 33;
            this.btnCancelParts.Text = "Cancel";
            this.btnCancelParts.UseVisualStyleBackColor = true;
            // 
            // btnSaveParts
            // 
            this.btnSaveParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveParts.Location = new System.Drawing.Point(790, 791);
            this.btnSaveParts.Name = "btnSaveParts";
            this.btnSaveParts.Size = new System.Drawing.Size(138, 47);
            this.btnSaveParts.TabIndex = 32;
            this.btnSaveParts.Text = "Save";
            this.btnSaveParts.UseVisualStyleBackColor = true;
            this.btnSaveParts.Click += new System.EventHandler(this.btnSaveParts_Click);
            // 
            // txtMachineID
            // 
            this.txtMachineID.Location = new System.Drawing.Point(416, 698);
            this.txtMachineID.Multiline = true;
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(276, 43);
            this.txtMachineID.TabIndex = 31;
            // 
            // lbMachineID
            // 
            this.lbMachineID.AutoSize = true;
            this.lbMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMachineID.Location = new System.Drawing.Point(214, 709);
            this.lbMachineID.Name = "lbMachineID";
            this.lbMachineID.Size = new System.Drawing.Size(166, 32);
            this.lbMachineID.TabIndex = 30;
            this.lbMachineID.Text = "Machine ID";
            // 
            // txtMinParts
            // 
            this.txtMinParts.Location = new System.Drawing.Point(352, 607);
            this.txtMinParts.Multiline = true;
            this.txtMinParts.Name = "txtMinParts";
            this.txtMinParts.Size = new System.Drawing.Size(340, 32);
            this.txtMinParts.TabIndex = 29;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(219, 509);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(63, 32);
            this.lbMin.TabIndex = 28;
            this.lbMin.Text = "Min";
            // 
            // txtMaxParts
            // 
            this.txtMaxParts.Location = new System.Drawing.Point(352, 509);
            this.txtMaxParts.Multiline = true;
            this.txtMaxParts.Name = "txtMaxParts";
            this.txtMaxParts.Size = new System.Drawing.Size(340, 35);
            this.txtMaxParts.TabIndex = 27;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(212, 607);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(70, 32);
            this.lbMax.TabIndex = 26;
            this.lbMax.Text = "Max";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(352, 416);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(340, 32);
            this.txtPrice.TabIndex = 25;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(208, 396);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(84, 32);
            this.lbPrice.TabIndex = 24;
            this.lbPrice.Text = "Price";
            // 
            // txtinvent
            // 
            this.txtinvent.Location = new System.Drawing.Point(352, 242);
            this.txtinvent.Multiline = true;
            this.txtinvent.Name = "txtinvent";
            this.txtinvent.Size = new System.Drawing.Size(340, 36);
            this.txtinvent.TabIndex = 23;
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.Location = new System.Drawing.Point(212, 235);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(139, 32);
            this.lbInventory.TabIndex = 22;
            this.lbInventory.Text = "Inventory";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(352, 145);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(340, 37);
            this.txtID.TabIndex = 21;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(210, 145);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(43, 32);
            this.lbID.TabIndex = 20;
            this.lbID.Text = "ID";
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(214, 43);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(238, 44);
            this.rbOutsourced.TabIndex = 19;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(214, -52);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(195, 44);
            this.rbInHouse.TabIndex = 18;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 883);
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
            this.Name = "ModifyPartForm";
            this.Text = "ModifyPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCancelParts;
        private System.Windows.Forms.Button btnSaveParts;
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
    }
}