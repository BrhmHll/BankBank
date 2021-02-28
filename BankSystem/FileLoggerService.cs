using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class FileLoggerService : ILoggerService
	{
		public void Log()
		{
			Console.WriteLine("Dosya kaydı tamamlandı.");
		}
	}
}
