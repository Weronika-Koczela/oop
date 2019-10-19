using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	class Address
	{
		private string city;
		private string zip;
		private string street;
		
	
		public Address(string city, string zip, string street )
		{
			this.city = city;
			this.street = street;
			this.zip = zip;
		}
		public string getInfo()
		{

			return "Address" + street + "\n " + zip + " " + city;

		}
	}
}
