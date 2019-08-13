namespace CustomPropertiesEditor
{
	partial class MessageForm
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
			this.comboBox_config = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button_import = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox_config
			// 
			this.comboBox_config.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_config.Location = new System.Drawing.Point(4, 157);
			this.comboBox_config.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox_config.Name = "comboBox_config";
			this.comboBox_config.Size = new System.Drawing.Size(217, 28);
			this.comboBox_config.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.Controls.Add(this.comboBox_config, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.button_import, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 192);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// button_import
			// 
			this.button_import.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_import.Location = new System.Drawing.Point(228, 155);
			this.button_import.Name = "button_import";
			this.button_import.Size = new System.Drawing.Size(144, 34);
			this.button_import.TabIndex = 1;
			this.button_import.Text = "Import";
			this.button_import.UseVisualStyleBackColor = true;
			this.button_import.Click += new System.EventHandler(this.Button_import_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// button_Cancel
			// 
			this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_Cancel.Location = new System.Drawing.Point(379, 157);
			this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(142, 30);
			this.button_Cancel.TabIndex = 3;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// MessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 192);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximumSize = new System.Drawing.Size(594, 384);
			this.MinimumSize = new System.Drawing.Size(193, 184);
			this.Name = "MessageForm";
			this.Text = "MessageForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageForm_FormClosing);
			this.Load += new System.EventHandler(this.MessageForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button_import;
		private System.Windows.Forms.ComboBox comboBox_config;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Cancel;
	}
}