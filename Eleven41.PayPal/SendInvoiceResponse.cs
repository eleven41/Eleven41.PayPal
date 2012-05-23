using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class SendInvoiceResponse
	{
		[DataMember(Name = "responseEnvelope")]
		public ResponseEnvelope ResponseEnvelope { get; set; }

		[DataMember(Name = "invoiceID")]
		public string InvoiceId { get; set; }

		[DataMember(Name = "invoiceURL")]
		public string InvoiceUrl { get; set; }
	}

	[DataContract]
	internal class SendInvoiceResponseEx : SendInvoiceResponse
	{
		[DataMember(Name = "error")]
		public List<ResponseError> Error { get; set; }
	}
}
