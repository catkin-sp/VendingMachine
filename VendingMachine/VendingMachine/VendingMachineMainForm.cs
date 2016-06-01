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
	public partial class VendingMachineMainForm : Form, ICommunicaitonLog
	{
		private readonly MoneyController.MoneyController _moneyController;
		private readonly ICommPort _comPort;
		private decimal _coins;
		private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public VendingMachineMainForm()
		{
			InitializeComponent();
			ShowCoins();

			XmlConfigurator.Configure();

			_comPort = new CommPort(this);
			_comPort.PortStatusChanged += ComPortPortStatusChanged;
			
			_moneyController = new MoneyController.MoneyController(_comPort, GetChannelMapping());
			_moneyController.MoneyReceived += MoneyControllerMoneyReceived;
        }

		private void ComPortPortStatusChanged(object sender, SerialPortStatusChangedEventHandlerArgs args)
		{
			Action action = () => ShowOnlineStatus(args.Online);
			BeginInvoke(action);
		}

		private static Dictionary<int, decimal> GetChannelMapping()
		{
			return new Dictionary<int, decimal>()
			{
				{ 1, 2 },		// 1 channel 2.00 EUR
				{ 2, 1 },		// 2 channel 1.00 EUR
				{ 3, 0.5m },	// 3 channel 0.50 EUR
				{ 4, 0.2m },	// 4 channel 0.20 EUR
				{ 5, 0.1m },	// 5 channel 0.10 EUR
				{ 6, 0.05m },	// 6 channel 0.05 EUR
			};
		}

		private void MoneyControllerMoneyReceived(object sender, MoneyReceivedEventHandlerArgs args)
		{
			_coins += args.Value;
			BeginInvoke((Action)ShowCoins);
		}

		private void ShowCoins()
		{
			labelCoins.Text = _coins.ToString(CultureInfo.InvariantCulture);
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

		private void checkBoxAcceptMoney_CheckedChanged(object sender, System.EventArgs e)
		{
			_moneyController.Enabled = checkBoxAcceptMoney.Checked;
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
			labelConnectionState.Text = string.Empty;
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
			labelConnectionState.Text = string.Empty;
			_comPort.Close();
			EnablePortControls();
		}

		private void ShowOnlineStatus(bool online)
		{
			labelConnectionState.Text = online ? "Online" : "Disconnected";
			labelConnectionState.ForeColor = online ? Color.Green : Color.Red;
		}

		public void Info(string message)
		{
			Logger.Info(message);

			Action action = () => AddInfo(message);
			BeginInvoke(action);
		}
	}
}
