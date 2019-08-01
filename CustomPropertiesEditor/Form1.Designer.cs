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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePropertiesAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel_time = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridView_swSettings = new System.Windows.Forms.DataGridView();
			this.bindingSource_swSettings = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView_swFolder = new System.Windows.Forms.DataGridView();
			this.bindingSource_swFolder = new System.Windows.Forms.BindingSource(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_start = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swFolder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swFolder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(1079, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.addFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.openPropertiesToolStripMenuItem,
            this.savePropertiesToolStripMenuItem,
            this.savePropertiesAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// addFileToolStripMenuItem
			// 
			this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
			this.addFileToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
			this.addFileToolStripMenuItem.Text = "Add file";
			this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
			this.addFolderToolStripMenuItem.Text = "Add folder";
			this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
			// 
			// openPropertiesToolStripMenuItem
			// 
			this.openPropertiesToolStripMenuItem.Name = "openPropertiesToolStripMenuItem";
			this.openPropertiesToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
			this.openPropertiesToolStripMenuItem.Text = "Open properties";
			this.openPropertiesToolStripMenuItem.Click += new System.EventHandler(this.openPropertiesToolStripMenuItem_Click);
			// 
			// savePropertiesToolStripMenuItem
			// 
			this.savePropertiesToolStripMenuItem.Name = "savePropertiesToolStripMenuItem";
			this.savePropertiesToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
			this.savePropertiesToolStripMenuItem.Text = "Save properties";
			// 
			// savePropertiesAsToolStripMenuItem
			// 
			this.savePropertiesAsToolStripMenuItem.Name = "savePropertiesAsToolStripMenuItem";
			this.savePropertiesAsToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
			this.savePropertiesAsToolStripMenuItem.Text = "Save properties As";
			this.savePropertiesAsToolStripMenuItem.Click += new System.EventHandler(this.savePropertiesAsToolStripMenuItem_Click);
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 629);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1079, 30);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
			// 
			// toolStripStatusLabel_time
			// 
			this.toolStripStatusLabel_time.Name = "toolStripStatusLabel_time";
			this.toolStripStatusLabel_time.Size = new System.Drawing.Size(80, 25);
			this.toolStripStatusLabel_time.Text = "00:00:00";
			// 
			// toolStripStatusLabel_status
			// 
			this.toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
			this.toolStripStatusLabel_status.Size = new System.Drawing.Size(65, 25);
			this.toolStripStatusLabel_status.Text = "Ready!";
			// 
			// dataGridView_swSettings
			// 
			this.dataGridView_swSettings.AllowUserToResizeRows = false;
			this.dataGridView_swSettings.AutoGenerateColumns = false;
			this.dataGridView_swSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_swSettings.DataSource = this.bindingSource_swSettings;
			this.dataGridView_swSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_swSettings.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_swSettings.Name = "dataGridView_swSettings";
			this.dataGridView_swSettings.RowHeadersWidth = 35;
			this.dataGridView_swSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView_swSettings.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.dataGridView_swSettings.RowTemplate.Height = 23;
			this.dataGridView_swSettings.Size = new System.Drawing.Size(540, 530);
			this.dataGridView_swSettings.TabIndex = 0;
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
			this.dataGridView_swFolder.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_swFolder.Name = "dataGridView_swFolder";
			this.dataGridView_swFolder.ReadOnly = true;
			this.dataGridView_swFolder.RowTemplate.Height = 28;
			this.dataGridView_swFolder.Size = new System.Drawing.Size(529, 530);
			this.dataGridView_swFolder.TabIndex = 1;
			this.dataGridView_swFolder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_swFolder_CellFormatting);
			this.dataGridView_swFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView_swFolder_DragDrop);
			this.dataGridView_swFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView_swFolder_DragEnter);
			// 
			// splitContainer1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 4);
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AutoScroll = true;
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView_swSettings);
			this.splitContainer1.Panel1MinSize = 100;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView_swFolder);
			this.splitContainer1.Panel2MinSize = 100;
			this.splitContainer1.Size = new System.Drawing.Size(1073, 530);
			this.splitContainer1.SplitterDistance = 540;
			this.splitContainer1.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.99346F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.00654F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button_cancel, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.button_start, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1079, 596);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// button_cancel
			// 
			this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_cancel.Location = new System.Drawing.Point(931, 539);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(145, 54);
			this.button_cancel.TabIndex = 4;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_start
			// 
			this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_start.Location = new System.Drawing.Point(781, 539);
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
			this.ClientSize = new System.Drawing.Size(1079, 659);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "Form1";
			this.Text = "Properties setup";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_swFolder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource_swFolder)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
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
		private System.Windows.Forms.DataGridView dataGridView_swSettings;
		private System.Windows.Forms.DataGridView dataGridView_swFolder;
		private System.Windows.Forms.BindingSource bindingSource_swFolder;
		private System.Windows.Forms.BindingSource bindingSource_swSettings;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_start;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_status;
	}
}

