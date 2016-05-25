using System.IO.Ports;
using System.Timers;
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
		
		Timer aTimer = new Timer();

		public void Open(string port)
		{
			if (_serialPort.IsOpen)
			{
				_serialPort.Close();
			}
		
			_serialPort.PortName = port;
			_serialPort.Open();

			//
			aTimer.Elapsed += OnTimedEvent;
			aTimer.Interval = 1000;
			aTimer.Enabled = true;
		}

		private void OnTimedEvent(object sender, ElapsedEventArgs e)
		{
			//aTimer.Enabled = false;
			OnBlockReceived("<00>\n");
		}

		public void Close()
		{
			_serialPort.Close();
        }

		public bool IsOpen()
		{
			return _serialPort.IsOpen;
		}

		public CommPort(ICommunicaitonLog log)
		{
			_serialPort = new SerialPort { BaudRate = 19200 };
			_log = log;
			_serialPort.DataReceived += serialPort_DataReceived;
		}

		void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
		{
			var block = _serialPort.ReadLine();
			OnBlockReceived(block);
		}

		private void OnBlockReceived(string block)
		{
			_log.Info($"Received: {block}");

			BlockReceived?.Invoke(this, new SerialPortBlockReceivedEventHandlerArgs
			{
				DataBlock = block
			});
		}

		public void Dispose()
		{
			_serialPort.Close();
			_serialPort.Dispose();
		}
	}
}
