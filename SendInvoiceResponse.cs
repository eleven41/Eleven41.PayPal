using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class SendInvoiceResponse
	{
		public ResponseEnvelope responseEnvelope { get; set; }
		public string invoiceID { get; set; }
		public string invoiceURL { get; set; }
	}

	internal class SendInvoiceResponseEx : SendInvoiceResponse
	{
		public List<ResponseError> error { get; set; }
	}
}
