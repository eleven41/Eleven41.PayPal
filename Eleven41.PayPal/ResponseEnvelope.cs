using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class ResponseEnvelope
	{
		[DataMember(Name = "ack")]
		public string Ack { get; set; }

		[DataMember(Name = "timestamp")]
		public string Timestamp { get; set; }

		[DataMember(Name = "correlationId")]
		public string CorrelationId { get; set; }

		[DataMember(Name = "build")]
		public string Build { get; set; }
	}
}
