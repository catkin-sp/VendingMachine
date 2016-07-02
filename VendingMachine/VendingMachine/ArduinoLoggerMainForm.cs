using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using MoneyController;
using MoneyController.Interfaces;

namespace VendingMachine
{
	public partial class ArduinoLoggerMainForm : Form, ICommunicaitonLog
	{
		private readonly ICommPort _comPort;
		private decimal _coins;
		private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public ArduinoLoggerMainForm()
		{
			InitializeComponent();

			XmlConfigurator.Configure();

			_comPort = new CommPort(this);
        }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_comPort.Dispose();
		}

		public void AddInfo(string message)
		{
			listBoxReceived.Items.Insert(0, $"{DateTime.Now.ToLongTimeString()} {message}");

			if (listBoxReceived.Items.Count > 100)
			{
				listBoxReceived.Items.RemoveAt(100);
			}
		}

		private void VendingMachineMainForm_Load(object sender, System.EventArgs e)
		{
			comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());

			if (comboBoxPorts.Items.Count > 0)
			{
				comboBoxPorts.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("No COM ports found on this PC.");
				buttonStart.Enabled =  buttonStop.Enabled = comboBoxPorts.Enabled = false;
			}
		}

		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			_comPort.Open(comboBoxPorts.Text);
			EnablePortControls();
		}

		private void EnablePortControls()
		{
			buttonStart.Enabled = !_comPort.IsOpen();
			buttonStop.Enabled = _comPort.IsOpen();
			comboBoxPorts.Enabled = !_comPort.IsOpen();
		}

		private void buttonStop_Click(object sender, System.EventArgs e)
		{
			_comPort.Close();
			EnablePortControls();
		}

		public void Info(string message)
		{
			Logger.Info(message);

			Action action = () => AddInfo(message);
			BeginInvoke(action);
		}
	}
}
