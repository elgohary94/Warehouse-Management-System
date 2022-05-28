namespace WareHouse.Forms
{
    partial class SelectProductInPeriod
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
            this.FinishBtn = new System.Windows.Forms.Button();
            this.AddProdBtn = new System.Windows.Forms.Button();
            this.ProdNamesCombo = new System.Windows.Forms.ComboBox();
            this.ProdList = new System.Windows.Forms.ListBox();
            this.FromDateFld = new System.Windows.Forms.DateTimePicker();
            this.ToDateFld = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.IndianRed;
            this.FinishBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.Color.White;
            this.FinishBtn.Location = new System.Drawing.Point(31, 244);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(157, 29);
            this.FinishBtn.TabIndex = 41;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // AddProdBtn
            // 
            this.AddProdBtn.BackColor = System.Drawing.Color.IndianRed;
            this.AddProdBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProdBtn.Location = new System.Drawing.Point(362, 244);
            this.AddProdBtn.Name = "AddProdBtn";
            this.AddProdBtn.Size = new System.Drawing.Size(122, 29);
            this.AddProdBtn.TabIndex = 40;
            this.AddProdBtn.Text = "Add";
            this.AddProdBtn.UseVisualStyleBackColor = false;
            this.AddProdBtn.Click += new System.EventHandler(this.AddProdBtn_Click);
            // 
            // ProdNamesCombo
            // 
            this.ProdNamesCombo.FormattingEnabled = true;
            this.ProdNamesCombo.Location = new System.Drawing.Point(364, 204);
            this.ProdNamesCombo.Name = "ProdNamesCombo";
            this.ProdNamesCombo.Size = new System.Drawing.Size(119, 21);
            this.ProdNamesCombo.TabIndex = 39;
            // 
            // ProdList
            // 
            this.ProdList.FormattingEnabled = true;
            this.ProdList.Location = new System.Drawing.Point(364, 12);
            this.ProdList.Name = "ProdList";
            this.ProdList.Size = new System.Drawing.Size(120, 186);
            this.ProdList.TabIndex = 38;
            // 
            // FromDateFld
            // 
            this.FromDateFld.Location = new System.Drawing.Point(67, 182);
            this.FromDateFld.Name = "FromDateFld";
            this.FromDateFld.Size = new System.Drawing.Size(121, 20);
            this.FromDateFld.TabIndex = 42;
            // 
            // ToDateFld
            // 
            this.ToDateFld.Location = new System.Drawing.Point(67, 208);
            this.ToDateFld.Name = "ToDateFld";
            this.ToDateFld.Size = new System.Drawing.Size(121, 20);
            this.ToDateFld.TabIndex = 43;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(28, 185);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(35, 13);
            this.From.TabIndex = 44;
            this.From.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "To:";
            // 
            // SelectProductInPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From);
            this.Controls.Add(this.ToDateFld);
            this.Controls.Add(this.FromDateFld);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.AddProdBtn);
            this.Controls.Add(this.ProdNamesCombo);
            this.Controls.Add(this.ProdList);
            this.Name = "SelectProductInPeriod";
            this.Text = "SelectProductInPeriod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button AddProdBtn;
        private System.Windows.Forms.ComboBox ProdNamesCombo;
        private System.Windows.Forms.ListBox ProdList;
        private System.Windows.Forms.DateTimePicker FromDateFld;
        private System.Windows.Forms.DateTimePicker ToDateFld;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label1;
    }
}