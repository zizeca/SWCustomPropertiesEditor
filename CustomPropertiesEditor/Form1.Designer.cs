namespace CustomPropertiesEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearItem_filesTable = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePropertiesAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearItem_settingsTable = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importItem_main = new System.Windows.Forms.ToolStripMenuItem();
			this.importItem_config = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel_time = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.bindingSource_swSettings = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource_swFolder = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView_swSettings = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonOpenProperties = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonSaveProperties = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSavePropertiesAs = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonClearProperties = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSplitButton_import = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripMenuItemImportMain = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemImportCustom = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView_swFolder = new System.Windows.Forms.DataGridView();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAddFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAddFolder = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonClearFileTable = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripComboBox_addTo = new System.Windows.Forms.ToolStripComboBox();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_start = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swFolder)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swSettings)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swFolder)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1078, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.clearItem_filesTable,
            this.toolStripSeparator1,
            this.openPropertiesToolStripMenuItem,
            this.savePropertiesToolStripMenuItem,
            this.savePropertiesAsToolStripMenuItem,
            this.clearItem_settingsTable,
            this.toolStripSeparator2,
            this.importToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// addFileToolStripMenuItem
			// 
			this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
			this.addFileToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.addFileToolStripMenuItem.Text = "Add file";
			this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.addFolderToolStripMenuItem.Text = "Add folder";
			this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
			// 
			// clearItem_filesTable
			// 
			this.clearItem_filesTable.Name = "clearItem_filesTable";
			this.clearItem_filesTable.Size = new System.Drawing.Size(266, 30);
			this.clearItem_filesTable.Text = "Clear files table";
			this.clearItem_filesTable.Click += new System.EventHandler(this.clearItem_filesTable_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
			// 
			// openPropertiesToolStripMenuItem
			// 
			this.openPropertiesToolStripMenuItem.Name = "openPropertiesToolStripMenuItem";
			this.openPropertiesToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.openPropertiesToolStripMenuItem.Text = "Open properties";
			this.openPropertiesToolStripMenuItem.Click += new System.EventHandler(this.openPropertiesToolStripMenuItem_Click);
			// 
			// savePropertiesToolStripMenuItem
			// 
			this.savePropertiesToolStripMenuItem.Name = "savePropertiesToolStripMenuItem";
			this.savePropertiesToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.savePropertiesToolStripMenuItem.Text = "Save properties";
			this.savePropertiesToolStripMenuItem.Click += new System.EventHandler(this.savePropertiesToolStripMenuItem_Click);
			// 
			// savePropertiesAsToolStripMenuItem
			// 
			this.savePropertiesAsToolStripMenuItem.Name = "savePropertiesAsToolStripMenuItem";
			this.savePropertiesAsToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.savePropertiesAsToolStripMenuItem.Text = "Save properties As";
			this.savePropertiesAsToolStripMenuItem.Click += new System.EventHandler(this.savePropertiesAsToolStripMenuItem_Click);
			// 
			// clearItem_settingsTable
			// 
			this.clearItem_settingsTable.Name = "clearItem_settingsTable";
			this.clearItem_settingsTable.Size = new System.Drawing.Size(266, 30);
			this.clearItem_settingsTable.Text = "Clear properties Table";
			this.clearItem_settingsTable.Click += new System.EventHandler(this.clearItem_settingsTable_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importItem_main,
            this.importItem_config});
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.importToolStripMenuItem.Text = "Import";
			// 
			// importItem_main
			// 
			this.importItem_main.Name = "importItem_main";
			this.importItem_main.Size = new System.Drawing.Size(293, 30);
			this.importItem_main.Text = "From main table";
			this.importItem_main.Click += new System.EventHandler(this.importItem_main_Click);
			// 
			// importItem_config
			// 
			this.importItem_config.Name = "importItem_config";
			this.importItem_config.Size = new System.Drawing.Size(293, 30);
			this.importItem_config.Text = "From configuration table";
			this.importItem_config.Click += new System.EventHandler(this.importItem_config_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel_time,
            this.toolStripStatusLabel_status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 627);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1078, 31);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 25);
			// 
			// toolStripStatusLabel_time
			// 
			this.toolStripStatusLabel_time.Name = "toolStripStatusLabel_time";
			this.toolStripStatusLabel_time.Size = new System.Drawing.Size(80, 26);
			this.toolStripStatusLabel_time.Text = "00:00:00";
			// 
			// toolStripStatusLabel_status
			// 
			this.toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
			this.toolStripStatusLabel_status.Size = new System.Drawing.Size(65, 26);
			this.toolStripStatusLabel_status.Text = "Ready!";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button_cancel, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.button_start, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 594);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// splitContainer1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 3);
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AutoScroll = true;
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
			this.splitContainer1.Panel1MinSize = 200;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
			this.splitContainer1.Panel2MinSize = 200;
			this.splitContainer1.Size = new System.Drawing.Size(1072, 528);
			this.splitContainer1.SplitterDistance = 400;
			this.splitContainer1.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.dataGridView_swSettings, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 528);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// dataGridView_swSettings
			// 
			this.dataGridView_swSettings.AllowUserToResizeRows = false;
			this.dataGridView_swSettings.AutoGenerateColumns = false;
			this.dataGridView_swSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_swSettings.DataSource = this.bindingSource_swSettings;
			this.dataGridView_swSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_swSettings.Location = new System.Drawing.Point(3, 49);
			this.dataGridView_swSettings.Name = "dataGridView_swSettings";
			this.dataGridView_swSettings.RowHeadersWidth = 35;
			this.dataGridView_swSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView_swSettings.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.dataGridView_swSettings.RowTemplate.Height = 23;
			this.dataGridView_swSettings.Size = new System.Drawing.Size(394, 476);
			this.dataGridView_swSettings.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenProperties,
            this.toolStripSeparator4,
            this.toolStripButtonSaveProperties,
            this.toolStripButtonSavePropertiesAs,
            this.toolStripSeparator5,
            this.toolStripButtonClearProperties,
            this.toolStripSeparator7,
            this.toolStripSplitButton_import});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.Size = new System.Drawing.Size(400, 46);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonOpenProperties
			// 
			this.toolStripButtonOpenProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpenProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenProperties.Image")));
			this.toolStripButtonOpenProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOpenProperties.Name = "toolStripButtonOpenProperties";
			this.toolStripButtonOpenProperties.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonOpenProperties.Text = "Open Properties";
			this.toolStripButtonOpenProperties.Click += new System.EventHandler(this.openPropertiesToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 46);
			// 
			// toolStripButtonSaveProperties
			// 
			this.toolStripButtonSaveProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSaveProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveProperties.Image")));
			this.toolStripButtonSaveProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSaveProperties.Name = "toolStripButtonSaveProperties";
			this.toolStripButtonSaveProperties.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonSaveProperties.Text = "Save";
			this.toolStripButtonSaveProperties.Click += new System.EventHandler(this.savePropertiesToolStripMenuItem_Click);
			// 
			// toolStripButtonSavePropertiesAs
			// 
			this.toolStripButtonSavePropertiesAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSavePropertiesAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSavePropertiesAs.Image")));
			this.toolStripButtonSavePropertiesAs.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSavePropertiesAs.Name = "toolStripButtonSavePropertiesAs";
			this.toolStripButtonSavePropertiesAs.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonSavePropertiesAs.Text = "Save As";
			this.toolStripButtonSavePropertiesAs.Click += new System.EventHandler(this.savePropertiesAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 46);
			// 
			// toolStripButtonClearProperties
			// 
			this.toolStripButtonClearProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonClearProperties.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearProperties.Image")));
			this.toolStripButtonClearProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonClearProperties.Name = "toolStripButtonClearProperties";
			this.toolStripButtonClearProperties.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonClearProperties.Text = "Clear";
			this.toolStripButtonClearProperties.Click += new System.EventHandler(this.clearItem_settingsTable_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 46);
			// 
			// toolStripSplitButton_import
			// 
			this.toolStripSplitButton_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImportMain,
            this.toolStripMenuItemImportCustom});
			this.toolStripSplitButton_import.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_import.Image")));
			this.toolStripSplitButton_import.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton_import.Name = "toolStripSplitButton_import";
			this.toolStripSplitButton_import.Size = new System.Drawing.Size(45, 43);
			this.toolStripSplitButton_import.Text = "Import";
			this.toolStripSplitButton_import.ButtonClick += new System.EventHandler(this.importItem_main_Click);
			// 
			// toolStripMenuItemImportMain
			// 
			this.toolStripMenuItemImportMain.Name = "toolStripMenuItemImportMain";
			this.toolStripMenuItemImportMain.Size = new System.Drawing.Size(299, 30);
			this.toolStripMenuItemImportMain.Text = "Import from confg prop";
			this.toolStripMenuItemImportMain.Click += new System.EventHandler(this.importItem_config_Click);
			// 
			// toolStripMenuItemImportCustom
			// 
			this.toolStripMenuItemImportCustom.Name = "toolStripMenuItemImportCustom";
			this.toolStripMenuItemImportCustom.Size = new System.Drawing.Size(299, 30);
			this.toolStripMenuItemImportCustom.Text = "Import from main prop";
			this.toolStripMenuItemImportCustom.Click += new System.EventHandler(this.importItem_main_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.dataGridView_swFolder, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.toolStrip2, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(668, 528);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// dataGridView_swFolder
			// 
			this.dataGridView_swFolder.AllowDrop = true;
			this.dataGridView_swFolder.AllowUserToAddRows = false;
			this.dataGridView_swFolder.AllowUserToResizeRows = false;
			this.dataGridView_swFolder.AutoGenerateColumns = false;
			this.dataGridView_swFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_swFolder.DataSource = this.bindingSource_swFolder;
			this.dataGridView_swFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_swFolder.Location = new System.Drawing.Point(3, 49);
			this.dataGridView_swFolder.Name = "dataGridView_swFolder";
			this.dataGridView_swFolder.ReadOnly = true;
			this.dataGridView_swFolder.RowTemplate.Height = 28;
			this.dataGridView_swFolder.Size = new System.Drawing.Size(662, 476);
			this.dataGridView_swFolder.TabIndex = 1;
			this.dataGridView_swFolder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_swFolder_CellFormatting);
			this.dataGridView_swFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView_swFolder_DragDrop);
			this.dataGridView_swFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView_swFolder_DragEnter);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFile,
            this.toolStripButtonAddFolder,
            this.toolStripSeparator6,
            this.toolStripButtonClearFileTable,
            this.toolStripSeparator8,
            this.toolStripLabel1,
            this.toolStripComboBox_addTo});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip2.Size = new System.Drawing.Size(668, 46);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripButtonAddFile
			// 
			this.toolStripButtonAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFile.Image")));
			this.toolStripButtonAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddFile.Name = "toolStripButtonAddFile";
			this.toolStripButtonAddFile.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonAddFile.Text = "Add files";
			this.toolStripButtonAddFile.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
			// 
			// toolStripButtonAddFolder
			// 
			this.toolStripButtonAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFolder.Image")));
			this.toolStripButtonAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAddFolder.Name = "toolStripButtonAddFolder";
			this.toolStripButtonAddFolder.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonAddFolder.Text = "Add folder";
			this.toolStripButtonAddFolder.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 46);
			// 
			// toolStripButtonClearFileTable
			// 
			this.toolStripButtonClearFileTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonClearFileTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearFileTable.Image")));
			this.toolStripButtonClearFileTable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonClearFileTable.Name = "toolStripButtonClearFileTable";
			this.toolStripButtonClearFileTable.Size = new System.Drawing.Size(28, 43);
			this.toolStripButtonClearFileTable.Text = "Clear";
			this.toolStripButtonClearFileTable.Click += new System.EventHandler(this.clearItem_filesTable_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 46);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(210, 43);
			this.toolStripLabel1.Text = "Add to custom property:";
			// 
			// toolStripComboBox_addTo
			// 
			this.toolStripComboBox_addTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox_addTo.MaxDropDownItems = 3;
			this.toolStripComboBox_addTo.Name = "toolStripComboBox_addTo";
			this.toolStripComboBox_addTo.Size = new System.Drawing.Size(90, 46);
			this.toolStripComboBox_addTo.ToolTipText = "where to add properties?";
			this.toolStripComboBox_addTo.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox_addTo_SelectedIndexChanged);
			// 
			// button_cancel
			// 
			this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_cancel.Location = new System.Drawing.Point(931, 537);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(144, 54);
			this.button_cancel.TabIndex = 4;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_start
			// 
			this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_start.Location = new System.Drawing.Point(781, 537);
			this.button_start.Name = "button_start";
			this.button_start.Size = new System.Drawing.Size(144, 54);
			this.button_start.TabIndex = 5;
			this.button_start.Text = "Start";
			this.button_start.UseVisualStyleBackColor = true;
			this.button_start.Click += new System.EventHandler(this.button_start_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 658);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(793, 384);
			this.Name = "Form1";
			this.Text = "Properties setup";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swFolder)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swSettings)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swFolder)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem openPropertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePropertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savePropertiesAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.BindingSource bindingSource_swFolder;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_status;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView_swSettings;
		private System.Windows.Forms.DataGridView dataGridView_swFolder;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem clearItem_filesTable;
		private System.Windows.Forms.ToolStripMenuItem clearItem_settingsTable;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importItem_main;
		private System.Windows.Forms.ToolStripMenuItem importItem_config;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddFile;
		private System.Windows.Forms.ToolStripButton toolStripButtonAddFolder;
		private System.Windows.Forms.ToolStripButton toolStripButtonClearFileTable;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonOpenProperties;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButtonSaveProperties;
		private System.Windows.Forms.ToolStripButton toolStripButtonSavePropertiesAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton toolStripButtonClearProperties;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_import;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportMain;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportCustom;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox_addTo;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		internal System.Windows.Forms.BindingSource bindingSource_swSettings;
	}
}

