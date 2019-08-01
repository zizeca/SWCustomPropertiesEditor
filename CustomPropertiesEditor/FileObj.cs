using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.swconst;

namespace CustomPropertiesEditor
{
	class FileObj : INotifyPropertyChanged
	{
		private bool _read_only;
		private string _name;
		private string _pathToFile;
		//private string _fileType;
		private string _note;
		private swDocumentTypes_e _type_e;

		private List<string> _configNames;


		public FileObj() { }
		public FileObj(string pathToFile)
		{
			this.PathToFile = pathToFile;
		}

		public string Name => _name;

		public string FileType
		{
			get
			{
				switch (_type_e)
				{
					case swDocumentTypes_e.swDocPART:
						return "part";
					case swDocumentTypes_e.swDocASSEMBLY:
						return "assembly";
					case swDocumentTypes_e.swDocDRAWING:
						return "drawing";
					default:
						return "unknowm";
				}
			}
		}

		public swDocumentTypes_e SwType_e => _type_e;

		public string PathToFile
		{
			get => _pathToFile;
			set
			{
				if (!File.Exists(value))
					throw new InvalidDataException("Path is wrong");

				_pathToFile = value;

				string ex = Path.GetExtension(_pathToFile).ToLower();
				if (ex.Contains("sldprt"))
					_type_e = swDocumentTypes_e.swDocPART;
				else if (ex.Contains("sldasm"))
					_type_e = swDocumentTypes_e.swDocASSEMBLY;
				else if (ex.Contains("slddrw"))
					_type_e = swDocumentTypes_e.swDocDRAWING;
				else
					_type_e = swDocumentTypes_e.swDocNONE;

				_name = Path.GetFileNameWithoutExtension(_pathToFile);

				FileAttributes attributes = File.GetAttributes(value);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					Note = "Read only";
					_read_only = true;
				}
				else
					Note = "";
			}
		}
		
		
		
		public string Note { get => _note; set { _note = value; NotifyPropertyChanged(); } }

		public bool Read_only { get => _read_only;  }
		
		public List<string> ConfigNames { get => _configNames; set => _configNames = value; }

		//event for change
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}


}
