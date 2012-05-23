using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class InvoiceType
	{
		[DataMember(Name = "merchantEmail")]
		public string MerchantEmail { get; set; }

		[DataMember(Name = "payerEmail")]
		public string PayerEmail { get; set; }

		[DataMember(Name = "number")]
		public string Number { get; set; }

		[DataMember(Name = "merchantInfo")]
		public BusinessInfoType MerchantInfo { get; set; }

		[DataMember(Name = "itemList")]
		public InvoiceItemListType ItemList { get; set; }

		[DataMember(Name = "currencyCode")]
		public string CurrencyCode { get; set; }

		[DataMember(Name = "paymentTerms")]
		public PaymentTerms PaymentTerms { get; set; }

		[DataMember(Name = "discountPercent")]
		public double? DiscountPercent { get; set; }

		[DataMember(Name = "merchantMemo")]
		public string MerchantMemo { get; set; }

		[DataMember(Name = "billingInfo")]
		public BusinessInfoType BillingInfo { get; set; }

		[DataMember(Name = "logoUrl")]
		public string LogoUrl { get; set; }

		[DataMember(Name = "note")]
		public string Note { get; set; }
	}
}
