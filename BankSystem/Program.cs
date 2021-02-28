using System;
using System.Collections.Generic;

namespace BankSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
			ICreditManager vehicleCreditManager = new VehicleCreditManager();
			ICreditManager houseCreditManager = new HouseCreditManager();

			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();
			ILoggerService smsLoggerService = new SmsLoggerService();

			List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };


			ApplicationManager applicationManager = new ApplicationManager();
			applicationManager.MakeApplication(personalFinanceCredit, loggers);

			List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit, vehicleCreditManager };

			//applicationManager.CreditInformation(credits);

			Console.ReadKey();
		}
	}
}
