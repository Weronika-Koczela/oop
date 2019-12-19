using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
	class Rectangle : Shape
	
	{
		public Rectangle( double side1, double side2)
		{
			_name = "prostokąt";

			_side1 = side1;
			_side2 = side2;
		}
		private	string  _name;
		private double _side1;
		private double _side2;
		public override string Name { get => _name; set =>   _name = value; }
		public double Side1 { get => _side1; set => _side1 = value; }
		public double Side2 { get => _side2; set => _side2 = value; }

		public override double Area()
		{
			
			return _side1 * _side2;
		}

		public override double Perimeter()
		{
			
			return (2*_side1) + (2*_side2);
		}
		public override string ToString()
		{
			return $"{_name} Pole : {Area()} Obwód {Perimeter()}";
		}
	}
}
