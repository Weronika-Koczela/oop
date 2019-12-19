using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
	public abstract class Shape : IComparable<Shape>
	{
		private  string _name;
		public virtual string Name { get => _name;  set => _name = "shape"; }
		public abstract double Area();

		public int CompareTo(Shape other)
		{
			int result = Area().CompareTo(other.Area());
			return result;
		}

		public abstract double Perimeter();
		public override string ToString()
		{
			return $"{Name} Pole : {Area()} Obwód {Perimeter()}";
		}
	}
	class SortByPerimeter : IComparer<Shape>
	{
		public int Compare(Shape x, Shape y)
		{
			if (x.Perimeter().CompareTo(y.Perimeter()) == 0)
				return 0;
			else if (x.Perimeter().CompareTo(y.Perimeter()) < 0)
				return -1;
			else
				return 1;
		}

	}
}
