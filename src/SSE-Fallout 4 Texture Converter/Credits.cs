using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SSE_Fallout_4_Texture_Converter
{
	public partial class Credits : Form
	{
        public static Credits Global = new Credits();

		public Credits()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://discord.gg/twpSyYp");
		}
	}
}
