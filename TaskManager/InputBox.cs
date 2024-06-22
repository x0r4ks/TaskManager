using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class InputBox : Form
	{
		public List<String> gHistory;
		public int history_size = 3;
		public InputBox(string name = "InputBox", List<String> history = null)
		{
			InitializeComponent();
			this.Name = name;
			gHistory = history;

			if (history != null )
			{
				for (int i = history.Count - 1; i >= 0; i--)
				{
					cb_executeProcess.Items.Add(history[i]);
				}
			}
		}

		private void bnt_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_acept_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(cb_executeProcess.Text);
				if (!gHistory.Contains(cb_executeProcess.Text))
				{
					if (gHistory.Count > history_size-1)
					{
						gHistory.RemoveAt(0);
					}
					gHistory.Add(cb_executeProcess.Text);
					
				}
				Close();
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_overview_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				cb_executeProcess.Text = openFileDialog.FileName;
			}

		}
	}
}
