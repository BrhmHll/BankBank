using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	class VehicleCreditManager : ICreditManager
	{
		public void Calculate()
		{
			Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
		}

		public void MakeAny()
		{
			throw new NotImplementedException();
		}
	}
}
