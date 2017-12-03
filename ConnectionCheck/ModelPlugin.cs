using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;

namespace ConnectionCheck
{
	public class PluginData
	{
		#region Fields
		//
		// Define the fields specified on the Form.
		//
		/* Some examples:
        [StructuresField("RebarName")]
        public string RebarName;

        [StructuresField("RebarSize")]
        public string RebarSize;

        [StructuresField("RebarGrade")]
        public string RebarGrade;

        [StructuresField("RebarBendingRadius")]
        public string RebarBendingRadius;

        [StructuresField("RebarClass")]
        public int RebarClass;

        [StructuresField("RebarSpacing")]
        public double RebarSpacing;
        */
		#endregion
	}

	[Plugin("ConnectionCheck")]
	[PluginUserInterface("ConnectionCheck.MainForm")]
	public class ConnectionCheck : PluginBase
	{
		#region Fields
		private Model _Model;
		private PluginData _Data;
		//
		// Define variables for the field values.
		//
		/* Some examples:
        private string _RebarName = string.Empty;
        private string _RebarSize = string.Empty;
        private string _RebarGrade = string.Empty;
        private ArrayList _RebarBendingRadius = new ArrayList();
        private int _RebarClass = new int();
        private double _RebarSpacing;
        */
		#endregion

		#region Properties
		private Model Model
		{
			get { return this._Model; }
			set { this._Model = value; }
		}

		private PluginData Data
		{
			get { return this._Data; }
			set { this._Data = value; }
		}
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
			//
			// This is an example for selecting two points; change this to suit your needs.
			//
			List<InputDefinition> PointList = new List<InputDefinition>();
			Picker Picker = new Picker();
			ArrayList PickedPoints = Picker.PickPoints(Picker.PickPointEnum.PICK_TWO_POINTS);

			PointList.Add(new InputDefinition(PickedPoints));

			return PointList;
		}

		public override bool Run(List<InputDefinition> Input)
		{
			try
			{
				GetValuesFromDialog();

				//
				// This is an example for selecting two points; change this to suit your needs.
				//
				ArrayList Points = (ArrayList)Input[0].GetInput();
				Point StartPoint = Points[0] as Point;
				Point EndPoint = Points[1] as Point;

				//
				// Write your code here; better yet, create private methods and call them from here.
				//
			}
			catch (Exception Exc)
			{
				MessageBox.Show(Exc.ToString());
			}

			return true;
		}
		#endregion

		#region Private methods
		/// <summary>
		/// Gets the values from the dialog and sets the default values if needed
		/// </summary>
		private void GetValuesFromDialog()
		{
			/* Some examples:
            _RebarName = Data.RebarName;
            _RebarSize = Data.RebarSize;
            _RebarGrade = Data.RebarGrade;

            char[] Parameters = { ' ' };
            string[] Radiuses = Data.RebarBendingRadius.Split(Parameters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string Item in Radiuses)
                _RebarBendingRadius.Add(Convert.ToDouble(Item));

            _RebarClass = Data.RebarClass;
            _RebarSpacing = Data.RebarSpacing;

            if (IsDefaultValue(_RebarName))
                _RebarName = "REBAR";
            if (IsDefaultValue(_RebarSize))
                _RebarSize = "12";
            if (IsDefaultValue(_RebarGrade))
                _RebarGrade = "Undefined";
            if (_RebarBendingRadius.Count < 1)
                _RebarBendingRadius.Add(30.00);
            if (IsDefaultValue(_RebarClass) || _RebarClass <= 0)
                _RebarClass = 99;
            if (IsDefaultValue(_RebarSpacing) || _RebarSpacing <= 0)
                _RebarSpacing = 200.0;
            */
		}

		// Write your private methods here.

		#endregion
	}
}
