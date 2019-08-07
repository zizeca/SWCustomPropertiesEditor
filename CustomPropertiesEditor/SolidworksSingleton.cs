using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace CustomPropertiesEditor
{
	internal class SolidworksSingleton
	{
		private static SldWorks swApp;

		private static bool SwWasStarted = false;
		private static bool ProcessChecked = false;

		private SolidworksSingleton()
		{ }

		internal async static Task<SldWorks> GetSwAppAsync()
		{
			if(!ProcessChecked)
			{
				Process[] pname = Process.GetProcessesByName("SldWorks.exe");
				if(pname.Length != 0)
				{
					SwWasStarted = true;
					Console.WriteLine("SldWorks is running");
				}

				ProcessChecked = true;
			}
			

			if (swApp == null)
			{

				//*
				return await Task<SldWorks>.Run(() => {
					swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;

					if (SwWasStarted)
						swApp.Visible = true;
					else
						swApp.Visible = false;

					return swApp;
				});
				///*/
				/* / next code not working when solidworks is not started
				return await Task<SldWorks>.Run(() => {
					swApp = new SldWorks();
					//swApp.Visible = true;
					return swApp;
				});
				*/
			}
			
			return swApp;
		}

		internal static void Dispose()
		{
			if(swApp != null && !SwWasStarted)
			{
				swApp.CloseAllDocuments(true);
				swApp.ExitApp();
				swApp = null;
			}
		}

	}
}
