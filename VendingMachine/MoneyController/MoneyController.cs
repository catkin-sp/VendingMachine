using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MoneyController.Interfaces;

namespace MoneyController
{
	public class MoneyController
	{
		private readonly ICommPort _port;
		private readonly Dictionary<int, decimal> _moneyChannelMapping;
		public event MoneyReceivedEventHandler MoneyReceived;
		private string _dataBuffer;

		public bool Enabled { get; set; }

		public MoneyController(ICommPort port, Dictionary<int, decimal> moneyChannelMapping)
		{
			_port = port;
			_moneyChannelMapping = moneyChannelMapping;
			_port.BlockReceived += PortOnBlockReceived;
		}

		private void PortOnBlockReceived(object sender, SerialPortBlockReceivedEventHandlerArgs args)
		{
			_dataBuffer += args.DataBlock;
            OnBlockReceived();
		}

		private void OnBlockReceived()
		{
			var commands = Regex.Split(_dataBuffer, @"<\d\d>");

			if (commands.Any())
			{
				ProcessCommand(commands.Last());
			}

			if (_dataBuffer.Length > 100)
			{
				_dataBuffer = string.Empty;
			}
		}

		private void ProcessCommand(string command)
		{
			var commandIndex = Convert.ToInt32(command[1]);
			var channel = Convert.ToInt32(command[2]);

			if (channel != 0)
			{
				OnMoneyReceived(channel);
			}
			
			SendCommand(commandIndex);
			
			_dataBuffer = string.Empty;
		}

		private void OnMoneyReceived(int channel)
		{
			if (_moneyChannelMapping.ContainsKey(channel))
			{
				throw new ArgumentOutOfRangeException(nameof(channel), channel, "Channel to value mapping is not defined");			
			}
		
			MoneyReceived?.Invoke(this, new MoneyReceivedEventHandlerArgs { Value = _moneyChannelMapping[channel] });
		}

		private void SendCommand(int commandIndex)
		{
			_port.Send($"<{commandIndex}{(Enabled?"O":"C")}>"); // Allow/deny accept money
		}
	}
}
