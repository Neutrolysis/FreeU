using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
		public string listen()
		{
			p.StartInfo.Arguments = "NotifyMe";
			p.Start();
			return p.StandardOutput.ReadToEnd();
		}
	}
}
