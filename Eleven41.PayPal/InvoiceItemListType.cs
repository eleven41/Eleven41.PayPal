using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class InvoiceItemListType
	{
		[DataMember(Name = "item")]
		public List<InvoiceItemType> Items { get; set; }
	}
}
