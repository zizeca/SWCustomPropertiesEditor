using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using SolidWorks.Interop.sldworks;

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
			//Console.WriteLine(path);
			if (!File.Exists(path))
				return HelperResult.NOT_EXIST;

			//Console.WriteLine("Extension= " + Path.GetExtension(path).ToLower());

			const string prt = ".sldprt";
			const string asm = ".sldasm";
			const string drw = ".slddrw";
			string ext = Path.GetExtension(path).ToLower();

			if ( !(ext == prt ||
				ext == asm ||
				ext == drw) )
			{
				//Console.WriteLine("Wrong ext");
				return HelperResult.NO_FILES;
			}


			FileObj file = new FileObj();
			file.PathToFile = path;
			file.Note = "";
			file.Name = Path.GetFileName(path);
			file.FileType = Path.GetExtension(path).ToLower();
			//DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
			try
			{
				/**/
				BindingList<FileObj> list = null;// = new BindingList<FileObj>();
				if (bindingSource.Count == 0)
				{
					list = new BindingList<FileObj>();
					bindingSource.DataSource = list;
				}

				list = (BindingList<FileObj>)bindingSource.DataSource;
				list.Add(file);
				//*/
				/**/
				//bindingSource.Add(file);
				//*/
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
			
			return HelperResult.SUCCESS;
		}
		/////

		internal static HelperResult processModel(SldWorks swApp,FileObj file, BindingList<PropertyObject> prop_list, PropProcessFlag flag)
		{

			return HelperResult.SUCCESS;
		}
		
	}
}
