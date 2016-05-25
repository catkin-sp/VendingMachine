﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;
using MoneyController;
using MoneyController.Interfaces;

namespace VendingMachine
{
	public partial class VendingMachineMainForm : Form
	{
		private readonly MoneyController.MoneyController _moneyController;
		private readonly ICommPort _comPort;
		private decimal _coins;

		public VendingMachineMainForm()
		{
			InitializeComponent();
			ShowCoins();

			var log = new CommunicationLog();
			log.MessageReceived += Log_MessageReceived;
            _comPort = new CommPort(log);
			_moneyController = new MoneyController.MoneyController(_comPort, GetChannelMapping());
			_moneyController.MoneyReceived += MoneyControllerMoneyReceived;
        }

		private void Log_MessageReceived(object sender, InfoMessageReceivedHandlerArgs args)
		{
			//AddInfo(args.Info);
			Console.WriteLine(args.Info);
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
			ShowCoins();
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
			listBoxReceived.Items.Insert(0, message);

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
			comboBoxPorts.SelectedIndex = 0;
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
	}
}
