using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class InvoiceItemType
	{
		public string name { get; set; }
		public string description { get; set; }
		public double quantity { get; set; }
		public double unitPrice { get; set; }
		public string taxName { get; set; }
		public double? taxRate { get; set; }
	}
}
