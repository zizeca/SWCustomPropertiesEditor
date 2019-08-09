using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPropertiesEditor
{
	public partial class MessageForm : Form
	{
		public MessageForm()
		{
			InitializeComponent();
		}

		public SldWorks swApp;
		public ModelDoc2 doc;
		public List<string> configurations = new List<string>();
		private async void MessageForm_Load(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;

			if (dialog.ShowDialog() != DialogResult.OK)
			{
				this.Close();
				return;
			}

			string path = dialog.FileName;
			if (!File.Exists(path))
			{
				this.Close();
				return;
			}


			this.Text = "Loading...";
			this.button_import.Enabled = false;
			this.comboBox_config.Enabled = false;

			Form1 f = (Form1)this.Owner;

			this.label1.Text = "Start Solidworks";
			if (swApp == null)
				swApp = await SolidworksSingleton.GetSwAppAsync();

			string ext = Path.GetExtension(path);
			swDocumentTypes_e type;

			if (ext.ToLower().Contains("sldprt"))
				type = swDocumentTypes_e.swDocPART;
			else if (ext.ToLower().Contains("sldasm"))
				type = swDocumentTypes_e.swDocASSEMBLY;
			else
			{
				this.Close();
				return;
			}

			try
			{
				int Error = 0;
				int Warning = 0;
				doc = swApp.OpenDoc6(path, (int)type, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", ref Error, ref Warning);

				if (Error != 0)
				{
					MessageBox.Show("Fail to open file");
					this.Close();
					return;
				}
				configurations.AddRange(doc.GetConfigurationNames());
				comboBox_config.DataSource = configurations;
				comboBox_config.Enabled = true;

			}
			catch (Exception)
			{

				throw ;
			}

		}

		private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(doc != null)
			{
				doc.Close();
				doc = null;
			}

		}
	}
}
