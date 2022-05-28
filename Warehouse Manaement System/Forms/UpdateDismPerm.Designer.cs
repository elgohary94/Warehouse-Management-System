namespace WareHouse.Forms
{
    partial class UpdateDismPerm
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
            this.UpdateDismBtn = new System.Windows.Forms.Button();
            this.DismPermDateFld = new System.Windows.Forms.DateTimePicker();
            this.UpdateProductInfo = new System.Windows.Forms.Button();
            this.AddProductToPermission = new System.Windows.Forms.Button();
            this.ProdQtyFld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdNamesCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.CustomersNamesCombo = new System.Windows.Forms.ComboBox();
            this.StoresNamesCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UpdateDismBtn
            // 
            this.UpdateDismBtn.BackColor = System.Drawing.Color.DarkGray;
            this.UpdateDismBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDismBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateDismBtn.Location = new System.Drawing.Point(244, 223);
            this.UpdateDismBtn.Name = "UpdateDismBtn";
            this.UpdateDismBtn.Size = new System.Drawing.Size(191, 34);
            this.UpdateDismBtn.TabIndex = 40;
            this.UpdateDismBtn.Text = "Update Dismissal";
            this.UpdateDismBtn.UseVisualStyleBackColor = false;
            this.UpdateDismBtn.Click += new System.EventHandler(this.UpdateDismBtn_Click);
            // 
            // DismPermDateFld
            // 
            this.DismPermDateFld.Location = new System.Drawing.Point(314, 164);
            this.DismPermDateFld.Name = "DismPermDateFld";
            this.DismPermDateFld.Size = new System.Drawing.Size(121, 20);
            this.DismPermDateFld.TabIndex = 36;
            // 
            // UpdateProductInfo
            // 
            this.UpdateProductInfo.BackColor = System.Drawing.Color.IndianRed;
            this.UpdateProductInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateProductInfo.Location = new System.Drawing.Point(21, 223);
            this.UpdateProductInfo.Name = "UpdateProductInfo";
            this.UpdateProductInfo.Size = new System.Drawing.Size(186, 34);
            this.UpdateProductInfo.TabIndex = 26;
            this.UpdateProductInfo.Text = "Update Product";
            this.UpdateProductInfo.UseVisualStyleBackColor = false;
            this.UpdateProductInfo.Click += new System.EventHandler(this.UpdateProductInfo_Click);
            // 
            // AddProductToPermission
            // 
            this.AddProductToPermission.BackColor = System.Drawing.Color.IndianRed;
            this.AddProductToPermission.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProductToPermission.Location = new System.Drawing.Point(21, 184);
            this.AddProductToPermission.Name = "AddProductToPermission";
            this.AddProductToPermission.Size = new System.Drawing.Size(186, 33);
            this.AddProductToPermission.TabIndex = 25;
            this.AddProductToPermission.Text = "Add Product To Permisson";
            this.AddProductToPermission.UseVisualStyleBackColor = false;
            this.AddProductToPermission.Click += new System.EventHandler(this.AddProductToPermission_Click);
            // 
            // ProdQtyFld
            // 
            this.ProdQtyFld.Location = new System.Drawing.Point(86, 161);
            this.ProdQtyFld.Name = "ProdQtyFld";
            this.ProdQtyFld.Size = new System.Drawing.Size(121, 20);
            this.ProdQtyFld.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // ProdNamesCombo
            // 
            this.ProdNamesCombo.FormattingEnabled = true;
            this.ProdNamesCombo.Location = new System.Drawing.Point(86, 134);
            this.ProdNamesCombo.Name = "ProdNamesCombo";
            this.ProdNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.ProdNamesCombo.TabIndex = 18;
            this.ProdNamesCombo.SelectedIndexChanged += new System.EventHandler(this.ProdNamesCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(225, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(225, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 16);
            this.label24.TabIndex = 33;
            this.label24.Text = "Store";
            // 
            // CustomersNamesCombo
            // 
            this.CustomersNamesCombo.FormattingEnabled = true;
            this.CustomersNamesCombo.Location = new System.Drawing.Point(314, 190);
            this.CustomersNamesCombo.Name = "CustomersNamesCombo";
            this.CustomersNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.CustomersNamesCombo.TabIndex = 38;
            // 
            // StoresNamesCombo
            // 
            this.StoresNamesCombo.FormattingEnabled = true;
            this.StoresNamesCombo.Location = new System.Drawing.Point(314, 137);
            this.StoresNamesCombo.Name = "StoresNamesCombo";
            this.StoresNamesCombo.Size = new System.Drawing.Size(121, 21);
            this.StoresNamesCombo.TabIndex = 34;
            // 
            // UpdateDismPerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 269);
            this.Controls.Add(this.UpdateProductInfo);
            this.Controls.Add(this.UpdateDismBtn);
            this.Controls.Add(this.AddProductToPermission);
            this.Controls.Add(this.DismPermDateFld);
            this.Controls.Add(this.ProdQtyFld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProdNamesCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.CustomersNamesCombo);
            this.Controls.Add(this.StoresNamesCombo);
            this.Name = "UpdateDismPerm";
            this.Text = "UpdateDismPerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateDismBtn;
        private System.Windows.Forms.DateTimePicker DismPermDateFld;
        private System.Windows.Forms.TextBox ProdQtyFld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProdNamesCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox CustomersNamesCombo;
        private System.Windows.Forms.ComboBox StoresNamesCombo;
        private System.Windows.Forms.Button UpdateProductInfo;
        private System.Windows.Forms.Button AddProductToPermission;
    }
}