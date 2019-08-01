using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CustomPropertiesEditor
{
    public partial class Form1 : Form
    {

		public Form1()
        {
            InitializeComponent();
        }

		//variables
		//
		public SldWorks swApp = null;

		
		private void Form1_Load(object sender, EventArgs e)
		{
			bindingSource_swSettings.DataSource = new BindingList<PropertyObject>();
			bindingSource_swFolder.DataSource = new BindingList<FileObj>();
			//bindingSource_swSettings.AddingNew = new PropertyObject();

			DataGridViewColumn column; // = new DataGridViewTextBoxColumn();
			//dataGridView for folder
			dataGridView_swFolder.AutoGenerateColumns = false;
			dataGridView_swFolder.AutoSize = true;
			//dataGridView_swFolder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			//column Name
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "Name";
			column.Name = "Name";
			column.ReadOnly = true;
			column.ToolTipText = " File name";
			column.Width = 200;
			//column.DefaultCellStyle.Format = "0.0";
			dataGridView_swFolder.Columns.Add(column);
			//Column Note
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "Note";
			column.Name = "Note";
			column.ReadOnly = true;
			column.ToolTipText = "Information about process";
			dataGridView_swFolder.Columns.Add(column);

			//*
			//dataGrid for settings
			dataGridView_swSettings.AutoGenerateColumns = false;
			dataGridView_swSettings.AutoSize = false;
			//column propertiName
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "PropertyName";
			column.Name = "Property name";
			column.ToolTipText = "Property for add to files";
			column.MinimumWidth = 100;
			dataGridView_swSettings.Columns.Add(column);
			//column enum
		
			

			dataGridView_swSettings.Columns.Add(CreateComboBoxWithEnums());
			//column value
			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "Value";
			column.Name = "Value / Text expression";
			column.ToolTipText = "Properti for add to files";
			column.MinimumWidth = 150;
			dataGridView_swSettings.Columns.Add(column);


			//bindingSource_swSettings.Add(PropertyObjectsList);


			//bindingSource_swSettings.DataSource = list;
			//*/

			setEnableUiTools(true);

			

		}

		//non ui methods
		//
		private DataGridViewComboBoxColumn CreateComboBoxWithEnums()
		{
			DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
			combo.DataSource = Enum.GetValues(typeof(TypeData));
			combo.DataPropertyName = "Type_Data";
			combo.Name = "Type Data";
			combo.ValueType = typeof(TypeData);
			combo.Width = 80;
			combo.MinimumWidth = 70;
			
			
			//DataGridViewCellStyle style = new DataGridViewCellStyle();

			//combo.DataGridView.AutoSize = false;
			
			
			//combo.ValueMember = "Text";

			//combo.DisplayMember = combo.ValueMember;
			//combo.ValueMember = PropertyObject.TypeData.Text.ToString();
			return combo;
		}

		private void setEnableUiTools(bool enable)
		{
			addFileToolStripMenuItem.Enabled =  enable;
			addFolderToolStripMenuItem.Enabled = enable;
			openPropertiesToolStripMenuItem.Enabled = enable;
			savePropertiesToolStripMenuItem.Enabled = enable;
			savePropertiesAsToolStripMenuItem.Enabled = enable;

			
			dataGridView_swSettings.ReadOnly = !enable;
			dataGridView_swSettings.AllowUserToAddRows = enable;
			dataGridView_swSettings.AllowUserToDeleteRows = enable;
			dataGridView_swFolder.AllowDrop = enable;
			dataGridView_swFolder.AllowUserToDeleteRows = enable;


			button_start.Enabled = enable;
			button_cancel.Enabled = !enable;
		}


		//form methods
		private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			
			DialogResult result = dialog.ShowDialog();
			if(result == DialogResult.OK)
			{
				string folder = dialog.SelectedPath;
				Helper.HelperResult err = Helper.AddFolder(bindingSource_swFolder, folder);
				if(err!= Helper.HelperResult.SUCCESS)
				{
					MessageBox.Show("Wrong folder");
				}

			}
		}

		private void dataGridView_swFolder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if ((e.ColumnIndex == this.dataGridView_swFolder.Columns["Name"].Index) && e.Value != null)
			{
				DataGridViewCell cell = this.dataGridView_swFolder.Rows[e.RowIndex].Cells[e.ColumnIndex];
				cell.ToolTipText = ((FileObj)(dataGridView_swFolder.Rows[e.RowIndex].DataBoundItem)).PathToFile;
			}
		}

		private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
		{

			OpenFileDialog dialog = new OpenFileDialog();

			if(swApp != null)
				dialog.InitialDirectory = swApp.GetCurrentWorkingDirectory();
			
			dialog.Filter = "Solidworks (*.sldprt;*.sldasm;*.slddrw)|*.sldprt;*.sldasm;*.slddrw|Parts (*.sldprt)|*.sldprt|Assemblies (*.sldasm)|*.sldasm|Drawings (*.slddrw)|*.slddrw|All files (*.*)|*.*";
			dialog.Multiselect = true;


			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				Helper.HelperResult err = Helper.HelperResult.UNKNOWN;

				string[] files = dialog.FileNames;
				if (files.Any())
					err = Helper.AddFiles(bindingSource_swFolder, files);

				//if (!String.IsNullOrEmpty(file))
				//err = Helper.AddFile(bindingSource_swFolder, file);

				switch (err)
				{
					case Helper.HelperResult.SUCCESS:
						break;
					case Helper.HelperResult.UNKNOWN:
						MessageBox.Show("Unknown error");
						break;
					case Helper.HelperResult.NO_FILES:
						MessageBox.Show("No cad data");
						break;
					default:
						MessageBox.Show("Unknown error");
						break;
				}
			}
		}

		private void savePropertiesAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "XML|*.xml";
			if(bindingSource_swSettings.Count == 0)
			{
				Console.WriteLine("data binding is empty");
			}

			DataTable dt = new DataTable();

			dt.TableName = "settings";

			/*
			for (int i = 0; i < dataGridView_swSettings.Columns.Count; i++)
			{
				DataColumn c = new DataColumn();
				c.ColumnName = dataGridView_swSettings.Columns[i].HeaderText;
				dt.Columns.Add(c);
			}
			//*/

			dt.Columns.Add("property");
			dt.Columns.Add("type");
			dt.Columns.Add("value");

			foreach (DataGridViewRow currentRow in dataGridView_swSettings.Rows)
			{
				dt.Rows.Add();
				int runningCount = 0;
				//loop trough each column of the row
				foreach (DataGridViewCell item in currentRow.Cells)
				{
					dt.Rows[dt.Rows.Count - 1][runningCount] = item.FormattedValue;
					runningCount++;
				}
			}





			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					dt.WriteXml(sfd.FileName);

				}
				catch(Exception ex)
				{
					throw ex;
				}
			}


			

		}

		private void openPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "XML|*.xml";
			dialog.Multiselect = false;

			XmlDocument doc = new XmlDocument();

			BindingList<PropertyObject> list = new BindingList<PropertyObject>();

			if (dialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			
			doc.Load(dialog.FileName);
			Console.WriteLine("Loaded xml");

			XmlElement el = doc.DocumentElement;

			Console.WriteLine("elem:" + el.Name);

			XmlNodeList elemList = doc.GetElementsByTagName("settings");

			if(elemList.Count == 0)
			{
				return;
			}

			for (int i = 0; i < elemList.Count; i++)
			{
				PropertyObject obj = new PropertyObject();

				if (!elemList[i].HasChildNodes) continue;
				obj.PropertyName =  elemList[i].ChildNodes[0].InnerText;
				if (string.IsNullOrEmpty(obj.PropertyName)) continue;

				if (elemList[i].ChildNodes[1].InnerText.ToLower() == "bool")
				{
					obj.Type_Data = TypeData.Bool;
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

			bindingSource_swSettings.DataSource = list;

		}

		private void dataGridView_swFolder_DragEnter(object sender, DragEventArgs e)
		{
			// Check if the Data format of the file(s) can be accepted
			// (we only accept file drops from Windows Explorer, etc.)
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				// modify the drag drop effects to Move
				e.Effect = DragDropEffects.Move;

			}
			else
			{
				// no need for any drag drop effect
				e.Effect = DragDropEffects.None;
			}
		}

		private void dataGridView_swFolder_DragDrop(object sender, DragEventArgs e)
		{
			// still check if the associated data from the file(s) can be used for this purpose
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				Helper.HelperResult err = Helper.HelperResult.UNKNOWN;

				// Fetch the file(s) names with full path here to be processed
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

				if (files.Any())
					err = Helper.AddFiles(bindingSource_swFolder, files);

				//if (!String.IsNullOrEmpty(file))
				//err = Helper.AddFile(bindingSource_swFolder, file);

				switch (err)
				{
					case Helper.HelperResult.SUCCESS:
						break;
					case Helper.HelperResult.UNKNOWN:
						MessageBox.Show("Unknown error");
						break;
					case Helper.HelperResult.NO_FILES:
						MessageBox.Show("No cad data");
						break;
					default:
						MessageBox.Show("Unknown error");
						break;
				}

				// Your desired code goes here to process the file(s) being dropped
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 box = new AboutBox1();
			this.Enabled = false;
			box.Owner = this;
			box.Show();
		}

		private async void button_start_Click(object sender, EventArgs e)
		{
			setEnableUiTools(false);

			//check tables
			if (bindingSource_swSettings.Count == 0)
			{
				MessageBox.Show("Setting table is empty!\n Please add settings before you press start");
				setEnableUiTools(true);
				return;
			}
			if (bindingSource_swFolder.Count == 0)
			{
				MessageBox.Show("File table is empty!\n Please add file before you press start");
				setEnableUiTools(true);
				return;
			}

			BindingList<FileObj> list = (BindingList<FileObj>)bindingSource_swFolder.DataSource;
			
			if(list.Count == 0)
			{
				MessageBox.Show("Fail to read from table!");
				return;
			}
			
			toolStripProgressBar1.Maximum = list.Count;
			if (swApp == null)
				toolStripStatusLabel_status.Text = "Lunch SolidWorks...";
			swApp = await SolidworksSingleton.GetSwAppAsync();
			//swApp.Visible = false;
			if(swApp == null)
				MessageBox.Show("Fail to start Solid Works");
			else
				toolStripStatusLabel_status.Text = "SolidWorks started!";
			//run process method

			setEnableUiTools(true);
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			setEnableUiTools(true);
		}
	}
}
