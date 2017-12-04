using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using Newtonsoft.Json;
using Tekla.Structures;

using Task = System.Threading.Tasks;

namespace ConnectionCheck
{
	[Plugin("ConnectionCheck")]
	[PluginUserInterface("ConnectionCheck.MainForm")]
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

				var filepath = Filepath(connection);

				//first time initializing plugin
				if (string.IsNullOrEmpty(Data.DetailedBy) 
					&& string.IsNullOrEmpty(Data.CheckedBy)
					&& string.IsNullOrEmpty(Data.DesignedBy)
					&& string.IsNullOrEmpty(Data.ApprovedBy))
				{
					WriteConnectionCheckHistory(string.Empty, filepath);
					return true;
				}

				if (string.IsNullOrEmpty(Data.DetailedBy))
				{
					MessageBox.Show("Detailed by field required");
					return false;
				}

				var connectionCheckHistory = ReadConnectionCheckHistory(filepath);
				var connectionCheck = GetConnectionCheck(connection);

				var lastCheckBase = 
					JsonConvert.DeserializeObject<ConnectionCheckBase>(JsonConvert.SerializeObject(connectionCheckHistory.LastOrDefault()));
				var connectionCheckBase =
					JsonConvert.DeserializeObject<ConnectionCheckBase>(JsonConvert.SerializeObject(connectionCheck));

				var lastCheckJson = JsonConvert.SerializeObject(lastCheckBase);
				var connectionCheckJson = JsonConvert.SerializeObject(connectionCheckBase);

				if (lastCheckJson.Equals(connectionCheckJson))
				{
					OpenConnectionCheckForm(new ConnectionCheckData
					{
						ConnectionCheckHistory = connectionCheckHistory,
						Connection = connection
					});
					return true;
				}

				connectionCheckHistory.Add(connectionCheck);

				var json = JsonConvert.SerializeObject(connectionCheckHistory, Formatting.Indented);
				WriteConnectionCheckHistory(json, filepath);

				OpenConnectionCheckForm(new ConnectionCheckData
				{
					ConnectionCheckHistory = connectionCheckHistory,
					Connection = connection
				});

				return true;
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}

			return true;
		}
		#endregion

		#region Private Methods

		private void OpenConnectionCheckForm(ConnectionCheckData connectionData)
		{
			Task.Task.Factory.StartNew(() =>
			{
				var form = Application.OpenForms["ConnectionCheckForm"];
				form?.Close();
				form = new ConnectionCheckForm(connectionData);
				Application.Run(form);
			});
		}

		private void WriteConnectionCheckHistory(string json, string filepath)
		{
			using (var writer = new StreamWriter(filepath))
				writer.Write(json);
		}

		private ConnectionCheckResult GetConnectionCheck(Connection connection)
		{
			connection.GetPhase(out Phase phase);

			return new ConnectionCheckResult
			{
				Id = connection.Identifier.ID,
				Phase = phase.PhaseNumber,
				Name = connection.Name,
				Number = connection.Number,
				DetailedBy = Data.DetailedBy,
				DetailedDate = Data.DetailedDate,
				DetailedComments = Data.DetailedComment,
				DesignedBy = Data.DesignedBy,
				DesignedDate = Data.DesignedDate,
				DesignedComments = Data.DesignedComment,
				CheckedBy = Data.CheckedBy,
				CheckedDate = Data.CheckedDate,
				CheckedComments = Data.CheckedComment,
				ApprovedBy = Data.ApprovedBy,
				ApprovedDate = Data.ApprovedDate,
				ApprovedComments = Data.ApprovedComment,
				PrimaryPart = connection.GetPrimaryObject() as Beam,
				SecondaryParts = connection.GetSecondaryObjects().OfType<Beam>().ToList(),
				ChildrenParts = connection.GetChildren().ToList().OfType<Beam>().ToList(),
				Connection = connection,
				Date = DateTime.Now,
			};
		}

		private string Filepath(Connection connection)
		{
			string modelpath = Model.GetInfo().ModelPath;
			var connectionCheckFolder = @"RazorCX\ConnectionChecker";
			var connectionCheckFile = $"{connection.Identifier.GUID}.json";
			var path = modelpath + @"\" + connectionCheckFolder;

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			return path + @"\" + connectionCheckFile;
		}

		private List<ConnectionCheckResult> ReadConnectionCheckHistory(string filepath)
		{
			var checkConnections = new List<ConnectionCheckResult>();

			try
			{
				var file = string.Empty;

				using (var reader = new StreamReader(filepath))
					file = reader.ReadToEnd();

				if (!string.IsNullOrEmpty(file))
					checkConnections =
						JsonConvert.DeserializeObject<List<ConnectionCheckResult>>(file);

				return checkConnections;
			}
			catch (Exception ex)
			{
				return checkConnections;
			}
		}
		#endregion
	}
}
