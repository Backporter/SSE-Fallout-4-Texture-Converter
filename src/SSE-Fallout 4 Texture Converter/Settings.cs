using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SSE_Fallout_4_Texture_Converter
{
	public partial class Settings : Form
	{
        // singleton.
        public static Settings Global;

        // global vars
        public bool Warned = false;
        public bool ScanTextureForFormat = false;
        public bool BackUpOrginalTexture = false;
        public bool KeepGNFExtestion = false;
        public bool DisableMipMaps = false;
        public bool ShowFullFilePath = false;
        public bool LogProcessOutput = false;
        public bool LogThreadOutput = false;
        public bool UseHalfThreadCount = true;

        // ctor
        public Settings()
        {
            InitializeComponent();

            Deserialize();

            //
            scantexturforformatcb.Checked       = ScanTextureForFormat;
            BackupSourceTexturecb.Checked       = BackUpOrginalTexture;
            KeepGNFExtensionCheckBox.Checked    = KeepGNFExtestion;
            disablemipscb.Checked               = DisableMipMaps;
            showfilepathcb.Checked              = ShowFullFilePath;
            savethreadoutputcb.Checked          = LogThreadOutput;
            saveprocessoutputcb.Checked         = LogProcessOutput;

            if (Environment.ProcessorCount >= 8)
            {
                halfthreadcountcb.Checked = UseHalfThreadCount = false;
            }
            else
            {
                halfthreadcountcb.Checked = UseHalfThreadCount;
            }
        }

        //
        public void Serialize()
        {
            Properties.Settings.Default.Warned = Warned;
            Properties.Settings.Default.ScanTextureForFormat = ScanTextureForFormat;
            Properties.Settings.Default.BackUpOrginalTexture = BackUpOrginalTexture;
            Properties.Settings.Default.KeepGNFExtestion = KeepGNFExtestion;
            Properties.Settings.Default.DisableMipMaps = DisableMipMaps;
            Properties.Settings.Default.ShowFullFilePath = ShowFullFilePath;
            Properties.Settings.Default.LogProcessOutput = LogProcessOutput;
            Properties.Settings.Default.LogThreadOutput = LogThreadOutput;
            Properties.Settings.Default.UseHalfThreadCount = UseHalfThreadCount;
            Properties.Settings.Default.Save();
        }

        //
        public void Deserialize()
        {
            Warned                              = Properties.Settings.Default.Warned;
            scantexturforformatcb.Checked       = ScanTextureForFormat  = Properties.Settings.Default.ScanTextureForFormat;
            BackupSourceTexturecb.Checked       = BackUpOrginalTexture  = Properties.Settings.Default.BackUpOrginalTexture;
            KeepGNFExtensionCheckBox.Checked    = KeepGNFExtestion      = Properties.Settings.Default.KeepGNFExtestion;
            disablemipscb.Checked               = DisableMipMaps        = Properties.Settings.Default.DisableMipMaps;
            showfilepathcb.Checked              = ShowFullFilePath      = Properties.Settings.Default.ShowFullFilePath;
            savethreadoutputcb.Checked          = LogThreadOutput       = Properties.Settings.Default.LogThreadOutput;
            saveprocessoutputcb.Checked         = LogProcessOutput      = Properties.Settings.Default.LogProcessOutput;
            halfthreadcountcb.Checked           = UseHalfThreadCount    = Properties.Settings.Default.UseHalfThreadCount;
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
