using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	public class Silnik
	{
		private double _tankCapacity;
		private double _amountOfFuel;
		private double _fuelTankCapacity;
		public Silnik(double amoutOfFuel, double fuelTankCapacity, double tankCapacity = 50.0)
		{
			tankCapacity = _tankCapacity;
			amoutOfFuel = _amountOfFuel;
			fuelTankCapacity = _fuelTankCapacity;

		}
		public double TankCapacity
			{
			get => _tankCapacity;
			private set => _tankCapacity = 50.0;
			}
		public double AmoutOfFuel
		{
			get => _amountOfFuel;
			set => _amountOfFuel = value;
		}
		public double FuelTankCapacity
		{
			get => _fuelTankCapacity;
			set => _fuelTankCapacity = value;
		}

		public double Lp100toMPG(double lp100)
		{
			double result = (3.785 * (100 /lp100)) / 1.609;
			return result;
		}
		public double MPGtoLp100(double mpg)
		{
			double result = 100/((mpg *1.609)/ 3.785);
			return result;
		}
	}
}
