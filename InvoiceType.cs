using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class InvoiceType
	{
		public string merchantEmail { get; set; }
		public string payerEmail { get; set; }
		public int? number { get; set; }
		public BusinessInfoType merchantInfo { get; set; }
		public InvoiceItemListType itemList { get; set; }
		public string currencyCode { get; set; }
		public PaymentTerms paymentTerms { get; set; }
		public double? discountPercent { get; set; }
		public string merchantMemo { get; set; }
		public BusinessInfoType billingInfo { get; set; }
		public string logoUrl { get; set; }
		public string note { get; set; }
	}
}
