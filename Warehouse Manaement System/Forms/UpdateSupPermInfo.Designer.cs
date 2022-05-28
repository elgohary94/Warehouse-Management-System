namespace WareHouse.Forms
{
    partial class UpdateSupPermInfo
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
            this.UpdateSupPermbtn = new System.Windows.Forms.Button();
            this.AddProductToPermission = new System.Windows.Forms.Button();
            this.UpdateProductInfo = new System.Windows.Forms.Button();
            this.ProdExpiryFld = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdProddateFld = new System.Windows.Forms.DateTimePicker();
            this.ProdQtyFld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdNamesCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SupPermDateFld = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.SuppliersNamesCombo = new System.Windows.Forms.ComboBox();
            this.StoresNamesCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UpdateSupPermbtn
            // 
            this.UpdateSupPermbtn.BackColor = System.Drawing.Color.IndianRed;
            this.UpdateSupPermbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSupPermbtn.ForeColor = System.Drawing.Color.White;
            this.UpdateSupPermbtn.Location = new System.Drawing.Point(225, 150);
            this.UpdateSupPermbtn.Name = "UpdateSupPermbtn";
            this.UpdateSupPermbtn.Size = new System.Drawing.Size(162, 31);
            this.UpdateSupPermbtn.TabIndex = 32;
            this.UpdateSupPermbtn.Text = "Update Supply Perm.";
            this.UpdateSupPermbtn.UseVisualStyleBackColor = false;
            this.UpdateSupPermbtn.Click += new System.EventHandler(this.UpdateSupPermbtn_Click);
            // 
            // AddProductToPermission
            // 
            this.AddProductToPermission.BackColor = System.Drawing.Color.IndianRed;
            this.AddProductToPermission.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProductToPermission.Location = new System.Drawing.Point(16, 135);
            this.AddProductToPermission.Name = "AddProductToPermission";
            this.AddProductToPermission.Size = new System.Drawing.Size(177, 23);
            this.AddProductToPermission.TabIndex = 23;
            this.AddProductToPermission.Text = "Add Product To Permisson";
            this.AddProductToPermission.UseVisualStyleBackColor = false;
            this.AddProductToPermission.Click += new System.EventHandler(this.AddProductToPermission_Click);
            // 
            // UpdateProductInfo
            // 
            this.UpdateProductInfo.BackColor = System.Drawing.Color.IndianRed;
            this.UpdateProductInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateProductInfo.Location = new System.Drawing.Point(16, 164);
            this.UpdateProductInfo.Name = "UpdateProductInfo";
            this.UpdateProductInfo.Size = new System.Drawing.Size(177, 23);
            this.UpdateProductInfo.TabIndex = 24;
            this.UpdateProductInfo.Text = "Update Product";
            this.UpdateProductInfo.UseVisualStyleBackColor = false;
            this.UpdateProductInfo.Click += new System.EventHandler(this.UpdateProductInfo_Click);
            // 
            // ProdExpiryFld
            // 
            this.ProdExpiryFld.Location = new System.Drawing.Point(126, 99);
            this.ProdExpiryFld.Name = "ProdExpiryFld";
            this.ProdExpiryFld.Size = new System.Drawing.Size(67, 20);
            this.ProdExpiryFld.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Expiry (Months)";
            // 
            // ProdProddateFld
            // 
            this.ProdProddateFld.Location = new System.Drawing.Point(126, 73);
            this.ProdProddateFld.Name = "ProdProddateFld";
            this.ProdProddateFld.Size = new System.Drawing.Size(67, 20);
            this.ProdProddateFld.TabIndex = 18;
            // 
            // ProdQtyFld
            // 
            this.ProdQtyFld.Location = new System.Drawing.Point(126, 47);
            this.ProdQtyFld.Name = "ProdQtyFld";
            this.ProdQtyFld.Size = new System.Drawing.Size(67, 20);
            this.ProdQtyFld.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Production Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // ProdNamesCombo
            // 
            this.ProdNamesCombo.FormattingEnabled = true;
            this.ProdNamesCombo.Location = new System.Drawing.Point(126, 20);
            this.ProdNamesCombo.Name = "ProdNamesCombo";
            this.ProdNamesCombo.Size = new System.Drawing.Size(67, 21);
            this.ProdNamesCombo.TabIndex = 18;
            this.ProdNamesCombo.SelectedIndexChanged += new System.EventHandler(this.ProdNamesCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Supplier";
            // 
            // SupPermDateFld
            // 
            this.SupPermDateFld.Location = new System.Drawing.Point(270, 44);
            this.SupPermDateFld.Name = "SupPermDateFld";
            this.SupPermDateFld.Size = new System.Drawing.Size(121, 20);
            this.SupPermDateFld.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(208, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 16);
            this.label24.TabIndex = 25;
            this.label24.Text = "Store";
            // 
            // SuppliersNamesCombo
            // 
            this.SuppliersNamesCombo.FormattingEnabled = true;
            this.SuppliersNamesCombo.Location = new System.Drawing.Point(270, 70);
            this.SuppliersNamesCombo.Name = "SuppliersNamesCombo";
            this.SuppliersNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.SuppliersNamesCombo.TabIndex = 30;
            // 
            // StoresNamesCombo
            // 
            this.StoresNamesCombo.FormattingEnabled = true;
            this.StoresNamesCombo.Location = new System.Drawing.Point(270, 17);
            this.StoresNamesCombo.Name = "StoresNamesCombo";
            this.StoresNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.StoresNamesCombo.TabIndex = 26;
            // 
            // UpdateSupPermInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 193);
            this.Controls.Add(this.UpdateProductInfo);
            this.Controls.Add(this.UpdateSupPermbtn);
            this.Controls.Add(this.AddProductToPermission);
            this.Controls.Add(this.ProdExpiryFld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupPermDateFld);
            this.Controls.Add(this.ProdProddateFld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdQtyFld);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SuppliersNamesCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoresNamesCombo);
            this.Controls.Add(this.ProdNamesCombo);
            this.Controls.Add(this.label3);
            this.Name = "UpdateSupPermInfo";
            this.Text = "UpdateSupPermInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateSupPermbtn;
        private System.Windows.Forms.Button AddProductToPermission;
        private System.Windows.Forms.TextBox ProdExpiryFld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ProdProddateFld;
        private System.Windows.Forms.TextBox ProdQtyFld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProdNamesCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker SupPermDateFld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox SuppliersNamesCombo;
        private System.Windows.Forms.ComboBox StoresNamesCombo;
        private System.Windows.Forms.Button UpdateProductInfo;
    }
}