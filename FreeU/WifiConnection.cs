using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;          // Serial stuff in here.
using System.Threading;
using System.Diagnostics;
using System.Collections.Concurrent;
namespace FreeU
{
	class WifiConnection
	{
		private Process p;

		public WifiConnection()
		{
			p = new Process
		   {
			   StartInfo = new ProcessStartInfo
			   {
				   UseShellExecute = false,
				   RedirectStandardOutput = true,
				   CreateNoWindow = true,
				   FileName = "java.exe",
			   }
		   };

		}
		public void send(String msg)
		{
			p.StartInfo.Arguments = "NotifyMe " + msg;
			p.Start();
		}

		public String listen()
		{
			p.StartInfo.Arguments = "NotifyMe";
			p.Start();
			return p.StandardOutput.ReadToEnd();
		}
	}
}
