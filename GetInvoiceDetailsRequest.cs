using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class GetInvoiceDetailsRequest
	{
		public RequestEnvelope requestEnvelope { get; set; }
		public string invoiceID { get; set; }
	}
}
