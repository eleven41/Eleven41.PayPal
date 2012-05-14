using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class BaseAddress
	{
		public string line1 { get; set; }
		public string line2 { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string postalCode { get; set; }
		public string countryCode { get; set; }
		public string type { get; set; }
	}
}
