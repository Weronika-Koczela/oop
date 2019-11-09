
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	enum Menu {WyswietlLiczbeKlinetnow = 1, WyswietlWszystkichKlientow, wyjscie}
	class TravelOffice
	{
		private static void Loop()
		{
			bool wyjscie = true;
			CustomersList customers = new CustomersList();
			Console.WriteLine("Podaj ile kontaktow chcesz dodac");
			int odp;
			int.TryParse(Console.ReadLine(), out odp);
			customers.NumberOfCustomers = odp;
			customers.AddCustomer();
			Menu menu;
			while (wyjscie)
			{
				Console.WriteLine("Wybierz opcje:\n 1. Wyswietl liczbe klientow \n 2. Wyswietl wszystkich klientow \n 3. Wyjscie");
				bool opcja = Enum.TryParse<Menu>(Console.ReadLine(), out menu);
				switch (menu)
				{
					case Menu.WyswietlLiczbeKlinetnow:
						customers.HowMuchCustomers();
						break;
					case Menu.WyswietlWszystkichKlientow:
						customers.ViewAllCustomers();
						break;
					case Menu.wyjscie:
						wyjscie = false;
						break;
					default:
						Console.WriteLine("Wybrano złą opcję, spróbuj ponownie " );
						break;
				}
			}
		}
		static void Main(string[] args)
		{
			//Date start = new Date(2019, 11, 16);
			//Date end = new Date(2019, 11, 26);
			//Trip trip = new Trip(start,end,"Paryż");
			//Address address = new Address("Paryż", "58944", "Rue de Livre");

			//Customer customer = new Customer("Anna Nowak");
			//customer.Address = address;
			//customer.Trip = trip;
			//Console.WriteLine(customer.getInfo());
			Loop();


		
			

		}
	}
}
