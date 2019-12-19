using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes  
{
	class Triangle:Shape
	{
		private string _name;
		private double _side;
		private double _height;
		public Triangle(double height, double side)
		{
			_name = "trójkąt";
			_side = side;
			_height = height;
		}
		public override string Name
		{  
			get => _name;
			set => _name = value;
		}
		public double Side { get => _side; set => _side = value; }
		public double Height { get => _height; set => _height = value; }

	

		public override double Area()
		{
			return 0.5 *(_side * _height);
		}

		public override double Perimeter()
		{
			return 3 * _side;
		}
		public override string ToString()
		{
			return $"{_name} Pole : {Area()} Obwód {Perimeter()}";
		}
	}
}
