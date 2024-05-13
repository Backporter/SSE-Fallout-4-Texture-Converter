using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SSE_Fallout_4_Texture_Converter
{
	public partial class Settings : Form
	{
        public static Settings Global;

        public bool ScanTextureForFormat;
        public bool BackUpOrginalTexture;
        public bool KeepGNFExtestion;
        public bool DisableMipMaps;
        public bool ShowFullFilePath;
        public bool LogProcessOutput;
        public bool LogThreadOutput;
        public bool UseHalfThreadCount;

        public Settings()
        {
            InitializeComponent();

            //
            ScanTextureForFormat = scantexturforformatcb.Checked;
            BackUpOrginalTexture = BackupSourceTexturecb.Checked;
            KeepGNFExtestion = KeepGNFExtensionCheckBox.Checked;
            DisableMipMaps = disablemipscb.Checked;
            ShowFullFilePath = showfilepathcb.Checked;
            LogThreadOutput = savethreadoutputcb.Checked;
            LogProcessOutput = saveprocessoutputcb.Checked;
            LogThreadOutput = savethreadoutputcb.Checked;

            if (Environment.ProcessorCount >= 8)
            {
                UseHalfThreadCount = halfthreadcountcb.Checked = false;
            }
            else
            {
                UseHalfThreadCount = halfthreadcountcb.Checked;
            }
        }

        private void scantexturforformatcb_CheckedChanged(object sender, EventArgs e)
        {
            ScanTextureForFormat = scantexturforformatcb.Checked;
        }

        private void scantexturforformatcb_CheckStateChanged(object sender, EventArgs e)
        {
            ScanTextureForFormat = scantexturforformatcb.Checked;
        }

        private void BackupSourceTexturecb_CheckedChanged(object sender, EventArgs e)
        {
            BackUpOrginalTexture = BackupSourceTexturecb.Checked;
        }

        private void BackupSourceTexturecb_CheckStateChanged(object sender, EventArgs e)
        {
            BackUpOrginalTexture = BackupSourceTexturecb.Checked;
        }

        private void KeepGNFExtensioncb_CheckedChanged(object sender, EventArgs e)
        {
            KeepGNFExtestion = KeepGNFExtensionCheckBox.Checked;
        }

        private void KeepGNFExtensioncb_CheckStateChanged(object sender, EventArgs e)
        {
            KeepGNFExtestion = KeepGNFExtensionCheckBox.Checked;
        }

        private void disablemipscb_CheckedChanged(object sender, EventArgs e)
		{
			DisableMipMaps = disablemipscb.Checked;
		}

        private void disablemipscb_CheckStateChanged(object sender, EventArgs e)
        {
            DisableMipMaps = disablemipscb.Checked;
        }

        private void showfilepathcb_CheckedChanged(object sender, EventArgs e)
        {
            ShowFullFilePath = showfilepathcb.Checked;
        }

        private void showfilepathcb_CheckStateChanged(object sender, EventArgs e)
        {
            ShowFullFilePath = showfilepathcb.Checked;
        }

        private void saveprocessoutputcb_CheckedChanged(object sender, EventArgs e)
        {
            LogProcessOutput = saveprocessoutputcb.Checked;
        }

        private void saveprocessoutputcb_CheckStateChanged(object sender, EventArgs e)
        {
            LogProcessOutput = saveprocessoutputcb.Checked;
        }

        private void savethreadoutputcb_CheckedChanged(object sender, EventArgs e)
        {
            LogThreadOutput = savethreadoutputcb.Checked;
        }

        private void savethreadoutputcb_CheckStateChanged(object sender, EventArgs e)
        {
            LogThreadOutput = savethreadoutputcb.Checked;
        }

        private void halfthreadcountcb_CheckedChanged(object sender, EventArgs e)
        {
            UseHalfThreadCount = halfthreadcountcb.Checked;
        }

        private void halfthreadcountcb_CheckStateChanged(object sender, EventArgs e)
        {
            UseHalfThreadCount = halfthreadcountcb.Checked;
        }
    }
}
