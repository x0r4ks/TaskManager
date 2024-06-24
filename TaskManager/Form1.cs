using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections;
using System.Xml.Serialization;
using System.IO;



/*
 
TODO:
4. Добавить фильтрацию процессов по имени;
 */

enum RAM_Factor
{
	Bytes	= 0x1,
	KIB		= 0x400,
	MIB		= 0x100000,
	GIB		= 0x40000000,
}


namespace TaskManager
{

	public partial class MainForm : Form
	{

		Dictionary<int, Process> d_processes;

		List<String> history;

		RAM_Factor RAMFactor = RAM_Factor.KIB;

		public MainForm()
		{
			InitializeComponent();
			history = new List<String>();

			SetColumns();
			
			statusStrip.Items.Add("");
			LoadProcesses();

			d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);

			cb_memSize.SelectedIndex = 1;
		}



	private void timer_processesUpdate_Tick(object sender, EventArgs e)
		{
			AddNewProcesses();
			RemoveOldProcesses();
			UpdateExistingProcesses();

			statusStrip.Items[0].Text = $"Количество процессов: {listView_Processes.Items.Count}";
			

		}


		private void SetColumns()
		{
			listView_Processes.Columns.Clear();
			listView_Processes.Columns.Add("PID");
			listView_Processes.Columns.Add("Name");
			listView_Processes.Columns.Add("Working Set");
			listView_Processes.Columns.Add("Peak Working Set");

			listView_Processes.Columns[2].TextAlign = HorizontalAlignment.Right;
			listView_Processes.Columns[3].TextAlign = HorizontalAlignment.Right;
			
			for (int i = 0; i < listView_Processes.Columns.Count; i++)
			{
				listView_Processes.Columns[i].Width = -1;
			}

			listView_Processes.View = View.Details;
		}

		string GetPrefix(RAM_Factor factor)
		{
			string prefix = "unknow";

			switch (RAMFactor)
			{
				case RAM_Factor.Bytes:
					prefix = "B";
					break;

				case RAM_Factor.KIB:
					prefix = "KiB";
					break;

				case RAM_Factor.MIB:
					prefix = "MiB";
					break;

				case RAM_Factor.GIB:
					prefix = "GiB";
					break;
			}

			return prefix;
		}

		void AddProcessToListView(Process process)
		{

			

			ListViewItem liv = new ListViewItem();

			liv.Text = process.Id.ToString();
			liv.SubItems.Add(process.ProcessName);
			liv.SubItems.Add($"{ Math.Round(process.WorkingSet64 / (double)RAMFactor, 2)} {GetPrefix(RAMFactor)}");
			liv.SubItems.Add($"{ Math.Round(process.PeakWorkingSet64 / (double)RAMFactor, 2)} {GetPrefix(RAMFactor)}");


			listView_Processes.Items.Add(liv);
		}

		void UpdateExistingProcesses()
		{
			for (int i = 0; i < listView_Processes.Items.Count; i++)
			{
				int id = Convert.ToInt32(listView_Processes.Items[i].Text);
				if (d_processes.ContainsKey(id))
				{
					
					listView_Processes.Items[i].SubItems[2].Text =
						$"{Math.Round(d_processes[id].WorkingSet64 / (double)RAMFactor, 2)} {GetPrefix(RAMFactor)}";
					listView_Processes.Items[i].SubItems[3].Text = 
						$"{Math.Round(d_processes[id].PeakWorkingSet64 / (double)RAMFactor, 2)} {GetPrefix(RAMFactor)}";
				}
			}
		}

		private void LoadProcesses()
		{
			d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			foreach (var i in d_processes)
			{
				AddProcessToListView(i.Value);
			}
			statusStrip.Items[0].Text = $"Количество процессов: {listView_Processes.Items.Count}";
		}

		private void RemoveOldProcesses()
		{
			d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			for (int i = 0; i < listView_Processes.Items.Count; i++)
			{
				if (!d_processes.ContainsKey(Convert.ToInt32(listView_Processes.Items[i].Text)))
				{
					listView_Processes.Items.RemoveAt(i);
				}
			}
		}

		private void AddNewProcesses()
		{
			Dictionary<int, Process> d_proc = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			foreach (var i in d_proc)
			{
				if (!d_processes.ContainsKey(i.Key))
				{
					//this.d_processes.Add(i.Key, i.Value);
					AddProcessToListView(i.Value);
				}
			}
		}

		private void RemoveProcessFromListView(int pid)
		{
			listView_Processes.Items.RemoveByKey(pid.ToString());
		}

		static string getUsetName(IntPtr process_handle)
		{
			IntPtr handle = IntPtr.Zero;
			OpenProcessToken(process_handle, 8, out handle);
			System.Security.Principal.WindowsIdentity wi = new System.Security.Principal.WindowsIdentity(handle);
			string name = wi.Name;
			CloseHandle(handle);
			return name;
		}


		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr processHandle,
			uint desiredAcsess, out IntPtr handle);

		[DllImport("kernel32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr handle);

		private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			
			InputBox inputBox = new InputBox("Execute", history);
			inputBox.ShowDialog();
			history = inputBox.gHistory;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void killToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView_Processes.SelectedItems.Count > 0)
				{
					int id = Convert.ToInt32(listView_Processes.SelectedItems[0].Text);
					d_processes[id].Kill();
				}
			} catch(Exception err) {
				MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}

		private void cb_memSize_TextChanged(object sender, EventArgs e)
		{
			string memSize;
			try
			{
				memSize = cb_memSize.Items[cb_memSize.SelectedIndex].ToString();
			} catch
			{
				memSize = "KiB";
				cb_memSize.Text = memSize;
			}
			switch (memSize)
			{
				case "Bytes":
					RAMFactor = RAM_Factor.Bytes;
					break;

				case "KiB":
					RAMFactor = RAM_Factor.KIB;
					break;

				case "MiB":
					RAMFactor = RAM_Factor.MIB;
					break;

				case "GiB":
					RAMFactor = RAM_Factor.GIB;
					break;

				default:
					RAMFactor = RAM_Factor.KIB;
					break;
			}
		}

		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FilterBox filterBox = new FilterBox();
			
			if (filterBox.ShowDialog() == DialogResult.OK)
			{
				
			}
		}

		private void listView_Processes_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			listView_Processes.ListViewItemSorter = new ListViewItemComparer(e.Column);
		}

		private void SaveHistory()
		{
			XmlSerializer ser = new XmlSerializer(typeof(List<String>));

			using (FileStream fs = new FileStream("history.xml", FileMode.OpenOrCreate))
			{
				ser.Serialize(fs, history);
			}
		}

		private void LoadHistory()
		{

		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveHistory();
		}
	}
}