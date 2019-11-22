using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace ConsoleApp4
{
	class Program
	{

		static void Main(string[] args)
		{
			List<Osoba> list = generate();
			XmlSerializer serializable = new XmlSerializer(typeof(List<Osoba>));
			try
			{
				using (TextWriter writer = new StreamWriter (@"./person.xml"))
				{
					serializable.Serialize(writer,list);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			list.Clear();
			List<Osoba> newList = new List<Osoba>();
			Console.WriteLine("Deserializacja");
			list = new List<Osoba>();
			try
			{
				using (TextReader reader = new StreamReader(@"./person.xml"))
				{
					var obj = serializable.Deserialize(reader);
					newList = (List<Osoba>) obj;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			newList.ForEach(Console.WriteLine);
		}
		private static List<Osoba> generate()
		{
			List<Osoba> List = new List<Osoba>();
			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine("Podaj imie");
				string imie = Console.ReadLine();
				Console.WriteLine("Podaj nazwisko");
				string nazwisko = Console.ReadLine();
				Osoba osoba = new Osoba();
				osoba.UstawDane(imie, nazwisko);
				List.Add(osoba);
			}
			Sort sort = new Sort();
			sort.SortPerson(List);
			LookTable(List);
			return List;
		}
		static void LookTable(List<Osoba> tab)
		{
			foreach (var osoba in tab)
			{
				Console.WriteLine(osoba.ToString());
			}

		}
	}
}
