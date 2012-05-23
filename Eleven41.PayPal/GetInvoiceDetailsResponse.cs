using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class GetInvoiceDetailsResponse
	{
		[DataMember(Name = "responseEnvelope")]
		public ResponseEnvelope ResponseEnvelope { get; set; }

		[DataMember(Name = "invoice")]
		public InvoiceType Invoice { get; set; }

		[DataMember(Name = "invoiceDetails")]
		public InvoiceDetailsType InvoiceDetails { get; set; }

		[DataMember(Name = "paymentDetails")]
		public PaymentDetailsType PaymentDetails { get; set; }

		[DataMember(Name = "invoiceURL")]
		public string InvoiceURL { get; set; }
	}

	internal class GetInvoiceDetailsResponseEx : GetInvoiceDetailsResponse
	{
		[DataMember(Name = "error")]
		public List<ResponseError> Error { get; set; }
	}
}
