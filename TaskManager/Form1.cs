using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TaskManager
{
	public partial class MainForm : Form
    {

		Dictionary<int, Process> d_processes;

		static string getUsetName(IntPtr process_handle)
		{
			IntPtr handle = IntPtr.Zero;
			OpenProcessToken(process_handle, 8, out handle);
			System.Security.Principal.WindowsIdentity wi = new System.Security.Principal.WindowsIdentity(handle);
			string name = wi.Name;
			CloseHandle(handle);
			return name;
		}

		public MainForm()
        {
            InitializeComponent();

			SetColumns();
			statusStrip.Items.Add("");
			LoadProcesses();

			d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
		}



		private void timer_processesUpdate_Tick(object sender, EventArgs e)
		{
			
			AddNewProcesses();
			RemoveOldProcesses();

			statusStrip.Items[0].Text = $"Количество процессов: {listView_Processes.Items.Count}";	
		}


		private void SetColumns()
		{
			listView_Processes.Columns.Clear();
			listView_Processes.Columns.Add("PID");
			listView_Processes.Columns.Add("Name");
			//listView_Processes.Columns.Add("Path");
			listView_Processes.View = View.Details;
		}

		void AddProcessToListView(Process process)
		{
			ListViewItem liv = new ListViewItem();
			liv.Text = process.Id.ToString();
			liv.SubItems.Add(process.ProcessName);
			listView_Processes.Items.Add(liv);
		}

		private void LoadProcesses()
		{
			//listView_Processes.Items.Clear();
			d_processes = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			foreach (var i in d_processes)
			{
				AddProcessToListView(i.Value);
			}
		}

		private void RemoveOldProcesses()
		{
			for (int i = 0; i < listView_Processes.Items.Count; i++)
			{
				string item_name = listView_Processes.Items[i].Name;
				if (!d_processes.ContainsKey(Convert.ToInt32(listView_Processes.Items[i].Text)))
					listView_Processes.Items.RemoveAt(i);
			}
		}

		private void AddNewProcesses()
		{
			Dictionary<int, Process> d_proc = Process.GetProcesses().ToDictionary(item => item.Id, item => item);
			foreach (KeyValuePair<int, Process> i in d_proc)
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


		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr processHandle,
			uint desiredAcsess, out IntPtr handle);

		[DllImport("kernel32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr handle);
	}
}
