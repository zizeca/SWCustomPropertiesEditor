using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

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
			SLDWORKS_NOT_RUNNING,
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

		internal static HelperResult OpenProperty(BindingSource bindingSource, string path)
		{
			XmlDocument doc = new XmlDocument();

			BindingList<PropertyObject> list = new BindingList<PropertyObject>();
						

			
			doc.Load(path);
			//Console.WriteLine("Loaded xml");

			XmlElement el = doc.DocumentElement;

			//Console.WriteLine("elem:" + el.Name);

			XmlNodeList elemList = doc.GetElementsByTagName("property");

			if (elemList.Count == 0)
			{
				return HelperResult.UNKNOWN;
			}

			for (int i = 0; i < elemList.Count; i++)
			{
				PropertyObject obj = new PropertyObject();

				if (!elemList[i].HasChildNodes) continue;
				obj.FieldName = elemList[i].ChildNodes[0].InnerText;
				if (string.IsNullOrEmpty(obj.FieldName)) continue;

				if (elemList[i].ChildNodes[1].InnerText.ToLower() == "bool")
				{
					obj.Type_Data = TypeData.YesOrNo;
				}
				else if (elemList[i].ChildNodes[1].InnerText.ToLower() == "date")
				{
					obj.Type_Data = TypeData.Date;
				}
				else if (elemList[i].ChildNodes[1].InnerText.ToLower() == "num")
				{
					obj.Type_Data = TypeData.Num;
				}
				else
				{
					obj.Type_Data = TypeData.Text;
				}

				obj.Value = elemList[i].ChildNodes[2].InnerText;

				list.Add(obj);


			}

			bindingSource.DataSource = list;

			return HelperResult.SUCCESS;
		}

		internal static HelperResult SaveProperty(BindingSource bindingSource, string path)
		{
			BindingList<PropertyObject> list = (BindingList<PropertyObject>)bindingSource.DataSource;

			if(!list.Any())
			{
				return HelperResult.NOT_EXIST;
			}

			XmlDocument doc = new XmlDocument();
			XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			doc.AppendChild(docNode);

			XmlNode propertiesNode = doc.CreateElement("properties");
			doc.AppendChild(propertiesNode);

			foreach (PropertyObject obj in list)
			{
				if (string.IsNullOrEmpty(obj.FieldName))
					continue;

				XmlNode propertyNode = doc.CreateElement("property");
				propertiesNode.AppendChild(propertyNode);
				//field name
				XmlNode fieldNode = doc.CreateElement("field");
				fieldNode.AppendChild(doc.CreateTextNode(obj.FieldName));
				propertyNode.AppendChild(fieldNode);
				//field type
				XmlNode typeNode = doc.CreateElement("type");
				XmlText typeText;
				switch (obj.Type_Data)
				{
					case TypeData.Text:
						typeText = doc.CreateTextNode("Text");
						break;
					case TypeData.YesOrNo:
						typeText = doc.CreateTextNode("YesOrNo");
						break;
					case TypeData.Date:
						typeText = doc.CreateTextNode("Date");
						break;
					case TypeData.Num:
						typeText = doc.CreateTextNode("Num");
						break;
					default:
						typeText = doc.CreateTextNode("Unknown");
						break;
				}
				typeNode.AppendChild(typeText);
				propertyNode.AppendChild(typeNode);
				//field value
				XmlNode valueNode = doc.CreateElement("value");
				valueNode.AppendChild(doc.CreateTextNode(obj.Value));
				propertyNode.AppendChild(valueNode);

				//add elem
				propertiesNode.AppendChild(propertyNode);
			}

			doc.Save(path);
			return HelperResult.SUCCESS;
		}

		internal static HelperResult ImportProperties(SldWorks swApp ,BindingSource bindingSource, 
			string path, string configName="")
		{
			Console.WriteLine("Import: path={0}, config={1}", path, configName);


			if (swApp == null)
				return HelperResult.SLDWORKS_NOT_RUNNING;

			string ext = Path.GetExtension(path);
			swDocumentTypes_e type;

			if (ext.ToLower().Contains("sldprt"))
				type = swDocumentTypes_e.swDocPART;
			else if (ext.ToLower().Contains("sldasm"))
				type = swDocumentTypes_e.swDocASSEMBLY;
			else if (ext.ToLower().Contains("slddrw") && string.IsNullOrEmpty(configName))
				type = swDocumentTypes_e.swDocDRAWING;
			else
				return HelperResult.WRONG_ARG;


			int Error = 0;
			int Warning = 0;
			ModelDoc2 doc;

			if (((ModelDoc2)swApp.ActiveDoc).GetPathName().ToLower() == path.ToLower())
			{
				doc = (ModelDoc2)swApp.ActiveDoc;
			}
			else
			{
				doc = swApp.OpenDoc6(path, (int)type, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, configName ,ref Error, ref Warning);
			}

			if (Error != 0)
			{
				return HelperResult.OPEN_ERROR;
			}

			CustomPropertyManager manager = doc.Extension.CustomPropertyManager[configName];
			if(manager == null)
				return HelperResult.OPEN_ERROR;

			string[] names = manager.GetNames();

			if (names ==null || !names.Any())
				return HelperResult.NOT_EXIST;

			BindingList<PropertyObject> list = new BindingList<PropertyObject>();

			foreach (string field in names)
			{
				PropertyObject obj = new PropertyObject();

				obj.FieldName = field;
				int ret = manager.Get6(field, true, out string ValOut, out string ResolvedValOut, out bool WasResolved, out bool LinkToProperty);

				if (ret == (int)swCustomInfoGetResult_e.swCustomInfoGetResult_NotPresent)
					continue;

				obj.Value = ValOut;
				list.Add(obj);
			}

			if (!list.Any())
				return HelperResult.NOT_EXIST;

			bindingSource.Clear();
			bindingSource.DataSource = list;

			return HelperResult.SUCCESS;
		}

		/////

		internal static HelperResult processModel(SldWorks swApp, FileObj file, BindingList<PropertyObject> prop_list, PropProcessFlag flag, CancellationToken cancellationToken)
		{
			if (swApp == null)
				return HelperResult.SLDWORKS_NOT_RUNNING;

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