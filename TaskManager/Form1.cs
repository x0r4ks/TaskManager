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

//using TaskManager.models;


namespace TaskManager
{
	public partial class MainForm : Form
    {
		static void PrintProcessInfo(System.Diagnostics.Process p)
		{
			Console.WriteLine($"PID: {p.Id}\tName: {p.ProcessName}\t" +
				$"PATH: {p.MainModule.FileName}\t");

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

		void DoubleBufferedListView()
		{
			Type type = listView_Processes.GetType();
			PropertyInfo pI = type.GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
			type.GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
			pI.SetValue(listView_Processes, true, null);
		}

		public MainForm()
        {
            InitializeComponent();


			//DoubleBufferedListView();

			SetColumns();
			statusStrip.Items.Add("");
			
		}



		private void timer_processesUpdate_Tick(object sender, EventArgs e)
		{
			LoadProcesses();
		}


		private void SetColumns()
		{
			listView_Processes.Columns.Clear();
			listView_Processes.Columns.Add("PID");
			listView_Processes.Columns.Add("Name");
			listView_Processes.Columns.Add("Path");
			listView_Processes.View = View.Details;
		}

		private void LoadProcesses()
		{
			listView_Processes.Items.Clear();
			
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes) {

				ListViewItem i = new ListViewItem();

				i.Text = process.Id.ToString();
				i.SubItems.Add(process.ProcessName);
				try
				{
					i.SubItems.Add(process.MainModule.FileName);
				} catch (Exception ex)
				{
					i.SubItems.Add("Up Privileges");
				}

				listView_Processes.Items.Add(i);
				statusStrip.Items[0].Text = $"Кол-во процессов: {listView_Processes.Items.Count}";
				
				
			}
		}


		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr processHandle,
			uint desiredAcsess, out IntPtr handle);

		[DllImport("kernel32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr handle);
	}
}
