using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class CreateInvoiceResponse
	{
		public ResponseEnvelope responseEnvelope { get; set; }
		public string invoiceID { get; set; }
		public string invoiceNumber { get; set; }
		public string invoiceURL { get; set; }
	}

	internal class CreateInvoiceResponseEx : CreateInvoiceResponse
	{
		public List<ResponseError> error { get; set; }
	}
}
