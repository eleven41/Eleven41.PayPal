using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class InvoiceItemType
	{
		[DataMember(Name = "name")]
		public string Name { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "quantity")]
		public double Quantity { get; set; }

		[DataMember(Name = "unitPrice")]
		public double UnitPrice { get; set; }

		[DataMember(Name = "taxName")]
		public string TaxName { get; set; }

		[DataMember(Name = "taxRate")]
		public double? TaxRate { get; set; }
	}
}
