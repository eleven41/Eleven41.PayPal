using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class CreateInvoiceRequest
	{
		[DataMember(Name = "requestEnvelope")]
		public RequestEnvelope RequestEnvelope { get; set; }

		[DataMember(Name = "invoice")]
		public InvoiceType Invoice { get; set; }
	}
}
