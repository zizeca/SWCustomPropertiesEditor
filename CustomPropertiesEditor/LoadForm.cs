using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPropertiesEditor
{
	public partial class LoadForm : Form
	{
		public LoadForm()
		{
			InitializeComponent();
		}

		private void LoadForm_Load(object sender, EventArgs e)
		{
			this.MaximizeBox = false;
			this.MaximizeBox = false;
			
			this.label1.Text = "Please wait...";

			base.OnShown(e);
			if (Owner != null && StartPosition == FormStartPosition.Manual)
			{
				int offset = Owner.OwnedForms.Length * 38;  // approx. 10mm
				Point p = new Point(Owner.Left + Owner.Width / 2 - Width / 2 + offset, Owner.Top + Owner.Height / 2 - Height / 2 + offset);
				this.Location = p;
			}

		}
	}
}
