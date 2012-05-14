using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class PaymentDetailsType
	{
		public bool viaPayPal { get; set; }
		public PayPalPaymentDetailsType paypalPayment { get; set; }
		public OtherPaymentDetailsType otherPayment { get; set; }
	}
}
