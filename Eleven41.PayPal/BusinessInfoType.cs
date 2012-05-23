using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class BusinessInfoType
	{
		[DataMember(Name = "firstName")]
		public string FirstName { get; set; }

		[DataMember(Name = "lastName")]
		public string LastName { get; set; }

		[DataMember(Name = "businessName")]
		public string BusinessName { get; set; }

		[DataMember(Name = "phone")]
		public string Phone { get; set; }

		[DataMember(Name = "fax")]
		public string Fax { get; set; }

		[DataMember(Name = "website")]
		public string Website { get; set; }

		[DataMember(Name = "address")]
		public BaseAddress Address { get; set; }
	}
}
