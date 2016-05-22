using System;

namespace VendingMachine
{
	public interface ICommPort : IDisposable
	{
		event SerialPortBlockReceivedEventHandler BlockReceived;
	}
}