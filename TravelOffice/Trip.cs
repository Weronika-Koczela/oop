using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	class Trip
	{
		private Date start;
		private Date end;
		private string destination;
		public Trip(Date start, Date end, string destination)
		{
			this.start = start;
			this.end = end;
			this.destination = destination;
			
		}
		public string GetInfo()
		{
			return ToString();

		}
		public override string ToString()
		{
			return "Wycieczka do : " + destination + "\n wylot " + start + "\n powrót " + end;
		}
	}
}
