using System.Collections.Generic;
using Tekla.Structures.Model;

namespace ConnectionCheck
{
	public class ConnectionCheckData
	{
		public List<ConnectionCheckResult> ConnectionCheckHistory { get; set; }
		public Connection Connection { get; set; }
	}
}