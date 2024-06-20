using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class InputBox : Form
	{
		public InputBox(string name = "InputBox")
		{
			InitializeComponent();
			this.Name = name;
		}

		private void bnt_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_acept_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(tb_executeProg.Text);
				Close();
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
