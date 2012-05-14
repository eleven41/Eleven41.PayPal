using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class GetInvoiceDetailsResponse
	{
		public ResponseEnvelope responseEnvelope { get; set; }
		public InvoiceType invoice { get; set; }
		public InvoiceDetailsType invoiceDetails { get; set; }
		public PaymentDetailsType paymentDetails { get; set; }
		public string invoiceURL { get; set; }
	}

	internal class GetInvoiceDetailsResponseEx : GetInvoiceDetailsResponse
	{
		public List<ResponseError> error { get; set; }
	}
}
