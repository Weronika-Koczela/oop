using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	class CustomersList
	{
		List<Customer> customers = new List<Customer>();
		int _numberOfCustomers;
		public int NumberOfCustomers { get => _numberOfCustomers; set => _numberOfCustomers = value; }
		public void AddCustomer()
		{
			
			for (int i = 0; i <= _numberOfCustomers-1; i++)
			{
				int no = i + 1;
				Console.WriteLine("Podaj imie i nazwisko klienta: "  + no );
				string imie = Console.ReadLine();
				Customer customer = new Customer(imie);
				customers.Add(customer);
			}
		}
		public int HowMuchCustomers()
		{
			return customers.Count();
		}
		public void ViewAllCustomers()
		{
			int no = 0;
			foreach (var customer in customers)
			{
				no++;
				Console.WriteLine(no + " " + customer.CustomerName());
			}
		}
	
	}
}
