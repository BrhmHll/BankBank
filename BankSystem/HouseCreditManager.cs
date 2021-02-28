using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class HouseCreditManager : ICreditManager
	{
		public void Calculate()
		{
			Console.WriteLine("Ev kredisi ödeme planı hesaplandı.");
		}

		public void MakeAny()
		{
			throw new NotImplementedException();
		}
	}
}
