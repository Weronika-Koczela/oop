using System;
using System.Collections.Generic;

namespace Shapes
{
	class Program
	{
		enum Menu {GenerateData = 1, SortArea, SortPerimeter, Search,DisplayAll, Exit =0}
		delegate bool search(Shape s);
	
		static void MyLoop()
		{
			
			Menu menu;
			bool displayMenu = false;
			
			List<Shape> shapeList = new List<Shape>();
			while (!displayMenu)
				{
				DisplayMenu();
				Enum.TryParse<Menu>(Console.ReadLine(), out menu);
			switch (menu)
			{
				case Menu.GenerateData:
					#region //List params
					Shape s1 = new Triangle(15.5, 18);
					Shape s2 = new Quadrat(4);
					Shape s3 = new Rectangle(5, 9);
					Shape s4 = new Circle(3);
					Shape s5 = new Quadrat(15);
					Shape s6 = new Triangle(5, 9);
					Shape s7 = new Rectangle(5.5,6);
					Shape s8 = new Circle(4);
					Shape s9 = new Triangle(13, 9);
					#endregion
					#region AddList
					shapeList.Add(s1);
					shapeList.Add(s2);
					shapeList.Add(s3);
					shapeList.Add(s4);
					shapeList.Add(s5);
					shapeList.Add(s6);
					shapeList.Add(s7);
					shapeList.Add(s8);
					shapeList.Add(s9);
						#endregion
						DisplayList(shapeList);
						Console.ReadKey();
						Console.Clear();
					break;
				case Menu.SortArea:
					shapeList.Sort();
						DisplayList(shapeList);
						Console.ReadKey();
						Console.Clear();
						break;
				case Menu.SortPerimeter:
					shapeList.Sort(new SortByPerimeter());
						DisplayList(shapeList);
						Console.ReadKey();
						Console.Clear();
						break;
				case Menu.Search:
				
					Console.WriteLine("Wyszukaj kształt (kwadrat, koło, trójkąt, prostokąt)");
					string choose = Console.ReadLine();
						try
						{
							shapeList.FindAll(s => s.Name.Equals(choose)).ForEach(Console.WriteLine);
						}
						catch (Exception e)
						{

							Console.WriteLine( "Nie ma takiego kształtu");
						}	
						Console.ReadKey();
					break;
				case Menu.DisplayAll:
						DisplayList(shapeList);
						Console.ReadKey();
						Console.Clear();
						break;
				case Menu.Exit:
						displayMenu = true;
					break;
				default:
						Console.WriteLine("Wybrałeś złą opcję, spróbuj ponownie");
					break;
			}
				}
		}
		static void Main(string[] args)
		{
			MyLoop();
		}
		private static void DisplayMenu() 
		{ 
			Console.Clear(); 
			Console.WriteLine("[1] Generate sample data"); 
			Console.WriteLine("[2] Default sort"); 
			Console.WriteLine("[3] Sort by Perimeter");
			Console.WriteLine("[4] Filter by Shape type"); 
			Console.WriteLine("[5] Display shapes"); 
			Console.WriteLine("[0] Exit"); 
		}
		static void DisplayList(List<Shape> list)
		{
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
		
	}
}
