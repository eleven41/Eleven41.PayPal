using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class CreateInvoiceRequest
	{
		public RequestEnvelope requestEnvelope { get; set; }
		public InvoiceType invoice { get; set; }
	}
}
