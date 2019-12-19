using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
	class Quadrat :Shape
	{
		private string _name;
		private double _side;
		public Quadrat(double side)
		{
			_name = "kwadrat";
			_side = side;
		}
		public override string Name { get => _name;  set => _name ="kwadrat"; }
		public double Side { get => _side; set => _side = value; }

		public override double Area()
		{
			return Math.Sqrt(_side);
		}

		public override double Perimeter()
		{
			return 4 * _side;
			}
		
	}
}
