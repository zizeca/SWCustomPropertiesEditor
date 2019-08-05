using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

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
			if (!Directory.Exists(path))
			{
				return HelperResult.NOT_EXIST;
			}

			string[] files = Directory.GetFiles(path);

			HelperResult err = HelperResult.UNKNOWN;
			if (!files.Any())
			{
				return HelperResult.NO_FILES;
			}

			err = AddFiles(bindingSource, files);

			return err;
		}

		internal static HelperResult AddFiles(BindingSource bindingSource, string[] pathes)
		{
			if (!pathes.Any())
			{
				return HelperResult.WRONG_ARG;
			}

			foreach (var item in pathes)
			{
				AddFile(bindingSource, item);
			}

			if (bindingSource.Count == 0)
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
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return HelperResult.SUCCESS;
		}

		/////

		internal static HelperResult processModel(SldWorks swApp, FileObj file, BindingList<PropertyObject> prop_list, PropProcessFlag flag, CancellationToken cancellationToken)
		{
			Console.WriteLine("Helper.processModel");

			int Warning = 0;
			int Error = 0;

			try
			{
				if (cancellationToken.IsCancellationRequested)
				{
					file.Note = "Cancel";
					return HelperResult.CANCELED;
				}

				if (file.Read_only)
				{
					file.Note = "Skiped (Read only!)";
					return HelperResult.SKIPED;
				}

				ModelDoc2 swDoc = swApp.OpenDoc6(file.PathToFile, (int)file.SwType_e, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref Error, ref Warning);

				if (Error != 0 || swDoc == null)
				{
					file.Note = "Error to open file";
					return HelperResult.OPEN_ERROR;
				}

				//*  //this code error
				if (file.SwType_e == swDocumentTypes_e.swDocASSEMBLY || file.SwType_e == swDocumentTypes_e.swDocPART)
				{
					file.ConfigNames.AddRange(swDoc.GetConfigurationNames());
					if (!file.ConfigNames.Any())
					{
						swApp.QuitDoc(swDoc.GetTitle());
						swDoc = null;
						file.Note = "Skiped (Unknown error)";
						return HelperResult.UNKNOWN;
					}
				}

				//*/

				if ((flag & PropProcessFlag.MAIN_CUSTOM) == PropProcessFlag.MAIN_CUSTOM)
				{
					try
					{
						CustomPropertyManager manager = swDoc.Extension.CustomPropertyManager[""];
						foreach (PropertyObject property in prop_list)
						{
							Console.WriteLine("field={0},type={1},value={2}", property.FieldName, property.FieldType, property.Value);
							int ret = manager.Add3(property.FieldName, (int)property.FieldType, property.Value, (int)swCustomPropertyAddOption_e.swCustomPropertyReplaceValue);
							if (ret != 0)
								file.Note = "Error to add, err num = " + ret;
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("error in add method" + ex.Message);
						file.Note = "error(" + ex.Message + ")";
						//throw ex;
					}
				}

				if ( ((flag & PropProcessFlag.CONFIG_CUSTOM) == PropProcessFlag.CONFIG_CUSTOM) && file.ConfigNames.Any())
				{
					try
					{
						foreach (string conf in file.ConfigNames)
						{
							Console.WriteLine(conf);
							CustomPropertyManager manager = swDoc.Extension.CustomPropertyManager[conf];
							foreach (PropertyObject property in prop_list)
							{
								Console.WriteLine("field={0},type={1},value={2},config{3}", property.FieldName, property.FieldType, property.Value,conf);
								int ret = manager.Add3(property.FieldName, (int)property.FieldType, property.Value, (int)swCustomPropertyAddOption_e.swCustomPropertyReplaceValue);
								if (ret != 0)
								{
									file.Note = "Error to add, err num = " + ret;
									break;
								}
							}
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("error in add method" + ex.Message);
						file.Note = "error(" + ex.Message + ")";
						//throw ex;
					}
				}

				file.Note = "Done";
				swDoc.SaveSilent();
				swApp.QuitDoc(swDoc.GetTitle());
				swDoc = null;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw e;
			}
			return HelperResult.SUCCESS;
		}
	}
}