namespace SSE_Fallout_4_Texture_Converter
{
	// Token: 0x02000003 RID: 3
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000034F6 File Offset: 0x000016F6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003518 File Offset: 0x00001718
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btstart = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btadddir = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.lboxFiles = new System.Windows.Forms.ListBox();
            this.credit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.convertlb = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.formatcb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.AutoSize = true;
            this.btstart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btstart.Location = new System.Drawing.Point(648, 119);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(138, 23);
            this.btstart.TabIndex = 81;
            this.btstart.Text = "Start";
            this.toolTip1.SetToolTip(this.btstart, "this will start the conversion");
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClear.Location = new System.Drawing.Point(648, 61);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(138, 23);
            this.btClear.TabIndex = 80;
            this.btClear.Text = "Purge list";
            this.toolTip1.SetToolTip(this.btClear, "this will purge the list");
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btadddir
            // 
            this.btadddir.AutoSize = true;
            this.btadddir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btadddir.Location = new System.Drawing.Point(648, 32);
            this.btadddir.Name = "btadddir";
            this.btadddir.Size = new System.Drawing.Size(138, 23);
            this.btadddir.TabIndex = 79;
            this.btadddir.Text = "Add Directory(s)";
            this.toolTip1.SetToolTip(this.btadddir, "This is for adding a dirtory");
            this.btadddir.UseVisualStyleBackColor = true;
            this.btadddir.Click += new System.EventHandler(this.btadddir_Click);
            // 
            // btadd
            // 
            this.btadd.AutoSize = true;
            this.btadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btadd.Location = new System.Drawing.Point(648, 3);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(138, 23);
            this.btadd.TabIndex = 78;
            this.btadd.Text = "Add File(s)";
            this.toolTip1.SetToolTip(this.btadd, "This is to add them one by one");
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // lboxFiles
            // 
            this.lboxFiles.AllowDrop = true;
            this.lboxFiles.FormattingEnabled = true;
            this.lboxFiles.Location = new System.Drawing.Point(12, 3);
            this.lboxFiles.Name = "lboxFiles";
            this.lboxFiles.Size = new System.Drawing.Size(627, 394);
            this.lboxFiles.TabIndex = 85;
            this.lboxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboxFiles_DragDrop);
            this.lboxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboxFiles_DragEnter);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(648, 90);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(138, 23);
            this.credit.TabIndex = 83;
            this.credit.Text = "Credits && Settings";
            this.toolTip1.SetToolTip(this.credit, " This will open the credit");
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(648, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(138, 23);
            this.progressBar1.TabIndex = 82;
            // 
            // convertlb
            // 
            this.convertlb.AutoSize = true;
            this.convertlb.Location = new System.Drawing.Point(648, 145);
            this.convertlb.Name = "convertlb";
            this.convertlb.Size = new System.Drawing.Size(119, 13);
            this.convertlb.TabIndex = 84;
            this.convertlb.Text = "Add Textures To Begin.";
            // 
            // formatcb
            // 
            this.formatcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatcb.FormattingEnabled = true;
            this.formatcb.Items.AddRange(new object[] {
            "Auto",
            "Bc1UNorm",
            "Bc1UNormSrgb",
            "Bc2UNorm",
            "Bc2UNormSrgb",
            "Bc3UNorm",
            "Bc3UNormSrgb",
            "Bc4UNorm",
            "Bc4Snorm",
            "Bc5UNorm",
            "Bc5Snorm",
            "Bc6UNorm",
            "Bc6Snorm",
            "Bc7UNorm",
            "Bc7UNormSrgb",
            "R32G32B32A32Float",
            "R32G32B32A32Uint",
            "R32G32B32A32Sint",
            "R32G32Float",
            "R32G32Uint",
            "R32G32Sint",
            "R32Float",
            "R32Uint",
            "R32Sint",
            "R16G16B16A16Float",
            "R16G16B16A16Uint",
            "R16G16B16A16Sint",
            "R16G16B16A16UNorm",
            "R16G16B16A16UBNorm",
            "R16G16B16A16UBNormNoZero",
            "R16G16B16A16UScaled",
            "R16G16B16A16SScaled",
            "R16G16B16A16UBInt",
            "R16G16B16A16UBScaled",
            "R16G16B16A16Snorm",
            "R16G16Float",
            "R16G16Uint",
            "R16G16Sint",
            "R16G16UNorm",
            "L16A16UNorm",
            "R16G16UBNorm",
            "R16G16UBNormNoZero",
            "R16G16UScaled",
            "R16G16SScaled",
            "R16G16UBInt",
            "R16G16UBScaled",
            "R16G16Snorm",
            "R16Float",
            "R16Uint",
            "R16Sint",
            "R16UNorm",
            "R16UBNorm",
            "R16UBNormNoZero",
            "R16UScaled",
            "R16SScaled",
            "R16UBInt",
            "R16UBScaled",
            "R16Snorm",
            "L16UNorm",
            "A16UNorm",
            "R8G8B8A8Uint",
            "R8G8B8A8Sint",
            "R8G8B8A8UNorm",
            "R8G8B8A8UNormSrgb",
            "R8G8B8A8UBNorm",
            "R8G8B8A8UBNormNoZero",
            "R8G8B8A8UScaled",
            "R8G8B8A8SScaled",
            "R8G8B8A8UBInt",
            "R8G8B8A8UBScaled",
            "R8G8B8A8Snorm",
            "R8G8Uint",
            "R8G8Sint",
            "R8G8UNorm",
            "R8G8UNormSrgb",
            "R8G8UBNorm",
            "R8G8UBNormNoZero",
            "R8G8UScaled",
            "R8G8SScaled",
            "R8G8UBInt",
            "R8G8UBScaled",
            "R8G8Snorm",
            "L8A8UNorm",
            "L8A8UNormSrgb",
            "R8Uint",
            "R8Sint",
            "R8UNorm",
            "R8UNormSrgb",
            "R8UBNorm",
            "R8UBNormNoZero",
            "R8UScaled",
            "R8SScaled",
            "R8UBInt",
            "R8UBScaled",
            "R8Snorm",
            "L8UNorm",
            "L8UNormSrgb",
            "A8UNorm",
            "B4G4R4A4UNorm",
            "B4G4R4X4UNorm",
            "B5G6R5UNorm",
            "B5G5R5A1UNorm",
            "B5G5R5X1UNorm",
            "R5G6B5UNorm",
            "B10G10R10A2UNorm",
            "R10G10B10A2UNorm",
            "B10G10R10A2Uint",
            "R10G10B10A2Uint",
            "R11G11B10Float",
            "R9G9B9E5Float",
            "R1Unorm",
            "L1Unorm",
            "A1Unorm",
            "R1Uint",
            "L1Uint",
            "A1Uint"});
            this.formatcb.Location = new System.Drawing.Point(649, 206);
            this.formatcb.Name = "formatcb";
            this.formatcb.Size = new System.Drawing.Size(137, 21);
            this.formatcb.TabIndex = 86;
            this.formatcb.TextChanged += new System.EventHandler(this.formatcb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Texture Formats(s)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 39);
            this.label4.TabIndex = 89;
            this.label4.Text = "Auto is Recomended\r\n(Not All Texture Formats \r\nwill work)\r\n";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formatcb);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btadddir);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.lboxFiles);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.convertlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "SSE/Fallout 4 Texture Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button btstart;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button btClear;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button btadddir;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button btadd;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ListBox lboxFiles;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button credit;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label convertlb;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ComboBox formatcb;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label4;
    }
}
