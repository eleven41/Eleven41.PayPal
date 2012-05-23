using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Eleven41.PayPal
{
	[DataContract]
	public class PaymentDetailsType
	{
		[DataMember(Name = "viaPayPal")]
		public bool IsViaPayPal { get; set; }

		[DataMember(Name = "paypalPayment")]
		public PayPalPaymentDetailsType PayPalPayment { get; set; }

		[DataMember(Name = "otherPayment")]
		public OtherPaymentDetailsType OtherPayment { get; set; }
	}
}
