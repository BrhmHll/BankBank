using System;
using System.Collections.Generic;
using System.Text;

namespace BankBank
{
	// Tüzel Müşteri
	class CorporateCustomer : Customer
	{
		public string CompanyName { get; set; }
		public string TaxNo { get; set; }

	}
}
