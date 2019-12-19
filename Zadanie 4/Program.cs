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
		delegate bool search(Osoba o);
		private static bool searchByAge(Osoba o)
		
		{
			return o.Wiek < 40;
		}
		private static bool searchByFName(Osoba o)
		{
			return o.Imie.ToUpper().Equals("KAMILA");
		}
		private static bool searchBySName(Osoba o)
		{

			return o.Nazwisko.ToUpper().Equals("NOWAK");
		}
		private static bool searchByCity(Osoba o)
		{

			return o.Miasto.ToUpper().Equals( "POZNAŃ");
		}
		private static List<Osoba> Filter(List<Osoba> list, search filter)
		{
			List<Osoba> result = new List<Osoba>();
			foreach (Osoba os in list)
			{
				if (filter(os)) 
					result.Add(os);
			
			}
			return result;
		}
		public static void DisplayList(List<Osoba> list)
		{

			foreach (Osoba o in list)
			{
				Console.WriteLine(o);
			}
		}
		
		static void Main(string[] args)
		{
			List<Osoba> osoby = new List<Osoba>();
	
			Osoba os1 = new Osoba("Kamila", "Nowak", 13, "Warszawa");
			Osoba os2 = new Osoba("Krystian", "Wieczorek", 5, "Poznań");
			Osoba os3 = new Osoba("Alicja", "Leśniewska", 71, "Kraków");
			Osoba os4 = new Osoba("Aleksandra", "Mróz", 44, "Poznań" );
			Osoba os5 = new Osoba("Oliwia", "Krzemieniec", 56, "Komorniki");
			Osoba os6 = new Osoba("Jessica", "Gacek", 16, "Łódź");
			Osoba os7 = new Osoba("Tomasz", "Kowalski", 25, "Gdańsk");
			Osoba os8 = new Osoba("Sebastian", "Nowak", 4, "Poznań");
			Osoba os9 = new Osoba("Ewa", "Owczyńska", 54, "Warszawa");
			Osoba os10 = new Osoba("Patrycja", "Nowak", 44, "Szczecin");
			osoby.Add(os1);
			osoby.Add(os2);
			osoby.Add(os3);
			osoby.Add(os4);
			osoby.Add(os5);
			osoby.Add(os6);
			osoby.Add(os7);
			osoby.Add(os8);
			osoby.Add(os9);
			osoby.Add(os10);

			// Delegaty
			//Console.WriteLine();
			//Filter(osoby, searchByFName).ForEach(Console.WriteLine);
			//Console.WriteLine();
			//Filter(osoby, searchBySName).ForEach(Console.WriteLine);
			//Console.WriteLine();
			//Filter(osoby, searchByAge).ForEach(Console.WriteLine);
			//Console.WriteLine();
			//Filter(osoby, searchByCity).ForEach(Console.WriteLine);

			//Predykaty
			//osoby.Sort(new SortByAge());
			//osoby.FindAll(searchByFName).ForEach(Console.WriteLine);
			//Console.WriteLine();
			//osoby.FindAll(searchBySName).ForEach(Console.WriteLine);
			//Console.WriteLine();
			//osoby.FindAll(searchByAge).ForEach(Console.WriteLine);
			//Console.WriteLine();
			//osoby.FindAll(searchByCity).ForEach(Console.WriteLine);
			osoby.Sort(new SortByFirstName());
			osoby.FindAll(o => o.Wiek > 35 || o.Wiek < 10).ForEach(Console.WriteLine);
			Console.WriteLine();
			osoby.FindAll(o => o.Imie.ToUpper().Equals("SEBASTIAN") || o.Imie.ToUpper().Equals("TOMASZ")).ForEach(Console.WriteLine);
			Console.WriteLine(); 
			osoby.FindAll(o => o.Miasto.ToUpper().Equals("POZNAŃ") || o.Miasto.ToUpper().Equals("GDAŃSK")).ForEach(Console.WriteLine);
			Console.WriteLine();
			osoby.FindAll(o => o.Nazwisko.ToUpper().Equals("NOWAK") || o.Nazwisko.ToUpper().Equals("WIECZOREK")).ForEach(Console.WriteLine);
		}
		private static List<Osoba> generate()
		{
			Console.WriteLine("Podaj ilość osób");
			int odp;
			int.TryParse(Console.ReadLine(), out odp);
			List<Osoba> List = new List<Osoba>();
			for (int i = 0; i < odp; i++)
			{
				Console.WriteLine("Podaj imie");
				string imie = Console.ReadLine();
				Console.WriteLine("Podaj nazwisko");
				string nazwisko = Console.ReadLine();
				Console.WriteLine("Podaj wiek");
				int wiek;
				int.TryParse(Console.ReadLine(), out wiek);
				Osoba osoba = new Osoba();
				osoba.UstawDane(imie, nazwisko, wiek);
				List.Add(osoba);
			}
			List.Sort();
			List.ForEach(Console.WriteLine);
			Console.WriteLine();
			List.Sort(new SortByAge());
			List.ForEach(Console.WriteLine);
			Console.WriteLine();
			List.Sort(new SortByFirstName());
			List.ForEach(Console.WriteLine);
			return List;
		}
		
		//static void Serialization()
		//{
		//	List<Osoba> list = generate();
		//	XmlSerializer serializable = new XmlSerializer(typeof(List<Osoba>));
		//	try
		//	{
		//		using (TextWriter writer = new StreamWriter(@"./person.xml"))
		//		{
		//			serializable.Serialize(writer, list);
		//		}
		//	}
		//	catch (Exception e)
		//	{
		//		Console.WriteLine(e.Message);
		//	}

		//	list.Clear();
		//	List<Osoba> newList = new List<Osoba>();
		//	Console.WriteLine("Deserializacja");
		//	list = new List<Osoba>();
		//	try
		//	{
		//		using (TextReader reader = new StreamReader(@"./person.xml"))
		//		{
		//			var obj = serializable.Deserialize(reader);
		//			newList = (List<Osoba>)obj;
		//		}
		//	}
		//	catch (Exception e)
		//	{
		//		Console.WriteLine(e.Message);
		//	}
		//	newList.ForEach(Console.WriteLine);
		//}
	}
}
