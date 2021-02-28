using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class SmsLoggerService : ILoggerService
	{
		public void Log()
		{
			Console.WriteLine("Sms yollandı.");
		}
	}
}
