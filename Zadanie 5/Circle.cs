using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
	class Circle :Shape
	{
		public Circle(double radius)
		{
			_name = "koło";

			_radius = radius;
		}
		private string _name;
		private double _radius;

		public override string Name { get => _name;  set => _name = "Koło"; }
		public double Radius { get => _radius; set => _radius = value; }

		public override double Area()
		{
			return Math.PI * _radius * _radius;
		}

		public override double Perimeter()
		{
			return 2 * (Math.PI * _radius);
		}
		public override string ToString()
		{
			return $"{_name} Pole : {Area()} Obwód {Perimeter()}";
		}
	}
}
