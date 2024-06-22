using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class FilterBox : Form
	{

		string findName;
		public FilterBox()
		{
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			//Close();
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			findName = textBox1.Text;
			DialogResult = DialogResult.OK;
		}

		public string GetName()
		{
			return findName;
		}
	}
}
