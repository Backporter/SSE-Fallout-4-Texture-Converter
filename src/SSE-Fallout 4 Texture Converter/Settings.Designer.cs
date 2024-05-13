namespace SSE_Fallout_4_Texture_Converter
{
	// Token: 0x02000005 RID: 5
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00004368 File Offset: 0x00002568
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004388 File Offset: 0x00002588
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.BackupSourceTexturecb = new System.Windows.Forms.CheckBox();
            this.KeepGNFExtensionCheckBox = new System.Windows.Forms.CheckBox();
            this.disablemipscb = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.scantexturforformatcb = new System.Windows.Forms.CheckBox();
            this.showfilepathcb = new System.Windows.Forms.CheckBox();
            this.saveprocessoutputcb = new System.Windows.Forms.CheckBox();
            this.savethreadoutputcb = new System.Windows.Forms.CheckBox();
            this.halfthreadcountcb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BackupSourceTexturecb
            // 
            this.BackupSourceTexturecb.AutoSize = true;
            this.BackupSourceTexturecb.Location = new System.Drawing.Point(12, 39);
            this.BackupSourceTexturecb.Name = "BackupSourceTexturecb";
            this.BackupSourceTexturecb.Size = new System.Drawing.Size(163, 17);
            this.BackupSourceTexturecb.TabIndex = 0;
            this.BackupSourceTexturecb.Text = "Backup DDS(Do Not Delete)";
            this.BackupSourceTexturecb.UseVisualStyleBackColor = true;
            this.BackupSourceTexturecb.CheckedChanged += new System.EventHandler(this.BackupSourceTexturecb_CheckedChanged);
            this.BackupSourceTexturecb.CheckStateChanged += new System.EventHandler(this.BackupSourceTexturecb_CheckStateChanged);
            // 
            // KeepGNFExtensionCheckBox
            // 
            this.KeepGNFExtensionCheckBox.AutoSize = true;
            this.KeepGNFExtensionCheckBox.Location = new System.Drawing.Point(12, 62);
            this.KeepGNFExtensionCheckBox.Name = "KeepGNFExtensionCheckBox";
            this.KeepGNFExtensionCheckBox.Size = new System.Drawing.Size(125, 17);
            this.KeepGNFExtensionCheckBox.TabIndex = 1;
            this.KeepGNFExtensionCheckBox.Text = "Keep GNF Extension";
            this.KeepGNFExtensionCheckBox.UseVisualStyleBackColor = true;
            this.KeepGNFExtensionCheckBox.CheckedChanged += new System.EventHandler(this.KeepGNFExtensioncb_CheckedChanged);
            this.KeepGNFExtensionCheckBox.CheckStateChanged += new System.EventHandler(this.KeepGNFExtensioncb_CheckStateChanged);
            // 
            // disablemipscb
            // 
            this.disablemipscb.AutoSize = true;
            this.disablemipscb.Location = new System.Drawing.Point(12, 85);
            this.disablemipscb.Name = "disablemipscb";
            this.disablemipscb.Size = new System.Drawing.Size(102, 17);
            this.disablemipscb.TabIndex = 107;
            this.disablemipscb.Text = "Disable MipMap";
            this.toolTip1.SetToolTip(this.disablemipscb, "Depending on the Textrue format this might not do anything\r\n");
            this.disablemipscb.UseVisualStyleBackColor = true;
            this.disablemipscb.CheckedChanged += new System.EventHandler(this.disablemipscb_CheckedChanged);
            this.disablemipscb.CheckStateChanged += new System.EventHandler(this.disablemipscb_CheckStateChanged);
            // 
            // scantexturforformatcb
            // 
            this.scantexturforformatcb.AutoSize = true;
            this.scantexturforformatcb.Enabled = false;
            this.scantexturforformatcb.Location = new System.Drawing.Point(12, 13);
            this.scantexturforformatcb.Name = "scantexturforformatcb";
            this.scantexturforformatcb.Size = new System.Drawing.Size(143, 17);
            this.scantexturforformatcb.TabIndex = 108;
            this.scantexturforformatcb.Text = "Scan Texture For Format";
            this.scantexturforformatcb.UseVisualStyleBackColor = true;
            this.scantexturforformatcb.CheckedChanged += new System.EventHandler(this.scantexturforformatcb_CheckedChanged);
            this.scantexturforformatcb.CheckStateChanged += new System.EventHandler(this.scantexturforformatcb_CheckStateChanged);
            // 
            // showfilepathcb
            // 
            this.showfilepathcb.AutoSize = true;
            this.showfilepathcb.Enabled = false;
            this.showfilepathcb.Location = new System.Drawing.Point(12, 109);
            this.showfilepathcb.Name = "showfilepathcb";
            this.showfilepathcb.Size = new System.Drawing.Size(121, 17);
            this.showfilepathcb.TabIndex = 109;
            this.showfilepathcb.Text = "Show Full File Paths";
            this.showfilepathcb.UseVisualStyleBackColor = true;
            this.showfilepathcb.CheckedChanged += new System.EventHandler(this.showfilepathcb_CheckedChanged);
            this.showfilepathcb.CheckStateChanged += new System.EventHandler(this.showfilepathcb_CheckStateChanged);
            // 
            // saveprocessoutputcb
            // 
            this.saveprocessoutputcb.AutoSize = true;
            this.saveprocessoutputcb.Location = new System.Drawing.Point(13, 133);
            this.saveprocessoutputcb.Name = "saveprocessoutputcb";
            this.saveprocessoutputcb.Size = new System.Drawing.Size(127, 17);
            this.saveprocessoutputcb.TabIndex = 110;
            this.saveprocessoutputcb.Text = "Save Process Output";
            this.saveprocessoutputcb.UseVisualStyleBackColor = true;
            this.saveprocessoutputcb.CheckedChanged += new System.EventHandler(this.saveprocessoutputcb_CheckedChanged);
            this.saveprocessoutputcb.CheckStateChanged += new System.EventHandler(this.saveprocessoutputcb_CheckStateChanged);
            // 
            // savethreadoutputcb
            // 
            this.savethreadoutputcb.AutoSize = true;
            this.savethreadoutputcb.Location = new System.Drawing.Point(12, 156);
            this.savethreadoutputcb.Name = "savethreadoutputcb";
            this.savethreadoutputcb.Size = new System.Drawing.Size(114, 17);
            this.savethreadoutputcb.TabIndex = 111;
            this.savethreadoutputcb.Text = "Save Thread Logs";
            this.savethreadoutputcb.UseVisualStyleBackColor = true;
            this.savethreadoutputcb.CheckedChanged += new System.EventHandler(this.savethreadoutputcb_CheckedChanged);
            this.savethreadoutputcb.CheckStateChanged += new System.EventHandler(this.savethreadoutputcb_CheckStateChanged);
            // 
            // halfthreadcountcb
            // 
            this.halfthreadcountcb.AutoSize = true;
            this.halfthreadcountcb.Checked = true;
            this.halfthreadcountcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.halfthreadcountcb.Location = new System.Drawing.Point(12, 179);
            this.halfthreadcountcb.Name = "halfthreadcountcb";
            this.halfthreadcountcb.Size = new System.Drawing.Size(113, 17);
            this.halfthreadcountcb.TabIndex = 112;
            this.halfthreadcountcb.Text = "Half Thread Count";
            this.halfthreadcountcb.UseVisualStyleBackColor = true;
            this.halfthreadcountcb.CheckedChanged += new System.EventHandler(this.halfthreadcountcb_CheckedChanged);
            this.halfthreadcountcb.CheckStateChanged += new System.EventHandler(this.halfthreadcountcb_CheckStateChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 215);
            this.Controls.Add(this.halfthreadcountcb);
            this.Controls.Add(this.savethreadoutputcb);
            this.Controls.Add(this.saveprocessoutputcb);
            this.Controls.Add(this.showfilepathcb);
            this.Controls.Add(this.scantexturforformatcb);
            this.Controls.Add(this.disablemipscb);
            this.Controls.Add(this.KeepGNFExtensionCheckBox);
            this.Controls.Add(this.BackupSourceTexturecb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000024 RID: 36
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.CheckBox BackupSourceTexturecb;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.CheckBox KeepGNFExtensionCheckBox;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.CheckBox disablemipscb;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox scantexturforformatcb;
        private System.Windows.Forms.CheckBox showfilepathcb;
        private System.Windows.Forms.CheckBox saveprocessoutputcb;
        private System.Windows.Forms.CheckBox savethreadoutputcb;
        private System.Windows.Forms.CheckBox halfthreadcountcb;
    }
}
