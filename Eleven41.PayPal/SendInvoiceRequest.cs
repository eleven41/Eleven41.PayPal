using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class SendInvoiceRequest
	{
		[DataMember(Name = "requestEnvelope")]
		public RequestEnvelope RequestEnvelope { get; set; }

		[DataMember(Name = "invoiceID")]
		public string InvoiceId { get; set; }
	}
}
