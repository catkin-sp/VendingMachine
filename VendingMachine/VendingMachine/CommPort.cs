using System;
using System.IO.Ports;

namespace VendingMachine
{
	public class CommPort : IDisposable, ICommPort
	{
		private readonly SerialPort _serialPort;

		public event SerialPortBlockReceivedEventHandler BlockReceived;

		public CommPort(string portName)
		{
			_serialPort = new SerialPort(portName);
			_serialPort.Open();
			_serialPort.DataReceived += serialPort_DataReceived;
		}

		void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
		{
			BlockReceived?.Invoke(this, new SerialPortBlockReceivedEventHandlerArgs
			{
				DataBlock = _serialPort.ReadLine()
			});
		}

		public void Dispose()
		{
			_serialPort.Close();
			_serialPort.Dispose();
		}
	}

	public class SerialPortBlockReceivedEventHandlerArgs
	{
		public string DataBlock { get; set; }
	}
}
