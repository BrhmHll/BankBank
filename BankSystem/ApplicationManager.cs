using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class ApplicationManager
	{
		public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
		{
			// Başvuru bilgilerini değerlendir
			//

			creditManager.Calculate();
			foreach (var loggerService in loggerServices)
			{
				loggerService.Log();
			}


		}

		public void CreditInformation(List<ICreditManager> credits)
		{
			foreach (var credit in credits)
			{
				credit.Calculate();
			}
		}
	}
}
