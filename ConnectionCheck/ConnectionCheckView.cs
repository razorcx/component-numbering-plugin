using System;

namespace ConnectionCheck
{
	public class ConnectionCheckView : ConnectionCheckBase
	{
		public string PrimaryProfile { get; set; }
		public string Sec0Profile { get; set; }
		public string Sec1Profile { get; set; }
		public DateTime? Date { get; set; }
	}
}