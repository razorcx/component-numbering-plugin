using Tekla.Structures.Plugins;

namespace ComponentNumberingPlugin
{
	public class PluginData
	{
		[StructuresField("phaseNumber")]
		public int PhaseNumber;
		[StructuresField("partPrefix")]
		public string PartPrefix;
		[StructuresField("assemblyPrefix")]
		public string AssemblyPrefix;
		[StructuresField("partStartNumber")]
		public int PartStartNumber;
		[StructuresField("assemblyStartNumber")]
		public int AssemblyStartNumber;
	}
}