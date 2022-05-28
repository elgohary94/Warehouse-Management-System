using WareHouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.ClassLib
{
	public class TransProduct
	{
		public int ProdId { get; set; }
		public DateTime ProdDate { get; set; }
		public Supplier Supplier { get; set; }
		public int Qty { get; set; }
		public int Exp { get; set; }
	}
}
