using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Threading;

namespace CustomPropertiesEditor
{
	internal static class Helper
	{
		public enum HelperResult
		{
			SUCCESS,
			SKIPED,
			CANCELED,
			NOT_EXIST,
			NO_FILES,
			WRONG_ARG,
			OPEN_ERROR,
			UNKNOWN_ERROR,
			UNKNOWN
		}

		[Flags]
		public enum PropProcessFlag
		{
			MAIN_CUSTOM = 1,
			CONFIG_CUSTOM = 2,

			ALL = MAIN_CUSTOM | CONFIG_CUSTOM
		}



		//////add files to DataGridView;
		internal static HelperResult AddFolder(BindingSource bindingSource, string path)
		{
			if(!Directory.Exists(path))
			{
				return HelperResult.NOT_EXIST;
			}

			string[] files = Directory.GetFiles(path);

			HelperResult err = HelperResult.UNKNOWN;
			if(!files.Any())
			{
				return HelperResult.NO_FILES;
			}

			err = AddFiles(bindingSource, files);

			return err;
		}

		internal static HelperResult AddFiles(BindingSource bindingSource, string[] pathes)
		{
			if(!pathes.Any())
			{
				return HelperResult.WRONG_ARG;
			}


			foreach (var item in pathes)
			{
				AddFile(bindingSource,item);
			}

			if(bindingSource.Count == 0)
			{
				return HelperResult.NO_FILES;
			}

			return HelperResult.SUCCESS;
		}

		internal static HelperResult AddFile(BindingSource bindingSource, string path)
		{

			if (!File.Exists(path))
				return HelperResult.NOT_EXIST;

			FileObj file = new FileObj(path);

			if (file.SwType_e == SolidWorks.Interop.swconst.swDocumentTypes_e.swDocNONE)
				return HelperResult.NO_FILES;

			try
			{
				((BindingList<FileObj>)bindingSource.DataSource).Add(file);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
			
			return HelperResult.SUCCESS;
		}
		/////

		internal static HelperResult processModel(SldWorks swApp,FileObj file, BindingList<PropertyObject> prop_list, PropProcessFlag flag, CancellationToken cancellationToken)
		{
			int Warning = 0;
			int Error = 0;

			try
			{
				if(cancellationToken.IsCancellationRequested)
				{
					return HelperResult.CANCELED;
				}

				if(file.Read_only)
				{
					file.Note = "Skiped becaus file is Read only!";
					return HelperResult.SKIPED;
				}

				ModelDoc2 swDoc = swApp.OpenDoc6(file.PathToFile, (int)file.SwType_e, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref Error, ref Warning);

				if (Error != 0 || swDoc == null)
				{
					file.Note = "Error to open file";
					return HelperResult.OPEN_ERROR;
				}

				file.ConfigNames.AddRange(swDoc.GetConfigurationNames());
				if (!file.ConfigNames.Any())
					return HelperResult.UNKNOWN;



				throw new NotImplementedException();
			}
			catch (Exception e)
			{

				throw e;
			}
			return HelperResult.SUCCESS;
		}
		
	}
}
