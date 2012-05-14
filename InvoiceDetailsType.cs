using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class InvoiceDetailsType
	{
		public string status { get; set; }
		public double totalAmount { get; set; }
		public string origin { get; set; }
		public DateTime createdDate { get; set; }
		public string createdBy { get; set; }
		public DateTime? paidDate { get; set; }
	}
}
