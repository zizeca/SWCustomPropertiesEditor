using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace CustomPropertiesEditor
{
	internal class SolidworksSingleton
	{
		private static SldWorks swApp;

		private SolidworksSingleton()
		{ }

		internal async static Task<SldWorks> GetSwAppAsync()
		{
			if (swApp == null)
			{
				return await Task<SldWorks>.Run(() => {
					swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
					swApp.Visible = true;
					return swApp;
				});
			}
			
			return swApp;
		}

		internal static void Dispose()
		{
			if(swApp != null)
			{
				swApp.ExitApp();
				swApp = null;
			}
		}

	}
}
