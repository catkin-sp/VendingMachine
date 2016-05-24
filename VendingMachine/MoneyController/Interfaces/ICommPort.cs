using System;

namespace MoneyController.Interfaces
{
	public interface ICommPort : IDisposable
	{
		event SerialPortBlockReceivedEventHandler BlockReceived;
		void Send(string command);
	}
}