using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class PayPalPaymentDetailsType
	{
		[DataMember(Name = "transactionID")]
		public string TransactionId { get; set; }

		[DataMember(Name = "date")]
		public DateTime Date { get; set; }
	}
}
