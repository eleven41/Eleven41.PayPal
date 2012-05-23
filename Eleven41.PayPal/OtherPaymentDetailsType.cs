using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class OtherPaymentDetailsType
	{
		[DataMember(Name = "method")]
		public string Method { get; set; }

		[DataMember(Name = "note")]
		public string Note { get; set; }

		[DataMember(Name = "date")]
		public DateTime Date { get; set; }
	}
}
