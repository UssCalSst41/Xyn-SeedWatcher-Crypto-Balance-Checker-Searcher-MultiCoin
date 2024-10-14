using System;
using System.IO;
using System.Windows.Forms;

namespace BalanceCheckerWin
{
	// Token: 0x02000010 RID: 16
	internal static class Program
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		[STAThread]
		private static void Main()
		{
			if (!File.Exists(Path.Combine(Application.StartupPath, <Module>.ZExtO("⥦⥒⥸⥚⥇⤅⥯⥊⥟⥊⤅⥏⥇⥇", <Module>.艾艾留大留()))))
			{
				MessageBox.Show(<Module>.ZExtO("䤩䥵䥶䥴䥵䥶䥵䤅䥴䤂䥵䴗䤊䤂䤉䤆䥲䤉䤃䤏䤋䥼䤎䴗䥳䤇䤎䤌䴙䴗䤖䤉䥳䥵䴗䤆䥴䤃䤂䥵䴗䤀䤇䤍䥷䥼䥵", <Module>.埃豆克斯埃()));
				Environment.Exit(<Module>.豆克斯大留());
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(<Module>.留豆波斯埃() != 0);
			Application.Run(new Form1());
		}
	}
}
