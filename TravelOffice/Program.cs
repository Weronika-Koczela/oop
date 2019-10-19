
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	class TravelOffice
	{
		static void Main(string[] args)
		{
			Date start = new Date(2019, 11, 16);
			Date end = new Date(2019, 11, 26);
			Trip trip = new Trip(start,end,"Paryż");
			Address address = new Address("Paryż", "58944", "Rue de Livre");

			Customer customer = new Customer("Anna Nowak");
			customer.Address = address;
			customer.Trip = trip;
			Console.WriteLine(customer.getInfo());


		}
	}
}
