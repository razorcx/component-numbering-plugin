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
			this.richTextDetailedComment = new System.Windows.Forms.RichTextBox();
			this.textBoxDeteiledDate = new System.Windows.Forms.TextBox();
			this.textBoxDetailedBy = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
			this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.richTextBoxDesignedComment = new System.Windows.Forms.RichTextBox();
			this.textBoxDesignedDate = new System.Windows.Forms.TextBox();
			this.textBoxDesignedBy = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.richTextBoxApprovedComment = new System.Windows.Forms.RichTextBox();
			this.textBoxApprovedDate = new System.Windows.Forms.TextBox();
			this.textBoxApprovedBy = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.richTextBoxCheckedComment = new System.Windows.Forms.RichTextBox();
			this.textBoxCheckedDate = new System.Windows.Forms.TextBox();
			this.textBoxCheckedBy = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextDetailedComment
			// 
			this.structuresExtender.SetAttributeName(this.richTextDetailedComment, "detailedComment");
			this.structuresExtender.SetAttributeTypeName(this.richTextDetailedComment, "String");
			this.structuresExtender.SetBindPropertyName(this.richTextDetailedComment, "Text");
			this.richTextDetailedComment.Location = new System.Drawing.Point(184, 134);
			this.richTextDetailedComment.Name = "richTextDetailedComment";
			this.richTextDetailedComment.Size = new System.Drawing.Size(507, 50);
			this.richTextDetailedComment.TabIndex = 11;
			this.richTextDetailedComment.Text = "";
			// 
			// textBoxDeteiledDate
			// 
			this.structuresExtender.SetAttributeName(this.textBoxDeteiledDate, "detailedDate");
			this.structuresExtender.SetAttributeTypeName(this.textBoxDeteiledDate, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxDeteiledDate, "Text");
			this.textBoxDeteiledDate.Location = new System.Drawing.Point(84, 134);
			this.textBoxDeteiledDate.Name = "textBoxDeteiledDate";
			this.textBoxDeteiledDate.Size = new System.Drawing.Size(94, 22);
			this.textBoxDeteiledDate.TabIndex = 9;
			// 
			// textBoxDetailedBy
			// 
			this.structuresExtender.SetAttributeName(this.textBoxDetailedBy, "detailedBy");
			this.structuresExtender.SetAttributeTypeName(this.textBoxDetailedBy, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxDetailedBy, "Text");
			this.textBoxDetailedBy.Location = new System.Drawing.Point(12, 134);
			this.textBoxDetailedBy.Name = "textBoxDetailedBy";
			this.textBoxDetailedBy.Size = new System.Drawing.Size(66, 22);
			this.textBoxDetailedBy.TabIndex = 7;
			// 
			// label3
			// 
			this.structuresExtender.SetAttributeName(this.label3, null);
			this.structuresExtender.SetAttributeTypeName(this.label3, null);
			this.label3.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label3, null);
			this.label3.Location = new System.Drawing.Point(184, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Detailed Comment";
			// 
			// label2
			// 
			this.structuresExtender.SetAttributeName(this.label2, null);
			this.structuresExtender.SetAttributeTypeName(this.label2, null);
			this.label2.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label2, null);
			this.label2.Location = new System.Drawing.Point(81, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Date";
			// 
			// label1
			// 
			this.structuresExtender.SetAttributeName(this.label1, null);
			this.structuresExtender.SetAttributeTypeName(this.label1, null);
			this.label1.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label1, null);
			this.label1.Location = new System.Drawing.Point(9, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Detailed";
			// 
			// okApplyModifyGetOnOffCancel1
			// 
			this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
			this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
			this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
			this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 421);
			this.okApplyModifyGetOnOffCancel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
			this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(704, 36);
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
			this.saveLoad1.Size = new System.Drawing.Size(704, 53);
			this.saveLoad1.TabIndex = 13;
			this.saveLoad1.UserDefinedHelpFilePath = null;
			// 
			// pictureBox1
			// 
			this.structuresExtender.SetAttributeName(this.pictureBox1, null);
			this.structuresExtender.SetAttributeTypeName(this.pictureBox1, null);
			this.structuresExtender.SetBindPropertyName(this.pictureBox1, null);
			this.pictureBox1.Image = global::ConnectionCheck.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// richTextBoxDesignedComment
			// 
			this.structuresExtender.SetAttributeName(this.richTextBoxDesignedComment, "designedComment");
			this.structuresExtender.SetAttributeTypeName(this.richTextBoxDesignedComment, "String");
			this.structuresExtender.SetBindPropertyName(this.richTextBoxDesignedComment, "Text");
			this.richTextBoxDesignedComment.Location = new System.Drawing.Point(184, 290);
			this.richTextBoxDesignedComment.Name = "richTextBoxDesignedComment";
			this.richTextBoxDesignedComment.Size = new System.Drawing.Size(507, 50);
			this.richTextBoxDesignedComment.TabIndex = 20;
			this.richTextBoxDesignedComment.Text = "";
			// 
			// textBoxDesignedDate
			// 
			this.structuresExtender.SetAttributeName(this.textBoxDesignedDate, "designedDate");
			this.structuresExtender.SetAttributeTypeName(this.textBoxDesignedDate, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxDesignedDate, "Text");
			this.textBoxDesignedDate.Location = new System.Drawing.Point(84, 290);
			this.textBoxDesignedDate.Name = "textBoxDesignedDate";
			this.textBoxDesignedDate.Size = new System.Drawing.Size(94, 22);
			this.textBoxDesignedDate.TabIndex = 18;
			// 
			// textBoxDesignedBy
			// 
			this.structuresExtender.SetAttributeName(this.textBoxDesignedBy, "designedBy");
			this.structuresExtender.SetAttributeTypeName(this.textBoxDesignedBy, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxDesignedBy, "Text");
			this.textBoxDesignedBy.Location = new System.Drawing.Point(12, 290);
			this.textBoxDesignedBy.Name = "textBoxDesignedBy";
			this.textBoxDesignedBy.Size = new System.Drawing.Size(66, 22);
			this.textBoxDesignedBy.TabIndex = 16;
			// 
			// label4
			// 
			this.structuresExtender.SetAttributeName(this.label4, null);
			this.structuresExtender.SetAttributeTypeName(this.label4, null);
			this.label4.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label4, null);
			this.label4.Location = new System.Drawing.Point(184, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Designed Comment";
			// 
			// label5
			// 
			this.structuresExtender.SetAttributeName(this.label5, null);
			this.structuresExtender.SetAttributeTypeName(this.label5, null);
			this.label5.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label5, null);
			this.label5.Location = new System.Drawing.Point(81, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Date";
			// 
			// label6
			// 
			this.structuresExtender.SetAttributeName(this.label6, null);
			this.structuresExtender.SetAttributeTypeName(this.label6, null);
			this.label6.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label6, null);
			this.label6.Location = new System.Drawing.Point(9, 269);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "Designed";
			// 
			// richTextBoxApprovedComment
			// 
			this.structuresExtender.SetAttributeName(this.richTextBoxApprovedComment, "approvedComment");
			this.structuresExtender.SetAttributeTypeName(this.richTextBoxApprovedComment, "String");
			this.structuresExtender.SetBindPropertyName(this.richTextBoxApprovedComment, "Text");
			this.richTextBoxApprovedComment.Location = new System.Drawing.Point(184, 366);
			this.richTextBoxApprovedComment.Name = "richTextBoxApprovedComment";
			this.richTextBoxApprovedComment.Size = new System.Drawing.Size(507, 50);
			this.richTextBoxApprovedComment.TabIndex = 26;
			this.richTextBoxApprovedComment.Text = "";
			// 
			// textBoxApprovedDate
			// 
			this.structuresExtender.SetAttributeName(this.textBoxApprovedDate, "approvedDate");
			this.structuresExtender.SetAttributeTypeName(this.textBoxApprovedDate, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxApprovedDate, "Text");
			this.textBoxApprovedDate.Location = new System.Drawing.Point(84, 366);
			this.textBoxApprovedDate.Name = "textBoxApprovedDate";
			this.textBoxApprovedDate.Size = new System.Drawing.Size(94, 22);
			this.textBoxApprovedDate.TabIndex = 24;
			// 
			// textBoxApprovedBy
			// 
			this.structuresExtender.SetAttributeName(this.textBoxApprovedBy, "approvedBy");
			this.structuresExtender.SetAttributeTypeName(this.textBoxApprovedBy, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxApprovedBy, "Text");
			this.textBoxApprovedBy.Location = new System.Drawing.Point(12, 366);
			this.textBoxApprovedBy.Name = "textBoxApprovedBy";
			this.textBoxApprovedBy.Size = new System.Drawing.Size(66, 22);
			this.textBoxApprovedBy.TabIndex = 22;
			// 
			// label7
			// 
			this.structuresExtender.SetAttributeName(this.label7, null);
			this.structuresExtender.SetAttributeTypeName(this.label7, null);
			this.label7.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label7, null);
			this.label7.Location = new System.Drawing.Point(184, 346);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 17);
			this.label7.TabIndex = 25;
			this.label7.Text = "Approved Comment";
			// 
			// label8
			// 
			this.structuresExtender.SetAttributeName(this.label8, null);
			this.structuresExtender.SetAttributeTypeName(this.label8, null);
			this.label8.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label8, null);
			this.label8.Location = new System.Drawing.Point(81, 346);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 17);
			this.label8.TabIndex = 23;
			this.label8.Text = "Date";
			// 
			// label9
			// 
			this.structuresExtender.SetAttributeName(this.label9, null);
			this.structuresExtender.SetAttributeTypeName(this.label9, null);
			this.label9.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label9, null);
			this.label9.Location = new System.Drawing.Point(9, 345);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 17);
			this.label9.TabIndex = 21;
			this.label9.Text = "Approved";
			// 
			// richTextBoxCheckedComment
			// 
			this.structuresExtender.SetAttributeName(this.richTextBoxCheckedComment, "checkedComment");
			this.structuresExtender.SetAttributeTypeName(this.richTextBoxCheckedComment, "String");
			this.structuresExtender.SetBindPropertyName(this.richTextBoxCheckedComment, "Text");
			this.richTextBoxCheckedComment.Location = new System.Drawing.Point(184, 211);
			this.richTextBoxCheckedComment.Name = "richTextBoxCheckedComment";
			this.richTextBoxCheckedComment.Size = new System.Drawing.Size(507, 50);
			this.richTextBoxCheckedComment.TabIndex = 32;
			this.richTextBoxCheckedComment.Text = "";
			// 
			// textBoxCheckedDate
			// 
			this.structuresExtender.SetAttributeName(this.textBoxCheckedDate, "checkedDate");
			this.structuresExtender.SetAttributeTypeName(this.textBoxCheckedDate, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxCheckedDate, "Text");
			this.textBoxCheckedDate.Location = new System.Drawing.Point(84, 211);
			this.textBoxCheckedDate.Name = "textBoxCheckedDate";
			this.textBoxCheckedDate.Size = new System.Drawing.Size(94, 22);
			this.textBoxCheckedDate.TabIndex = 30;
			// 
			// textBoxCheckedBy
			// 
			this.structuresExtender.SetAttributeName(this.textBoxCheckedBy, "checkedBy");
			this.structuresExtender.SetAttributeTypeName(this.textBoxCheckedBy, "String");
			this.structuresExtender.SetBindPropertyName(this.textBoxCheckedBy, "Text");
			this.textBoxCheckedBy.Location = new System.Drawing.Point(12, 211);
			this.textBoxCheckedBy.Name = "textBoxCheckedBy";
			this.textBoxCheckedBy.Size = new System.Drawing.Size(66, 22);
			this.textBoxCheckedBy.TabIndex = 28;
			// 
			// label10
			// 
			this.structuresExtender.SetAttributeName(this.label10, null);
			this.structuresExtender.SetAttributeTypeName(this.label10, null);
			this.label10.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label10, null);
			this.label10.Location = new System.Drawing.Point(184, 191);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(126, 17);
			this.label10.TabIndex = 31;
			this.label10.Text = "Checked Comment";
			// 
			// label11
			// 
			this.structuresExtender.SetAttributeName(this.label11, null);
			this.structuresExtender.SetAttributeTypeName(this.label11, null);
			this.label11.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label11, null);
			this.label11.Location = new System.Drawing.Point(81, 191);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(38, 17);
			this.label11.TabIndex = 29;
			this.label11.Text = "Date";
			// 
			// label12
			// 
			this.structuresExtender.SetAttributeName(this.label12, null);
			this.structuresExtender.SetAttributeTypeName(this.label12, null);
			this.label12.AutoSize = true;
			this.structuresExtender.SetBindPropertyName(this.label12, null);
			this.label12.Location = new System.Drawing.Point(9, 190);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 17);
			this.label12.TabIndex = 27;
			this.label12.Text = "Checked";
			// 
			// MainForm
			// 
			this.structuresExtender.SetAttributeName(this, null);
			this.structuresExtender.SetAttributeTypeName(this, null);
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.structuresExtender.SetBindPropertyName(this, null);
			this.ClientSize = new System.Drawing.Size(704, 457);
			this.Controls.Add(this.richTextBoxCheckedComment);
			this.Controls.Add(this.textBoxCheckedDate);
			this.Controls.Add(this.textBoxCheckedBy);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.richTextBoxApprovedComment);
			this.Controls.Add(this.textBoxApprovedDate);
			this.Controls.Add(this.textBoxApprovedBy);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.richTextBoxDesignedComment);
			this.Controls.Add(this.textBoxDesignedDate);
			this.Controls.Add(this.textBoxDesignedBy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.saveLoad1);
			this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
			this.Controls.Add(this.richTextDetailedComment);
			this.Controls.Add(this.textBoxDeteiledDate);
			this.Controls.Add(this.textBoxDetailedBy);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "Connection Check Plugin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextDetailedComment;
		private System.Windows.Forms.TextBox textBoxDeteiledDate;
		private System.Windows.Forms.TextBox textBoxDetailedBy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
		private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox richTextBoxDesignedComment;
		private System.Windows.Forms.TextBox textBoxDesignedDate;
		private System.Windows.Forms.TextBox textBoxDesignedBy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBoxApprovedComment;
		private System.Windows.Forms.TextBox textBoxApprovedDate;
		private System.Windows.Forms.TextBox textBoxApprovedBy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RichTextBox richTextBoxCheckedComment;
		private System.Windows.Forms.TextBox textBoxCheckedDate;
		private System.Windows.Forms.TextBox textBoxCheckedBy;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}