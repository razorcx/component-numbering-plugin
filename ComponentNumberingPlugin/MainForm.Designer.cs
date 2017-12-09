namespace ComponentNumberingPlugin
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
			this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
			this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAssemblyPrefix = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBoxPartPrefix = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBoxPhaseNumber = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// okApplyModifyGetOnOffCancel1
			// 
			this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
			this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
			this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
			this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 236);
			this.okApplyModifyGetOnOffCancel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
			this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(701, 36);
			this.okApplyModifyGetOnOffCancel1.TabIndex = 12;
			this.okApplyModifyGetOnOffCancel1.OkClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OkClicked);
			this.okApplyModifyGetOnOffCancel1.ApplyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ApplyClicked);
			this.okApplyModifyGetOnOffCancel1.ModifyClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_ModifyClicked);
			this.okApplyModifyGetOnOffCancel1.GetClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_GetClicked);
			this.okApplyModifyGetOnOffCancel1.OnOffClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_OnOffClicked);
			this.okApplyModifyGetOnOffCancel1.CancelClicked += new System.EventHandler(this.OkApplyModifyGetOnOffCancel_CancelClicked);
			// 
			// saveLoad1
			// 
			this.structuresExtender.SetAttributeName(this.saveLoad1, null);
			this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
			this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
			this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
			this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
			this.saveLoad1.HelpKeyword = "";
			this.saveLoad1.HelpUrl = "";
			this.saveLoad1.Location = new System.Drawing.Point(0, 0);
			this.saveLoad1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.saveLoad1.Name = "saveLoad1";
			this.saveLoad1.SaveAsText = "";
			this.saveLoad1.Size = new System.Drawing.Size(701, 53);
			this.saveLoad1.TabIndex = 13;
			this.saveLoad1.UserDefinedHelpFilePath = null;
			// 
			// textBox2
			// 
			this.structuresExtender.SetAttributeName(this.textBox2, "partStartNumber");
			this.structuresExtender.SetAttributeTypeName(this.textBox2, "Integer");
			this.structuresExtender.SetBindPropertyName(this.textBox2, "Text");
			this.textBox2.Location = new System.Drawing.Point(365, 195);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(55, 22);
			this.textBox2.TabIndex = 59;
			// 
			// label2
			// 
			this.structuresExtender.SetAttributeName(this.label2, null);
			this.structuresExtender.SetAttributeTypeName(this.label2, null);
			this.label2.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label2, null);
			this.label2.Location = new System.Drawing.Point(237, 198);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 17);
			this.label2.TabIndex = 58;
			this.label2.Text = "Part Start Number";
			// 
			// textBox1
			// 
			this.structuresExtender.SetAttributeName(this.textBox1, "assemblyStartNumber");
			this.structuresExtender.SetAttributeTypeName(this.textBox1, "Integer");
			this.structuresExtender.SetBindPropertyName(this.textBox1, "Text");
			this.textBox1.Location = new System.Drawing.Point(365, 167);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(55, 22);
			this.textBox1.TabIndex = 57;
			// 
			// label1
			// 
			this.structuresExtender.SetAttributeName(this.label1, null);
			this.structuresExtender.SetAttributeTypeName(this.label1, null);
			this.label1.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label1, null);
			this.label1.Location = new System.Drawing.Point(203, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 17);
			this.label1.TabIndex = 56;
			this.label1.Text = "Assembly Start Number";
			// 
			// textBoxAssemblyPrefix
			// 
			this.structuresExtender.SetAttributeName(this.textBoxAssemblyPrefix, "assemblyPrefix");
			this.structuresExtender.SetAttributeTypeName(this.textBoxAssemblyPrefix, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxAssemblyPrefix, "Text");
			this.textBoxAssemblyPrefix.Location = new System.Drawing.Point(128, 167);
			this.textBoxAssemblyPrefix.Name = "textBoxAssemblyPrefix";
			this.textBoxAssemblyPrefix.Size = new System.Drawing.Size(55, 22);
			this.textBoxAssemblyPrefix.TabIndex = 55;
			// 
			// label15
			// 
			this.structuresExtender.SetAttributeName(this.label15, null);
			this.structuresExtender.SetAttributeTypeName(this.label15, null);
			this.label15.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label15, null);
			this.label15.Location = new System.Drawing.Point(9, 170);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(107, 17);
			this.label15.TabIndex = 54;
			this.label15.Text = "Assembly Prefix";
			// 
			// textBoxPartPrefix
			// 
			this.structuresExtender.SetAttributeName(this.textBoxPartPrefix, "partPrefix");
			this.structuresExtender.SetAttributeTypeName(this.textBoxPartPrefix, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxPartPrefix, "Text");
			this.textBoxPartPrefix.Location = new System.Drawing.Point(128, 195);
			this.textBoxPartPrefix.Name = "textBoxPartPrefix";
			this.textBoxPartPrefix.Size = new System.Drawing.Size(55, 22);
			this.textBoxPartPrefix.TabIndex = 53;
			// 
			// label14
			// 
			this.structuresExtender.SetAttributeName(this.label14, null);
			this.structuresExtender.SetAttributeTypeName(this.label14, null);
			this.label14.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label14, null);
			this.label14.Location = new System.Drawing.Point(43, 198);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(73, 17);
			this.label14.TabIndex = 52;
			this.label14.Text = "Part Prefix";
			// 
			// textBoxPhaseNumber
			// 
			this.structuresExtender.SetAttributeName(this.textBoxPhaseNumber, "phaseNumber");
			this.structuresExtender.SetAttributeTypeName(this.textBoxPhaseNumber, "Integer");
			this.structuresExtender.SetBindPropertyName(this.textBoxPhaseNumber, "Text");
			this.textBoxPhaseNumber.Location = new System.Drawing.Point(128, 124);
			this.textBoxPhaseNumber.Name = "textBoxPhaseNumber";
			this.textBoxPhaseNumber.Size = new System.Drawing.Size(55, 22);
			this.textBoxPhaseNumber.TabIndex = 51;
			// 
			// label13
			// 
			this.structuresExtender.SetAttributeName(this.label13, null);
			this.structuresExtender.SetAttributeTypeName(this.label13, null);
			this.label13.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label13, null);
			this.label13.Location = new System.Drawing.Point(14, 127);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 17);
			this.label13.TabIndex = 50;
			this.label13.Text = "Phase Number";
			// 
			// pictureBox1
			// 
			this.structuresExtender.SetAttributeName(this.pictureBox1, null);
			this.structuresExtender.SetAttributeTypeName(this.pictureBox1, null);
			this.structuresExtender.SetBindPropertyName(this.pictureBox1, null);
			this.pictureBox1.Image = global::ComponentNumberingPlugin.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.structuresExtender.SetAttributeName(this, null);
			this.structuresExtender.SetAttributeTypeName(this, null);
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.structuresExtender.SetBindPropertyName(this, null);
			this.ClientSize = new System.Drawing.Size(701, 272);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxAssemblyPrefix);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.textBoxPartPrefix);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBoxPhaseNumber);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.saveLoad1);
			this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Component Numbering Plugin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
		private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAssemblyPrefix;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBoxPartPrefix;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxPhaseNumber;
		private System.Windows.Forms.Label label13;
	}
}