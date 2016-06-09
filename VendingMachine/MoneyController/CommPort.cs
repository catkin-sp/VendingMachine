using System;
using System.IO.Ports;
using System.Timers;
using MoneyController.Interfaces;

namespace MoneyController
{
	public class CommPort : ICommPort
	{
		private readonly ICommunicaitonLog _log;
		private readonly SerialPort _serialPort;
		private readonly Timer _timer = new Timer();

		private DateTime _lastReceivedBlockTime = DateTime.MinValue;
		private bool _online;

		public event SerialPortBlockReceivedEventHandler BlockReceived;
		public event SerialPortStatusChangedEventHandler PortStatusChanged;

		public CommPort(ICommunicaitonLog log)
		{
			_serialPort = new SerialPort { BaudRate = 19200 };
			_log = log;
			_serialPort.DataReceived += serialPort_DataReceived;
		}

		public void Send(string command)
		{
			if (!_serialPort.IsOpen)
			{
				return;
			}

			_serialPort.WriteLine(command);
			_log.Info($"Sent: {command}");
		}

		public void Open(string port)
		{
			if (_serialPort.IsOpen)
			{
				_serialPort.Close();
			}
		
			_serialPort.PortName = port;
			_serialPort.Open();

			_lastReceivedBlockTime = DateTime.MinValue;
			_online = true;

            _timer.Elapsed += OnTimedEvent;
			_timer.Interval = 1000;
			_timer.Enabled = true;
		}

		private void OnTimedEvent(object sender, ElapsedEventArgs e)
		{
			if ((_online || !IsOnline()) && (!_online || IsOnline())) return;
			
			_online = IsOnline();

			PortStatusChanged?.Invoke(this, new SerialPortStatusChangedEventHandlerArgs
			{
				Online = _online
			});
		}

		public void Close()
		{
			_serialPort.Close();
        }

		public bool IsOpen()
		{
			return _serialPort.IsOpen;
		}

		private bool IsOnline()
		{
			return (DateTime.Now - _lastReceivedBlockTime).TotalSeconds < 5;
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

			_lastReceivedBlockTime = DateTime.Now;
		}

		public void Dispose()
		{
			if (_serialPort.IsOpen)
			{
				_serialPort.Close();
			}
			
			_serialPort.Dispose();
		}
	}
}
