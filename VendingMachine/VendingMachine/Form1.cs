using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace VendingMachine
{
	public partial class Form1 : Form
	{
		private CoinController _coinController;
		private readonly ICommPort _comPort;
		private decimal _Coins;

		public Form1()
		{
			InitializeComponent();
			ShowCoins();

            _comPort = new CommPort("COM1");
			_coinController = new CoinController(_comPort, new KeyValuePair<int, decimal>(1, 2));
			_coinController.CoinReceived += CoinController_CoinReceived;
        }

		private void CoinController_CoinReceived(object sender, CoinReceivedEventHandlerArgs args)
		{
			_Coins += args.Coin;
			ShowCoins();
		}

		private void ShowCoins()
		{
			labelCoins.Text = _Coins.ToString(CultureInfo.InvariantCulture);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_comPort.Dispose();
		}
	}
}
