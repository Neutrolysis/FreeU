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

namespace FreeU
{
	public partial class MainForm : Form
	{
		Serial zigbee = new Serial();

		SensorsUnit sensors = new SensorsUnit();

		public MainForm()
		{
			InitializeComponent();
			putCOMSIntoMenu();
			acTemp = (int)numericUpDown1.Value;
			try
			{
				zigbee.setupPort();
			}
			catch (System.IO.IOException error)
			{
				println(error.Message);
				this.Show();
			}
			timer1.Start();
		}
		void putCOMSIntoMenu()
		{
			portToolStripMenuItem.DropDownItems.Clear();
			if (SerialPort.GetPortNames().Count() > 0)
				foreach (string p in SerialPort.GetPortNames())
				{
					portToolStripMenuItem.DropDownItems.Add(p);
					//if (zigbee.isConnected()) && p.Equals(zigbee.getPortName()))
					{
						//((ToolStripMenuItem)portToolStripMenuItem.DropDownItems[portToolStripMenuItem.DropDownItems.Count - 1]).CheckOnClick = true;
					}
				}

			portToolStripMenuItem.DropDownItems.Add("-");
			portToolStripMenuItem.DropDownItems.Add("Update");
		}


		public void println(String msg)
		{
			txtSerial.AppendText("\r\n" + msg);
		}

		Alarm fireAlarm = new Alarm();
		EnergyCalculator energy = new EnergyCalculator();
		void timer1_Tick(object sender, EventArgs e) //Procssing Monitoring
		{
			while (zigbee.hasMsg())
			{
				String receivedMsg = zigbee.nextMsg();
				println(receivedMsg);

				try
				{
					//Extract key and value from a command
					char key = receivedMsg[0];
					string value = receivedMsg.Substring(1, receivedMsg.Length - 1);
					double receivedValue = 0;
					try { receivedValue = double.Parse(value); }
					catch (FormatException err) { println(err.Message); }

					//	switching on key
					switch (key)
					{
						case 'T':
							lblTemp.Text = value;
							sensors.temp = receivedValue;
							break;
						case 'H':
							lblHumidity.Text = value;
							sensors.humidity = receivedValue;
							break;
						case 'S':
							lblSmoke.Text = value;
							sensors.smoke = receivedValue;
							break;
						case 'I':
							lblPower.Text = (receivedValue / 1000 * 220).ToString() + " W";
							sensors.power = receivedValue;
							energy.addCurrentReading(receivedValue);
							lblEnergy.Text = energy.getConsumedPower().ToString();
							break;
						case 'R':
							if (receivedValue == 1 && chkLED1.Checked == false)
								chkLED1.Checked = true;
							else if (receivedValue == 0 && chkLED1.Checked == true)
								chkLED1.Checked = false;
							break;
						case 'L':
							if (receivedValue == 1 && chkLED2.Checked == false)
								chkLED2.Checked = true;
							else if (receivedValue == 0 && chkLED2.Checked == true)
								chkLED2.Checked = false;
							break;
						case 'W':
							if (receivedValue == 1 && chkWindow1.Checked == false)
								chkWindow1.Checked = true;
							else if (receivedValue == 0 && chkWindow1.Checked == true)
								chkWindow1.Checked = false;
							break;
						case 'F':
							if (receivedValue == 1 && chkAC.Checked == false)
								chkAC.Checked = true;
							else if (receivedValue == 0 && chkAC.Checked == true)
								chkAC.Checked = false;
							break;
						case 'P':
							if (receivedValue == 1 && chkProjector.Checked == false)
								chkProjector.Checked = true;
							else if (receivedValue == 0 && chkProjector.Checked == true)
								chkProjector.Checked = false;
							break;
					}

					if (sensors.thereIsFire())
					{
						lblSmoke.ForeColor = Color.Red;
						lblTemp.ForeColor = Color.Red;
						fireAlarm.play();
					}
					else
					{
						lblSmoke.ForeColor = Color.Green;
						lblTemp.ForeColor = Color.Green;
						fireAlarm.stop();
					}
				}
				catch (IndexOutOfRangeException error) { println(error.Message); }
				catch (ArgumentOutOfRangeException error) { println(error.Message); }
			}
		}

		//Lighta
		private void chkLED1_CheckedChanged(object sender, EventArgs e)
		{
			if (chkLED1.Checked == true)
			{
				zigbee.sendCommand("0");
				picLED1.Image = FreeU.Properties.Resources.led_ON;
			}
			else if (chkLED1.Checked == false)
			{
				zigbee.sendCommand("1");
				picLED1.Image = FreeU.Properties.Resources.led_OFF;
			}
		}
		private void picLED1_Click(object sender, EventArgs e)
		{
			chkLED1.Checked = !chkLED1.Checked;
		}
		private void chkLED2_CheckedChanged(object sender, EventArgs e)
		{
			if (chkLED2.Checked == true)
			{
				zigbee.sendCommand("2");
				picLED2.Image = FreeU.Properties.Resources.led_ON;
			}
			else if (chkLED2.Checked == false)
			{
				zigbee.sendCommand("3");
				picLED2.Image = FreeU.Properties.Resources.led_OFF;
			}
		}
		private void picLED2_Click(object sender, EventArgs e)
		{
			chkLED2.Checked = !chkLED2.Checked;
		}
		///////////////////////////////////////////////////////

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			zigbee.closePort();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			zigbee.sendCommand(txtSerialMessage.Text + "\n");
			wifi.send(txtSerialMessage.Text);
			//zigbee.receivedDataQueue.Enqueue(txtSerialMessage.Text);
			txtSerialMessage.Text = "";
		}

		//Menu
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{ Close(); }

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{ Show(); }

		private void hideToolStripMenuItem_Click(object sender, EventArgs e)
		{ Hide(); }
		///////////////////////////////////////////////////////

		int acTemp;
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			trackBar1.Value = (int)numericUpDown1.Value;
			if (numericUpDown1.Value < acTemp)
			{
				zigbee.sendCommand("h");
				acTemp = (int)numericUpDown1.Value;
			}
			else if (numericUpDown1.Value > acTemp)
			{
				zigbee.sendCommand("g");
				acTemp = (int)numericUpDown1.Value;
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			numericUpDown1.Value = trackBar1.Value;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{ MessageBox.Show("FreeU\nBy:\n\n\n\n\n\n\n\n\n\n"); }

		private void portToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			//for (int i=0;i< portToolStripMenuItem.DropDownItems.Count-2;i++)
			//{
			//((ToolStripMenuItem)portToolStripMenuItem.DropDownItems[i]).Checked = false;
			//}
			//ToolStripMenuItem v = ((ToolStripMenuItem)sender);
			//(portToolStripMenuItem.DropDownItems[0]).Checked = true;
			// CheckOnClick = true;

			//e.ClickedItem.Select();
			//portToolStripMenuItem.DropDownItems[0].Select();
			if (e.ClickedItem.ToString().Equals("Update"))
			{
				portToolStripMenuItem.Text = "Port";
				putCOMSIntoMenu();
			}
			else
			{
				try
				{
					zigbee.setupPort(e.ClickedItem.ToString(), Serial.BAUD_RATE);
				}
				catch (Exception err)
				{
					println(err.Message);

				}
			}

		}

		private void chkAC_CheckedChanged(object sender, EventArgs e)
		{
			if (chkAC.Checked == true)
				zigbee.sendCommand("7");
			else if (chkAC.Checked == false)
				zigbee.sendCommand("8");
			trackBar1.Enabled = chkAC.Checked;
			numericUpDown1.Enabled = chkAC.Checked;
		}

		private void chkProjector_CheckedChanged(object sender, EventArgs e)
		{
			if (chkProjector.Checked == true)
				zigbee.sendCommand("9");
			else if (chkProjector.Checked == false)
			{
				var thread = new Thread(
	() =>
	{
		try
		{
			zigbee.sendCommand("a");
			Thread.Sleep(1000);
			zigbee.sendCommand("a");
		}
		catch (Exception err) { System.Console.WriteLine(err.Message); }
		finally
		{
		}
	});
				thread.Start();

			}
			btnZoomIn.Enabled = chkProjector.Checked;
			btnZoomOut.Enabled = chkProjector.Checked;
		}
		private void cmbMode_SelectedIndexChanged(object sender, MouseEventArgs e)
		{

		}
		private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbMode.SelectedIndex)
			{
				case 0:
					chkAC.Checked = false;
					chkLED1.Checked = false;
					chkLED2.Checked = false;
					chkProjector.Checked = false;
					chkDoor1.Checked = false;
					chkDoor2.Checked = false;
					chkWindow1.Checked = false;
					chkWindow2.Checked = false;
					break;
				case 1:
					chkAC.Checked = true;
					chkLED1.Checked = false;
					chkLED2.Checked = false;
					chkProjector.Checked = true;
					chkDoor1.Checked = false;
					chkDoor2.Checked = false;
					chkWindow1.Checked = false;
					chkWindow2.Checked = false;
					break;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			picLED1.Image = FreeU.Properties.Resources.led_OFF;
			picLED2.Image = FreeU.Properties.Resources.led_OFF;
		}

		private void chkWindow1_CheckedChanged(object sender, EventArgs e)
		{
			if (chkWindow1.Checked == true)
				zigbee.sendCommand("4");
			else if (chkWindow1.Checked == false)
				zigbee.sendCommand("5");
		}

		private void tmrConnection_Tick(object sender, EventArgs e)
		{
			// TODO remove "false &&" 
			if (!zigbee.isConnected())
			{
				tmrConnection.Enabled = false;
				DialogResult dialogResult = MessageBox.Show("Connection lost\r\nPress OK to connect again ,or Cancel to exit", "Connection lost", MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK)
				{
					zigbee.closePort();
					Form selectForm = new Select_Port();
					selectForm.ShowDialog(this);
				}
				else if (dialogResult == DialogResult.Cancel)
				{
					Process.GetCurrentProcess().Kill();
				}
				try { zigbee.setupPort(); }
				catch (Exception err) { println(err.Message); }
				tmrConnection.Enabled = true;
			}
			else
				portToolStripMenuItem.Text = "Port (" + zigbee.getPortName() + ")";
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			putCOMSIntoMenu();
		}
		WifiConnection wifi = new WifiConnection();
		private void tmrWifi_Tick(object sender, EventArgs e)
		{
			var thread = new Thread(
				() =>
				{
					try
					{
						tmrWifi.Enabled = false;
						println(new WifiConnection().listen());
						tmrWifi.Enabled = true;
					}
					catch (Exception err) { System.Console.WriteLine(err.Message); }
				});
			thread.Start();
		}

		private void enableAndroidControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (enableAndroidControlToolStripMenuItem.Checked == true)
				zigbee.sendCommand("v");
			else
				zigbee.sendCommand("u");
		}
	}
}
