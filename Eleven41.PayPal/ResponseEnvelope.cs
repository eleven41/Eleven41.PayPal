using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class ResponseEnvelope
	{
		public string ack { get; set; }
		public string timestamp { get; set; }
		public string correlationId { get; set; }
		public string build { get; set; }
	}
}
