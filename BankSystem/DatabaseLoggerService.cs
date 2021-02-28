using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class DatabaseLoggerService : ILoggerService
	{
		public DatabaseLoggerService()
		{
		}

		public void Log()
		{
			Console.WriteLine("Veritabanı kaydı tamamlandı.");
		}
	}
}
