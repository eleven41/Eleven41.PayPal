using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	internal class ResponseError
	{
		[DataMember(Name = "errorId")]
		public string ErrorId { get; set; }

		[DataMember(Name = "domain")]
		public string Domain { get; set; }

		[DataMember(Name = "subdomain")]
		public string Subdomain { get; set; }

		[DataMember(Name = "severity")]
		public string Severity { get; set; }

		[DataMember(Name = "category")]
		public string Category { get; set; }

		[DataMember(Name = "message")]
		public string Message { get; set; }
	}
}
