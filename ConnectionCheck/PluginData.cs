using Tekla.Structures.Plugins;

namespace ConnectionCheck
{
	public class PluginData
	{
		#region Fields

		[StructuresField("detailedBy")]
		public string DetailedBy;
		[StructuresField("detailedDate")]
		public string DetailedDate;
		[StructuresField("detailedComment")]
		public string DetailedComment;

		[StructuresField("checkedBy")]
		public string CheckedBy;
		[StructuresField("checkedDate")]
		public string CheckedDate;
		[StructuresField("checkedComment")]
		public string CheckedComment;

		[StructuresField("designedBy")]
		public string DesignedBy;
		[StructuresField("designedDate")]
		public string DesignedDate;
		[StructuresField("designedComment")]
		public string DesignedComment;

		[StructuresField("approvedBy")]
		public string ApprovedBy;
		[StructuresField("approvedDate")]
		public string ApprovedDate;
		[StructuresField("approvedComment")]
		public string ApprovedComment;

		#endregion
	}
}