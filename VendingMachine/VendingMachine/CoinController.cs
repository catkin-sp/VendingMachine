using System.Collections.Generic;

namespace VendingMachine
{
	public class CoinController
	{
		private readonly ICommPort _port;
		private KeyValuePair<int, decimal> _coinChannelMapping;
		public event CoinReceivedEventHandler CoinReceived;

		public CoinController(ICommPort port, KeyValuePair<int, decimal> coinChannelMapping)
		{
			_port = port;
			_coinChannelMapping = coinChannelMapping;
			_port.BlockReceived += PortOnBlockReceived;
		}

		private void PortOnBlockReceived(object sender, SerialPortBlockReceivedEventHandlerArgs args)
		{
			CoinReceived?.Invoke(this, new CoinReceivedEventHandlerArgs{Coin = 10});
		}
	}
}
