namespace ConnectionCheck
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.saveLoad = new Tekla.Structures.Dialog.UIControls.SaveLoad();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.ParametersTabPage = new System.Windows.Forms.TabPage();
			this.OkApplyModifyGetOnOffCancel = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
			this.tableLayoutPanel.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.structuresExtender.SetAttributeName(this.tableLayoutPanel, null);
			this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel, null);
			this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel, null);
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.OkApplyModifyGetOnOffCancel, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.saveLoad, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel1";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(534, 414);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// saveLoad1
			// 
			this.structuresExtender.SetAttributeName(this.saveLoad, null);
			this.structuresExtender.SetAttributeTypeName(this.saveLoad, null);
			this.saveLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.structuresExtender.SetBindPropertyName(this.saveLoad, null);
			this.saveLoad.Dock = System.Windows.Forms.DockStyle.Top;
			this.saveLoad.Location = new System.Drawing.Point(3, 3);
			this.saveLoad.Name = "saveLoad1";
			this.saveLoad.SaveAsText = "";
			this.saveLoad.Size = new System.Drawing.Size(528, 43);
			this.saveLoad.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.structuresExtender.SetAttributeName(this.tabControl, null);
			this.structuresExtender.SetAttributeTypeName(this.tabControl, null);
			this.structuresExtender.SetBindPropertyName(this.tabControl, null);
			this.tabControl.Controls.Add(this.ParametersTabPage);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(3, 52);
			this.tabControl.Name = "tabControl1";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(528, 324);
			this.tabControl.TabIndex = 18;
			// 
			// ParametersTabPage
			// 
			this.structuresExtender.SetAttributeName(this.ParametersTabPage, null);
			this.structuresExtender.SetAttributeTypeName(this.ParametersTabPage, null);
			this.structuresExtender.SetBindPropertyName(this.ParametersTabPage, null);
			this.ParametersTabPage.Location = new System.Drawing.Point(4, 22);
			this.ParametersTabPage.Name = "ParametersTabPage";
			this.ParametersTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ParametersTabPage.Size = new System.Drawing.Size(520, 298);
			this.ParametersTabPage.TabIndex = 2;
			this.ParametersTabPage.Text = "albl_Parameters";
			this.ParametersTabPage.UseVisualStyleBackColor = true;
			// 
			// OkApplyModifyGetOnOffCancel
			// 
			this.structuresExtender.SetAttributeName(this.OkApplyModifyGetOnOffCancel, null);
			this.structuresExtender.SetAttributeTypeName(this.OkApplyModifyGetOnOffCancel, null);
			this.structuresExtender.SetBindPropertyName(this.OkApplyModifyGetOnOffCancel, null);
			this.OkApplyModifyGetOnOffCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.OkApplyModifyGetOnOffCancel.Location = new System.Drawing.Point(3, 382);
			this.OkApplyModifyGetOnOffCancel.Name = "OkApplyModifyGetOnOffCancel";
			this.OkApplyModifyGetOnOffCancel.Size = new System.Drawing.Size(528, 29);
			this.OkApplyModifyGetOnOffCancel.TabIndex = 19;
			this.OkApplyModifyGetOnOffCancel.OkClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OkClicked);
			this.OkApplyModifyGetOnOffCancel.ModifyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ModifyClicked);
			this.OkApplyModifyGetOnOffCancel.CancelClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_CancelClicked);
			this.OkApplyModifyGetOnOffCancel.OnOffClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OnOffClicked);
			this.OkApplyModifyGetOnOffCancel.GetClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_GetClicked);
			this.OkApplyModifyGetOnOffCancel.ApplyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ApplyClicked);
			// 
			// MainForm
			// 
			this.structuresExtender.SetAttributeName(this, null);
			this.structuresExtender.SetAttributeTypeName(this, null);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.structuresExtender.SetBindPropertyName(this, null);
			this.ClientSize = new System.Drawing.Size(534, 414);
			this.Controls.Add(this.tableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Model Plug-in";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad;
		private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel OkApplyModifyGetOnOffCancel;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage ParametersTabPage;
	}
}