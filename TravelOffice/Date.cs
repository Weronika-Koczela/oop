using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOffice
{
	class Date
	{
		private int year;
		private int month;
		private int day;
		public Date(int year, int month, int day)
		{
			this.year = year;
			this.month = month;
			this.day = day;


		}
		public string GetInfo()
		{
			return ToString();
		}
		public override string ToString()
		{
			return year + " " + month + " " + day;
		}
	}
}
