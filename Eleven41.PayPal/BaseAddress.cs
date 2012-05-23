using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class BaseAddress
	{
		[DataMember(Name = "line1")]
		public string Line1 { get; set; }

		[DataMember(Name = "line2")]
		public string Line2 { get; set; }

		[DataMember(Name = "city")]
		public string City { get; set; }

		[DataMember(Name = "state")]
		public string State { get; set; }

		[DataMember(Name = "postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name = "countryCode")]
		public string CountryCode { get; set; }

		[DataMember(Name = "type")]
		public string Type { get; set; }
	}
}
