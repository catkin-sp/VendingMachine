using MoneyController.Interfaces;

namespace VendingMachine
{
	internal class CommunicationLog : ICommunicaitonLog
	{
		public event InfoMessageReceivedHandler MessageReceived;

		public void Info(string message)
		{
			MessageReceived?.Invoke(this, new InfoMessageReceivedHandlerArgs
			{
				Info = message
			});
        }
	}

	internal delegate void InfoMessageReceivedHandler(object sender, InfoMessageReceivedHandlerArgs args);

	internal class InfoMessageReceivedHandlerArgs
	{
		public string Info { get; set; }
	}
}