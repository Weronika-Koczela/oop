using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	class Customer
	{
		private string name;
		private Address address;
		private Trip trip;

		public Customer(string name )
		{
			this.name = name;
		}
		public Address Address
		{
			get => address;
			set => address = value;
		}
		public Trip Trip
		{	get => trip;
			set => trip = value;
		}
		
	public string getInfo()
		{

			return "Imie i nazwisko " + name + "\n Adres " + address.getInfo() + "/n wycieczka " + trip.GetInfo(); 
		}
		public string CustomerName()

		{
			return name;	

		}
		public override string ToString()
		{
			return name;
		}
	}
}
