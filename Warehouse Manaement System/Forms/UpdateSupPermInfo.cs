﻿using WareHouse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse.Forms
{
	public partial class UpdateSupPermInfo : Form
	{
		public ListViewItem RecordData { get; set; }
		public WareHouseSystem Db { get; set; } = new WareHouseSystem();

		public UpdateSupPermInfo(ListViewItem recordData)
		{
			InitializeComponent();
			this.RecordData = recordData;
			DisplayComboBoxesData();
			DisplayRecordData();
		}

		private void DisplayRecordData()
		{
			SupPermDateFld.Value = DateTime.Parse(RecordData.SubItems[2].Text);
		}

		private void DisplayComboBoxesData()
		{
			ShowStoreName();
			DisplaySuppliers();
			DisplayProducts();
		}

		

		private void DisplaySuppliers()
		{
			SuppliersNamesCombo.Items.Clear();
			var sups = Db.Suppliers.Select(s => s.Sup_Name).ToList();
			foreach (var sup in sups)
			{
				SuppliersNamesCombo.Items.Add(sup);
			}
		}

		private void ShowStoreName()
		{
			StoresNamesCombo.Items.Clear();
			var stores = Db.Stores.Select(s => s.Store_Name).ToList();
			foreach (var store in stores)
			{
				StoresNamesCombo.Items.Add(store);
			}
		}
		private void DisplayProducts()
		{
			ProdNamesCombo.Items.Clear();
			var prods = Db.Products.Select(p => p.Prod_Name).ToList();
			foreach (var prod in prods)
			{
				ProdNamesCombo.Items.Add(prod);
			}
		}
		private void ProdNamesCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			int supPermId = int.Parse(RecordData.SubItems[0].Text);
			int prodId = Db.Products.Where(p => p.Prod_Name == ProdNamesCombo.Text).Select(p => p.Prod_Id).FirstOrDefault();
			var sup_prod = Db.Supplied_Prod.Where(s => s.Prod_Id == prodId && s.SupPerm_Id == supPermId).FirstOrDefault();
			if (sup_prod != null)
			{
				ProdQtyFld.Text = sup_prod.Qty.ToString();
				ProdProddateFld.Value = sup_prod.Production_Date.Value;
				ProdExpiryFld.Text = sup_prod.Expiry.ToString();
			}
			else
			{
				MessageBox.Show("You Have Selected unavailable Product in The Current Permission.");
			}
		}

		private void UpdateProductInfo_Click(object sender, EventArgs e)
		{
			int prodId = Db.Products.Where(p => p.Prod_Name == ProdNamesCombo.Text).Select(p => p.Prod_Id).FirstOrDefault();
			int permId = int.Parse(RecordData.SubItems[0].Text);
			var sup_prod = Db.Supplied_Prod.Where(s => s.Prod_Id == prodId && s.SupPerm_Id == permId).FirstOrDefault();
			if (sup_prod != null)
			{
				sup_prod.Qty = int.Parse(ProdQtyFld.Text);
				sup_prod.Production_Date = ProdProddateFld.Value;
				sup_prod.Expiry = int.Parse(ProdExpiryFld.Text);

				var stock = Db.Stocks.Where(s => s.Prod_Id == prodId && s.Store_Id == sup_prod.SupplyPermission.Store_Id).FirstOrDefault();
				if (stock != null)
				{
					stock.Qty = sup_prod.Qty;
				}
				Db.SaveChanges();
				MessageBox.Show("Product Info Updated Successfully");
				ClearProdFields();
			}
			else
			{
				MessageBox.Show("Product Unavilable!");
			}
		}

		private void ClearProdFields()
		{
				ProdProddateFld.Text = ProdNamesCombo.Text = ProdQtyFld.Text = ProdExpiryFld.Text = String.Empty;
		}

		private void AddProductToPermission_Click(object sender, EventArgs e)
		{
			int prodId = Db.Products.Where(p => p.Prod_Name == ProdNamesCombo.Text).Select(p => p.Prod_Id).FirstOrDefault();
			var sup_prod = Db.Supplied_Prod.Where(s => s.Prod_Id == prodId).FirstOrDefault();

			int Prod_Id = Db.Products.Where(p => p.Prod_Name == ProdNamesCombo.Text).Select(p => p.Prod_Id).FirstOrDefault();

			if (sup_prod == null)
			{
				Supplied_Prod supplied_Prod = new Supplied_Prod()
				{
					SupPerm_Id = int.Parse(RecordData.SubItems[0].Text),
					Prod_Id = Prod_Id,
					Qty = int.Parse(ProdQtyFld.Text),
					Production_Date = ProdProddateFld.Value,
					Expiry = int.Parse(ProdExpiryFld.Text)
				};
				Db.Supplied_Prod.Add(supplied_Prod);
				Stock stock = new Stock()
				{
					Prod_Id = prodId,
					Store_Id = int.Parse(RecordData.SubItems[1].Text),
					Qty = int.Parse(ProdQtyFld.Text)
				};
				Db.Stocks.Add(stock);
				Db.SaveChanges();
				MessageBox.Show("Product Info Were Added Successfully");
				ClearProdFields();
			}
			else
			{
				MessageBox.Show("This Product Already Exists");
			}
		}

		private void UpdateSupPermbtn_Click(object sender, EventArgs e)
		{
			if(
					SuppliersNamesCombo.Text != String.Empty && StoresNamesCombo.Text != String.Empty && SupPermDateFld.Text != String.Empty
				)
			{
				int supPermId = int.Parse(RecordData.SubItems[0].Text);
				var supPerm = Db.SupplyPermissions.Where(s => s.SupPerm_Id == supPermId).FirstOrDefault();

				int storeId = Db.Stores.Where(s => s.Store_Name == StoresNamesCombo.Text).Select(s => s.Store_Id).FirstOrDefault();
				DateTime permDate = SupPermDateFld.Value;
				int supId = Db.Suppliers.Where(s => s.Sup_Name == SuppliersNamesCombo.Text).Select(s => s.Sup_Id).FirstOrDefault();

				supPerm.Store_Id = storeId;
				supPerm.SupPerm_Date = permDate;
				supPerm.Sup_Id = supId;
				Db.SaveChanges();
				ClearSupPermFields();
				MessageBox.Show("Supply Permission Info Was Updated Successfully");
			}
			else
			{
				MessageBox.Show("Some Supply Permission Fields Are Empty");
			}
		}

		private void ClearSupPermFields()
		{
			SupPermDateFld.Text = SuppliersNamesCombo.Text = StoresNamesCombo.Text = String.Empty;
		}
	}
}
