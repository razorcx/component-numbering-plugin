using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ConnectionCheck
{
	public partial class ConnectionCheckForm : Form
	{
		private readonly ConnectionCheckData _connectionCheckData;

		public ConnectionCheckForm(ConnectionCheckData connectionCheckData)
		{
			_connectionCheckData = connectionCheckData;
			_connectionCheckData.ConnectionCheckHistory.Reverse();

			InitializeComponent();

			SetUiProperties();
		}

		private void SetUiProperties()
		{
			var connectionCheck = _connectionCheckData.ConnectionCheckHistory[0];

			textBoxConnectionName.Text = connectionCheck.Connection.Name;
			textBoxConnectionNumber.Text = connectionCheck.Connection.Number.ToString();
			textBoxConnectionClass.Text = connectionCheck.Connection.Class.ToString();
			textBoxConnectionCode.Text = connectionCheck.Connection.Code;
			textBoxPhase.Text = connectionCheck.Phase.ToString();
			textBoxGuid.Text = connectionCheck.Connection.Identifier.GUID.ToString();

			textBoxChecked.Text = connectionCheck.CheckedBy;
			textBoxCheckedDate.Text = connectionCheck.CheckedDate;
			richTextBoxCheckedComment.Text = connectionCheck.CheckedComments;

			textBoxDetailed.Text = connectionCheck.DetailedBy;
			textBoxDetailedDate.Text = connectionCheck.DetailedDate;
			richTextDetailedComment.Text = connectionCheck.DetailedComments;

			textBoxDesigned.Text = connectionCheck.DesignedBy;
			textBoxDesignedDate.Text = connectionCheck.DesignedDate;
			richTextBoxDesignedComment.Text = connectionCheck.DesignedComments;

			textBoxApproved.Text = connectionCheck.ApprovedBy;
			textBoxApprovedDate.Text = connectionCheck.ApprovedDate;
			richTextBoxApprovedComment.Text = connectionCheck.ApprovedComments;

			richTxtBoxConnectionDetails.Text = JsonConvert.SerializeObject(_connectionCheckData.ConnectionCheckHistory.First(),
				Formatting.Indented);

			dataGridViewCheckingHistory.DataSource = GetConnectionCheckView();
		}

		private List<ConnectionCheckView> GetConnectionCheckView()
		{
			return
				_connectionCheckData.ConnectionCheckHistory
					.Select(c => new ConnectionCheckView
					{
						Id = c.Id,
						Phase = c.Phase,
						Name = c.Name,
						Number = c.Number,
						DetailedBy = c.DetailedBy,
						DetailedDate = c.DetailedDate,
						DetailedComments = c.DetailedComments,
						DesignedBy = c.DesignedBy,
						DesignedDate = c.DesignedDate,
						DesignedComments = c.DesignedComments,
						CheckedBy = c.CheckedBy,
						CheckedDate = c.CheckedDate,
						CheckedComments = c.CheckedComments,
						ApprovedBy = c.ApprovedBy,
						ApprovedDate = c.ApprovedDate,
						ApprovedComments = c.ApprovedComments,
						PrimaryProfile = c.PrimaryPart.Profile.ProfileString,
						Sec0Profile = c.SecondaryParts.Count > 0 ? c.SecondaryParts[0].Profile.ProfileString : null,
						Sec1Profile = c.SecondaryParts.Count > 1 ? c.SecondaryParts[1].Profile.ProfileString : null,
						Date = c.Date
					}).ToList();
		}
	}
}
