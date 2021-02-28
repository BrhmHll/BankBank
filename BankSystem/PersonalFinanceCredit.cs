using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class PersonalFinanceCredit : ICreditManager
	{
		public void Calculate()
		{
			Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
		}

		public void MakeAny()
		{
			throw new NotImplementedException();
		}
	}
}
