using System;
using System.Collections.Generic;
using Tekla.Structures.Model;

namespace ConnectionCheck
{
	public class ConnectionCheckResult : ConnectionCheckBase
	{
		public Connection Connection { get; set; }
		public Beam PrimaryPart { get; set; }
		public List<Beam> SecondaryParts { get; set; }
		public List<Beam> ChildrenParts { get; set; }
		public DateTime? Date { get; set; }
	}
}