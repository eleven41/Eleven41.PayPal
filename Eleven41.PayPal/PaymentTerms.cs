using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public enum PaymentTerms
	{
		DueOnReceipt,
		DueOnDateSpecified,
		Net10,
		Net15,
		Net30,
		Net45,
	}
}
