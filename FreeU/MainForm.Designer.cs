namespace FreeU
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chkLED1 = new System.Windows.Forms.CheckBox();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblEnergy = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPower = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblSmoke = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblHumidity = new System.Windows.Forms.Label();
			this.lblTemp = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbMode = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnZoomOut = new System.Windows.Forms.Button();
			this.btnZoomIn = new System.Windows.Forms.Button();
			this.chkProjector = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkWindow1 = new System.Windows.Forms.CheckBox();
			this.chkWindow2 = new System.Windows.Forms.CheckBox();
			this.chkDoor2 = new System.Windows.Forms.CheckBox();
			this.chkDoor1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.chkAC = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.picLED2 = new System.Windows.Forms.PictureBox();
			this.picLED1 = new System.Windows.Forms.PictureBox();
			this.chkLED2 = new System.Windows.Forms.CheckBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSerialMessage = new System.Windows.Forms.TextBox();
			this.txtSerial = new System.Windows.Forms.TextBox();
			this.btnSerialSend = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enableAndroidControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.tmrConnection = new System.Windows.Forms.Timer(this.components);
			this.tmrWifi = new System.Windows.Forms.Timer(this.components);
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLED2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLED1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chkLED1
			// 
			resources.ApplyResources(this.chkLED1, "chkLED1");
			this.chkLED1.Name = "chkLED1";
			this.chkLED1.UseVisualStyleBackColor = true;
			this.chkLED1.CheckedChanged += new System.EventHandler(this.chkLED1_CheckedChanged);
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage2);
			this.tabControl2.Controls.Add(this.tabPage1);
			resources.ApplyResources(this.tabControl2, "tabControl2");
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.TabStop = false;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Transparent;
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.cmbMode);
			this.tabPage3.Controls.Add(this.groupBox4);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Controls.Add(this.groupBox1);
			resources.ApplyResources(this.tabPage3, "tabPage3");
			this.tabPage3.Name = "tabPage3";
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.lblEnergy);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Controls.Add(this.lblPower);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.lblSmoke);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.lblHumidity);
			this.groupBox5.Controls.Add(this.lblTemp);
			resources.ApplyResources(this.groupBox5, "groupBox5");
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.TabStop = false;
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// lblEnergy
			// 
			resources.ApplyResources(this.lblEnergy, "lblEnergy");
			this.lblEnergy.Name = "lblEnergy";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// lblPower
			// 
			resources.ApplyResources(this.lblPower, "lblPower");
			this.lblPower.Name = "lblPower";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// lblSmoke
			// 
			resources.ApplyResources(this.lblSmoke, "lblSmoke");
			this.lblSmoke.Name = "lblSmoke";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// lblHumidity
			// 
			resources.ApplyResources(this.lblHumidity, "lblHumidity");
			this.lblHumidity.Name = "lblHumidity";
			// 
			// lblTemp
			// 
			resources.ApplyResources(this.lblTemp, "lblTemp");
			this.lblTemp.Name = "lblTemp";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// cmbMode
			// 
			this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMode.FormattingEnabled = true;
			this.cmbMode.Items.AddRange(new object[] {
            resources.GetString("cmbMode.Items"),
            resources.GetString("cmbMode.Items1")});
			resources.ApplyResources(this.cmbMode, "cmbMode");
			this.cmbMode.Name = "cmbMode";
			this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.btnZoomOut);
			this.groupBox4.Controls.Add(this.btnZoomIn);
			this.groupBox4.Controls.Add(this.chkProjector);
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// btnZoomOut
			// 
			resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
			this.btnZoomOut.Name = "btnZoomOut";
			this.btnZoomOut.UseVisualStyleBackColor = true;
			// 
			// btnZoomIn
			// 
			resources.ApplyResources(this.btnZoomIn, "btnZoomIn");
			this.btnZoomIn.Name = "btnZoomIn";
			this.btnZoomIn.UseVisualStyleBackColor = true;
			// 
			// chkProjector
			// 
			resources.ApplyResources(this.chkProjector, "chkProjector");
			this.chkProjector.Name = "chkProjector";
			this.chkProjector.UseVisualStyleBackColor = true;
			this.chkProjector.CheckedChanged += new System.EventHandler(this.chkProjector_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.chkWindow1);
			this.groupBox3.Controls.Add(this.chkWindow2);
			this.groupBox3.Controls.Add(this.chkDoor2);
			this.groupBox3.Controls.Add(this.chkDoor1);
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// chkWindow1
			// 
			resources.ApplyResources(this.chkWindow1, "chkWindow1");
			this.chkWindow1.Name = "chkWindow1";
			this.chkWindow1.UseVisualStyleBackColor = true;
			this.chkWindow1.CheckedChanged += new System.EventHandler(this.chkWindow1_CheckedChanged);
			// 
			// chkWindow2
			// 
			resources.ApplyResources(this.chkWindow2, "chkWindow2");
			this.chkWindow2.Name = "chkWindow2";
			this.chkWindow2.UseVisualStyleBackColor = true;
			// 
			// chkDoor2
			// 
			resources.ApplyResources(this.chkDoor2, "chkDoor2");
			this.chkDoor2.Name = "chkDoor2";
			this.chkDoor2.UseVisualStyleBackColor = true;
			// 
			// chkDoor1
			// 
			resources.ApplyResources(this.chkDoor1, "chkDoor1");
			this.chkDoor1.Name = "chkDoor1";
			this.chkDoor1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.trackBar1);
			this.groupBox2.Controls.Add(this.chkAC);
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// numericUpDown1
			// 
			resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
			this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ReadOnly = true;
			this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
			resources.ApplyResources(this.trackBar1, "trackBar1");
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Maximum = 32;
			this.trackBar1.Minimum = 18;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Value = 25;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// chkAC
			// 
			resources.ApplyResources(this.chkAC, "chkAC");
			this.chkAC.Name = "chkAC";
			this.chkAC.UseVisualStyleBackColor = true;
			this.chkAC.CheckedChanged += new System.EventHandler(this.chkAC_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.picLED2);
			this.groupBox1.Controls.Add(this.chkLED1);
			this.groupBox1.Controls.Add(this.picLED1);
			this.groupBox1.Controls.Add(this.chkLED2);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// picLED2
			// 
			resources.ApplyResources(this.picLED2, "picLED2");
			this.picLED2.Name = "picLED2";
			this.picLED2.TabStop = false;
			this.picLED2.Click += new System.EventHandler(this.picLED2_Click);
			// 
			// picLED1
			// 
			resources.ApplyResources(this.picLED1, "picLED1");
			this.picLED1.Name = "picLED1";
			this.picLED1.TabStop = false;
			this.picLED1.Click += new System.EventHandler(this.picLED1_Click);
			// 
			// chkLED2
			// 
			resources.ApplyResources(this.chkLED2, "chkLED2");
			this.chkLED2.Name = "chkLED2";
			this.chkLED2.UseVisualStyleBackColor = true;
			this.chkLED2.CheckedChanged += new System.EventHandler(this.chkLED2_CheckedChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.label16);
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			// 
			// label16
			// 
			resources.ApplyResources(this.label16, "label16");
			this.label16.Name = "label16";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtSerialMessage);
			this.panel1.Controls.Add(this.txtSerial);
			this.panel1.Controls.Add(this.btnSerialSend);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// txtSerialMessage
			// 
			resources.ApplyResources(this.txtSerialMessage, "txtSerialMessage");
			this.txtSerialMessage.Name = "txtSerialMessage";
			// 
			// txtSerial
			// 
			resources.ApplyResources(this.txtSerial, "txtSerial");
			this.txtSerial.Name = "txtSerial";
			this.txtSerial.ReadOnly = true;
			// 
			// btnSerialSend
			// 
			resources.ApplyResources(this.btnSerialSend, "btnSerialSend");
			this.btnSerialSend.Name = "btnSerialSend";
			this.btnSerialSend.UseVisualStyleBackColor = true;
			this.btnSerialSend.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// hideToolStripMenuItem
			// 
			this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
			resources.ApplyResources(this.hideToolStripMenuItem, "hideToolStripMenuItem");
			this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.enableAndroidControlToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// portToolStripMenuItem
			// 
			this.portToolStripMenuItem.Name = "portToolStripMenuItem";
			resources.ApplyResources(this.portToolStripMenuItem, "portToolStripMenuItem");
			this.portToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.portToolStripMenuItem_DropDownItemClicked);
			// 
			// enableAndroidControlToolStripMenuItem
			// 
			this.enableAndroidControlToolStripMenuItem.Checked = true;
			this.enableAndroidControlToolStripMenuItem.CheckOnClick = true;
			this.enableAndroidControlToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableAndroidControlToolStripMenuItem.Name = "enableAndroidControlToolStripMenuItem";
			resources.ApplyResources(this.enableAndroidControlToolStripMenuItem, "enableAndroidControlToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// notifyIcon1
			// 
			resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// tmrConnection
			// 
			this.tmrConnection.Enabled = true;
			this.tmrConnection.Tick += new System.EventHandler(this.tmrConnection_Tick);
			// 
			// tmrWifi
			// 
			this.tmrWifi.Enabled = true;
			this.tmrWifi.Interval = 1000;
			this.tmrWifi.Tick += new System.EventHandler(this.tmrWifi_Tick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnSerialSend;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLED2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLED1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox chkLED1;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.CheckBox chkLED2;
		public System.Windows.Forms.TextBox txtSerial;
		public System.Windows.Forms.TextBox txtSerialMessage;
		private System.Windows.Forms.Button btnSerialSend;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkAC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.CheckBox chkWindow1;
		private System.Windows.Forms.CheckBox chkWindow2;
		private System.Windows.Forms.CheckBox chkDoor2;
		private System.Windows.Forms.CheckBox chkDoor1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enableAndroidControlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnZoomOut;
		private System.Windows.Forms.Button btnZoomIn;
		private System.Windows.Forms.CheckBox chkProjector;
		private System.Windows.Forms.ComboBox cmbMode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox picLED1;
		private System.Windows.Forms.PictureBox picLED2;
		private System.Windows.Forms.Timer tmrConnection;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblEnergy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPower;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSmoke;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblHumidity;
		private System.Windows.Forms.Label lblTemp;
		private System.Windows.Forms.Timer tmrWifi;
	}
}

