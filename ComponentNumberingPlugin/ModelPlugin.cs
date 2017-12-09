using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;

namespace ComponentNumberingPlugin
{
	[Plugin("ComponentNumberingPlugin")]
	[PluginUserInterface("ComponentNumberingPlugin.MainForm")]
	public class ConnectionCheck : PluginBase
	{
		#region Properties
		private Model Model { get; }
		private PluginData Data { get; }
		#endregion

		#region Constructor
		public ConnectionCheck(PluginData data)
		{
			Model = new Model();
			Data = data;
		}
		#endregion

		#region Overrides
		public override List<InputDefinition> DefineInput()
		{
			var inputList = new List<InputDefinition>();
			var picker = new Picker();

			Connection connection;
			do
			{
				connection = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_OBJECT) as Connection;
			}
			while (connection == null);

			inputList.Add(new InputDefinition(connection.Identifier));

			return inputList;
		}

		public override bool Run(List<InputDefinition> input)
		{
			try
			{
				var connection = Model.SelectModelObject((Identifier)input[0].GetInput()) as Connection;
				if (connection == null) return false;

				connection.GetPhase(out Phase phase);

				var parts = connection.GetChildren().ToList().OfType<Part>().ToList();
				var part = parts[0];
				if (part == null) MessageBox.Show("Not a part " + parts.Count);

				var newPartNumberPrefix = Data.PhaseNumber + Data.PartPrefix;
				var newAssemblyNumberPrefix = Data.PhaseNumber + Data.AssemblyPrefix;

				var newPartStartNumber = Data.PhaseNumber + Data.PartStartNumber;
				var newAssemblyStartNumber = Data.PhaseNumber + Data.AssemblyStartNumber;

				if (part.PartNumber.Prefix != newPartNumberPrefix)
				{
					part.PartNumber.Prefix = newPartNumberPrefix;
					part.Modify();
				}

				if (part.AssemblyNumber.Prefix != newAssemblyNumberPrefix)
				{
					part.AssemblyNumber.Prefix = newAssemblyNumberPrefix;
					part.Modify();
				}

				if (part.PartNumber.StartNumber != newPartStartNumber)
				{
					part.PartNumber.StartNumber = newPartStartNumber;
					part.Modify();
				}

				if (part.AssemblyNumber.StartNumber != newAssemblyStartNumber)
				{
					part.AssemblyNumber.StartNumber = newAssemblyStartNumber;
					part.Modify();
				}

				var partNumber = part.GetPartMark();

				var drawer = new GraphicsDrawer();
				drawer.DrawText(connection.GetCoordinateSystem().Origin, $"{part.PartNumber.Prefix} : {part.AssemblyNumber.Prefix} : {partNumber}",
					new Color(1, 1, 1));

				return true;
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}

			return true;
		}
		#endregion
	}
}
