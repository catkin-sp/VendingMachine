using System.IO.Ports;
using MoneyController.Interfaces;

namespace MoneyController
{
	public class CommPort : ICommPort
	{
		private readonly ICommunicaitonLog _log;
		private readonly SerialPort _serialPort;

		public event SerialPortBlockReceivedEventHandler BlockReceived;
		
		public void Send(string command)
		{
			_serialPort.WriteLine(command);
			_log.Info($"Sent: {command}");
		}

		public CommPort(string portName, ICommunicaitonLog log)
		{
			_log = log;
			_serialPort = new SerialPort(portName) {BaudRate = 19600};
			_serialPort.Open();
			_serialPort.DataReceived += serialPort_DataReceived;
		}

		void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
		{
			var block = _serialPort.ReadLine();

			BlockReceived?.Invoke(this, new SerialPortBlockReceivedEventHandlerArgs
			{
				DataBlock = block
			});

			_log.Info($"Received: {block}");
        }

		public void Dispose()
		{
			_serialPort.Close();
			_serialPort.Dispose();
		}
	}
}
