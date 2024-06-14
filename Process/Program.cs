#define SINGLE_PROCESS
#define MULTIPLE_PROCESS

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Threading;

namespace Process
{
	internal class Program
	{

		static string getUsetName(IntPtr process_handle)
		{
			IntPtr handle = IntPtr.Zero;
			OpenProcessToken(process_handle, 8, out handle);
			System.Security.Principal.WindowsIdentity wi = new System.Security.Principal.WindowsIdentity(handle);
			string name = wi.Name;
			CloseHandle(handle);
			return name;
		}

		static void Main(string[] args)
		{
#if SIGLE_PROCESS
			Console.Write("Введите имя программы: ");
			string process_name = Console.ReadLine();
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = process_name;
			process.Start();



			Console.WriteLine(process.Id);

			Console.WriteLine(process.ProcessName);
			Console.WriteLine($"User name: {getUsetName(process.Handle)}");
			Console.WriteLine($"SessionID: {process.SessionId}");
			Console.WriteLine($"Threads: {process.Threads.Count}");
			Console.WriteLine($"Priority Class: {process.PriorityClass}");
#endif

	


		}

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr processHandle, 
			uint desiredAcsess, out IntPtr handle);

		[DllImport("kernel32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr handle);
	}
}
