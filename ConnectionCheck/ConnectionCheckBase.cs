namespace ConnectionCheck
{
	public class ConnectionCheckBase
	{
		public int Id { get; set; }
		public int Phase { get; set; }
		public string Name { get; set; }
		public int Number { get; set; }
		public string DetailedBy { get; set; }
		public string DetailedDate { get; set; }
		public string DetailedComments { get; set; }
		public string DesignedBy { get; set; }
		public string DesignedDate { get; set; }
		public string DesignedComments { get; set; }
		public string CheckedBy { get; set; }
		public string CheckedDate { get; set; }
		public string CheckedComments { get; set; }
		public string ApprovedBy { get; set; }
		public string ApprovedDate { get; set; }
		public string ApprovedComments { get; set; }
	}
}