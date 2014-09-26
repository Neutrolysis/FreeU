using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FreeU
{
	public partial class Select_Port : Form
	{
		public Select_Port()
		{
			InitializeComponent();
		}

		private void Select_Port_Load(object sender, EventArgs e)
		{
			btnUpdate_Click(sender, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cmbPorts.SelectedItem != null)
			{
				FreeU.Properties.Settings.Default.DEFAULT_PORT_NAME = cmbPorts.SelectedItem.ToString();
				Close();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			cmbPorts.Items.Clear();
			if (SerialPort.GetPortNames().Count() >= 0)
				foreach (string p in SerialPort.GetPortNames())
					cmbPorts.Items.Add(p);
		}
	}
}
