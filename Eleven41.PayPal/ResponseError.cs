using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.PayPal
{
	internal class ResponseError
	{
		public string errorId { get; set; }
		public string domain { get; set; }
		public string subdomain { get; set; }
		public string severity { get; set; }
		public string category { get; set; }
		public string message { get; set; }
	}
}
