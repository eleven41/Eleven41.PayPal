using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class InvoiceDetailsType
	{
		[DataMember(Name = "status")]
		public string Status { get; set; }

		[DataMember(Name = "totalAmount")]
		public double TotalAmount { get; set; }

		[DataMember(Name = "origin")]
		public string Origin { get; set; }

		[DataMember(Name = "createdDate")]
		public DateTime CreatedDate { get; set; }

		[DataMember(Name = "createdBy")]
		public string CreatedBy { get; set; }

		[DataMember(Name = "paidDate")]
		public DateTime? PaidDate { get; set; }
	}
}
