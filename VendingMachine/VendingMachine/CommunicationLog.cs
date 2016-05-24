using MoneyController.Interfaces;

namespace VendingMachine
{
	internal class CommunicationLog : ICommunicaitonLog
	{
		private readonly VendingMachineMainForm _vendingMachineMainForm;

		public CommunicationLog(VendingMachineMainForm vendingMachineMainForm)
		{
			_vendingMachineMainForm = vendingMachineMainForm;
		}

		public void Info(string message)
		{
			_vendingMachineMainForm.AddInfo(message);
		}
	}
}