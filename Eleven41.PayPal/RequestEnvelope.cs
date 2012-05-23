using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class RequestEnvelope
	{
		[DataMember(Name = "detailLevel")]
		public string DetailLevel { get; set; }

		[DataMember(Name = "errorLanguage")]
		public string ErrorLanguage { get; set; }
	}
}
