using System;

namespace BankBank
{
	class Program
	{
		static void Main(string[] args)
		{
			IndividualCustomer customer1 = new IndividualCustomer();
			customer1.CustomerNo = "12345";
			customer1.Name = "Engin";
			customer1.Surname = "Demiroğ";
			customer1.TcNo = "22222222222";
			customer1.Id = 1;


			CorporateCustomer customer2 = new CorporateCustomer();
			customer2.Id = 2;
			customer2.CustomerNo = "54321";
			customer2.CompanyName = "Piton";
			customer2.TaxNo = "1234567890";

			Customer customer3 = new IndividualCustomer();
			Customer customer4 = new CorporateCustomer();

			Console.ReadKey();
		}
	}
}
