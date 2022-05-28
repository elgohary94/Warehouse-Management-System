namespace WareHouse.Forms
{
    partial class AddSupPermDialog
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
            this.StoresNamesCombo = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SupPermDateFld = new System.Windows.Forms.DateTimePicker();
            this.SuppliersNamesCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProdExpiryFld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdProddateFld = new System.Windows.Forms.DateTimePicker();
            this.ProdQtyFld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdNamesCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitSupPermbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StoresNamesCombo
            // 
            this.StoresNamesCombo.FormattingEnabled = true;
            this.StoresNamesCombo.Location = new System.Drawing.Point(111, 108);
            this.StoresNamesCombo.Name = "StoresNamesCombo";
            this.StoresNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.StoresNamesCombo.TabIndex = 11;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(49, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 19);
            this.label24.TabIndex = 10;
            this.label24.Text = "Store";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date";
            // 
            // SupPermDateFld
            // 
            this.SupPermDateFld.Location = new System.Drawing.Point(111, 135);
            this.SupPermDateFld.Name = "SupPermDateFld";
            this.SupPermDateFld.Size = new System.Drawing.Size(121, 20);
            this.SupPermDateFld.TabIndex = 13;
            // 
            // SuppliersNamesCombo
            // 
            this.SuppliersNamesCombo.FormattingEnabled = true;
            this.SuppliersNamesCombo.Location = new System.Drawing.Point(111, 161);
            this.SuppliersNamesCombo.Name = "SuppliersNamesCombo";
            this.SuppliersNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.SuppliersNamesCombo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Supplier";
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.AddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProduct.Location = new System.Drawing.Point(429, 258);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(221, 30);
            this.AddProduct.TabIndex = 23;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProdExpiryFld
            // 
            this.ProdExpiryFld.Location = new System.Drawing.Point(539, 186);
            this.ProdExpiryFld.Name = "ProdExpiryFld";
            this.ProdExpiryFld.Size = new System.Drawing.Size(121, 20);
            this.ProdExpiryFld.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Expiry (Months)";
            // 
            // ProdProddateFld
            // 
            this.ProdProddateFld.Location = new System.Drawing.Point(539, 160);
            this.ProdProddateFld.Name = "ProdProddateFld";
            this.ProdProddateFld.Size = new System.Drawing.Size(121, 20);
            this.ProdProddateFld.TabIndex = 18;
            // 
            // ProdQtyFld
            // 
            this.ProdQtyFld.Location = new System.Drawing.Point(539, 134);
            this.ProdQtyFld.Name = "ProdQtyFld";
            this.ProdQtyFld.Size = new System.Drawing.Size(121, 20);
            this.ProdQtyFld.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Production Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // ProdNamesCombo
            // 
            this.ProdNamesCombo.FormattingEnabled = true;
            this.ProdNamesCombo.Location = new System.Drawing.Point(539, 107);
            this.ProdNamesCombo.Name = "ProdNamesCombo";
            this.ProdNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.ProdNamesCombo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Name";
            // 
            // SubmitSupPermbtn
            // 
            this.SubmitSupPermbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.SubmitSupPermbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitSupPermbtn.ForeColor = System.Drawing.Color.White;
            this.SubmitSupPermbtn.Location = new System.Drawing.Point(53, 256);
            this.SubmitSupPermbtn.Name = "SubmitSupPermbtn";
            this.SubmitSupPermbtn.Size = new System.Drawing.Size(221, 32);
            this.SubmitSupPermbtn.TabIndex = 24;
            this.SubmitSupPermbtn.Text = "Submit";
            this.SubmitSupPermbtn.UseVisualStyleBackColor = false;
            this.SubmitSupPermbtn.Click += new System.EventHandler(this.SubmitSupPermbtn_Click);
            // 
            // AddSupPermDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 300);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.SubmitSupPermbtn);
            this.Controls.Add(this.ProdExpiryFld);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SuppliersNamesCombo);
            this.Controls.Add(this.ProdProddateFld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProdQtyFld);
            this.Controls.Add(this.SupPermDateFld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoresNamesCombo);
            this.Controls.Add(this.ProdNamesCombo);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label3);
            this.Name = "AddSupPermDialog";
            this.Text = "AddSupPermDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StoresNamesCombo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SupPermDateFld;
        private System.Windows.Forms.ComboBox SuppliersNamesCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProdNamesCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdQtyFld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ProdProddateFld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.TextBox ProdExpiryFld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SubmitSupPermbtn;
    }
}