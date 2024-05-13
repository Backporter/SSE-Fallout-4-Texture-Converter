using System;
using System.Windows.Forms;

namespace SSE_Fallout_4_Texture_Converter
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000042DC File Offset: 0x000024DC
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
