﻿#define SINGLE_PROCESS
//#define MULTIPLE_PROCESSES

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

		static void PrintProcessInfo(System.Diagnostics.Process p)
		{
			Console.WriteLine($"PID: {p.Id}\tName: {p.ProcessName}\t" +
				$"PATH: {p.MainModule.FileName}\t");

		}

		static void Main(string[] args)
		{
#if SINGLE_PROCESS

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


			PerformanceCounter counter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName, true);
			Console.WriteLine("Press Any key to continue ... ");

			while (!Console.KeyAvailable) {
				Console.Clear();
				double percent = counter.NextValue();
				Console.WriteLine($"{process.ProcessName} CPU load {percent/10}%");
				Console.WriteLine($"Working Set:	{process.WorkingSet64} B");
				Console.WriteLine($"Working Set:	{((double)process.PrivateMemorySize64) / 0x100000} MiB");
				
				Thread.Sleep(1000/10);
			}

				

#endif

#if MULTIPLE_PROCESSES


			System.Diagnostics.Process[] processes =
					 System.Diagnostics.Process.GetProcesses();

			foreach (System.Diagnostics.Process process in processes)
			{
				try
				{
					PrintProcessInfo(process);
				}
				catch { }

			}

			Console.ReadKey();
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
