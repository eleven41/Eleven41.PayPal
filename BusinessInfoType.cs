using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	public class BusinessInfoType
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string businessName { get; set; }
		public string phone { get; set; }
		public string fax { get; set; }
		public string website { get; set; }
		public BaseAddress address { get; set; }
	}
}
