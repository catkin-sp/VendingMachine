using System;

namespace MoneyController.Interfaces
{
	public interface ICommPort : IDisposable
	{
		event SerialPortBlockReceivedEventHandler BlockReceived;
		event SerialPortStatusChangedEventHandler PortStatusChanged;

		void Send(string command);
		void Open(string port);
		void Close();
		bool IsOpen();
	}
}