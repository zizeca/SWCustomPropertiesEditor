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

		private SldWorks swApp;
		private ModelDoc2 doc;
		private List<string> configurations = new List<string>();
		private string path;
		private async void MessageForm_Load(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;
			dialog.Filter = "Solidworks 3d (*.sldprt;*.sldasm)|*.sldprt;*.sldasm|Parts (*.sldprt)|*.sldprt|Assemblies (*.sldasm)";

			if (dialog.ShowDialog() != DialogResult.OK)
			{
				this.Close();
				return;
			}

			path = dialog.FileName;
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
			button_import.Enabled = false;
			if (swApp == null)
				swApp = await SolidworksSingleton.GetSwAppAsync();

			this.label1.Text = "Choose configugation name\n and press import.";
			button_import.Enabled = true;

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
			if(doc != null && swApp != null)
			{
				swApp.QuitDoc(doc.GetTitle());
				doc = null;
			}
		}



		private void Button_import_Click(object sender, EventArgs e)
		{
			Helper.HelperResult res = Helper.ImportProperties(swApp,
				((Form1)this.Owner).bindingSource_swSettings,
				path, comboBox_config.SelectedItem.ToString()
				);
			this.Close();
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
