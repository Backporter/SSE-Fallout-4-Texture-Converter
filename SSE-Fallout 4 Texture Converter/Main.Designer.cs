namespace SSE_Fallout_4_Texture_Converter
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btstart = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btadddir = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.lboxFiles = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.credit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btstart
            // 
            this.btstart.AutoSize = true;
            this.btstart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btstart.Location = new System.Drawing.Point(653, 119);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(128, 23);
            this.btstart.TabIndex = 81;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClear.Location = new System.Drawing.Point(653, 61);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(128, 23);
            this.btClear.TabIndex = 80;
            this.btClear.Text = "Purge list";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btadddir
            // 
            this.btadddir.AutoSize = true;
            this.btadddir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btadddir.Location = new System.Drawing.Point(653, 32);
            this.btadddir.Name = "btadddir";
            this.btadddir.Size = new System.Drawing.Size(128, 23);
            this.btadddir.TabIndex = 79;
            this.btadddir.Text = "Add Directory(s)";
            this.btadddir.UseVisualStyleBackColor = true;
            this.btadddir.Click += new System.EventHandler(this.btadddir_Click);
            // 
            // btadd
            // 
            this.btadd.AutoSize = true;
            this.btadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btadd.Location = new System.Drawing.Point(653, 3);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(128, 23);
            this.btadd.TabIndex = 78;
            this.btadd.Text = "Add File(s)";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // lboxFiles
            // 
            this.lboxFiles.AllowDrop = true;
            this.lboxFiles.FormattingEnabled = true;
            this.lboxFiles.Location = new System.Drawing.Point(3, 3);
            this.lboxFiles.Name = "lboxFiles";
            this.lboxFiles.Size = new System.Drawing.Size(644, 381);
            this.lboxFiles.TabIndex = 85;
            this.lboxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboxFiles_DragDrop);
            this.lboxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboxFiles_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(653, 90);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(128, 23);
            this.credit.TabIndex = 83;
            this.credit.Text = "Credits";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(653, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(128, 23);
            this.progressBar1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(651, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 87;
            this.label2.Text = "Some are going to Fail so\r\nkeep that in mind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Texture Formats(s)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Auto is Recomended";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btadddir);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.lboxFiles);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SSE/Fallout 4 Texture Converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btadddir;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.ListBox lboxFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

