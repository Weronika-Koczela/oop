using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
	class Kontakty
	{
		List<Osoba> kontakty = new List<Osoba>();
		int liczbakontaktow;
		public int LiczbaKontaktow {
			get => liczbakontaktow;
			set => liczbakontaktow = value; }

		private Adres DaneAdresowe()
			{
			Console.WriteLine("Podaj szczegóły");
			Console.WriteLine("1.Kraj");
			var kraj =Console.ReadLine();
			Console.WriteLine("2.Miasto ");
			var miasto =Console.ReadLine();
			Console.WriteLine("3.Kod pocztowy");
			var kod = Console.ReadLine();
			Console.WriteLine("4.Ulica");
			var ulica = Console.ReadLine();
			Console.WriteLine("5.Numer domu");
			var numerD = Console.ReadLine();
			Console.WriteLine("6.Numer mieszkania ");
			var numerM = Console.ReadLine();
			Adres adres = new Adres();
			adres.UstawDane(kraj, miasto, kod, ulica, numerD, numerM);
			return adres;


		}
		public void PobierzKontakt()
		{
			for (int i = 0; i <= liczbakontaktow; i++)
			{
				Console.WriteLine("Podaj kontakt " + 1+i);
				Console.WriteLine("1. Imie ");
				var imie = Console.ReadLine();
				Console.WriteLine("2. Nazwisko");
				var nazwisko = Console.ReadLine();
				Adres adres = DaneAdresowe();
				Osoba osoba = new Osoba();
				osoba.UstawDane(imie, nazwisko, adres);
				kontakty.Add(osoba);

			}

		}
		public void WyswietlWszystkieKontakty()
		{

			Console.WriteLine("   Lista kontaktow   {0} wpisy   ", liczbakontaktow);
			int lp = 0;
			foreach (Osoba osoba in kontakty)
			{
				lp++;
				Console.WriteLine("{0}. {1} ",lp,osoba.PobierzImie() );

			}
			Console.WriteLine();
		}
		public void WyswietlSzczegoly(int numer)
		{
			if (numer > liczbakontaktow)
			{
				Console.WriteLine("Nie ma takiego numer, istnieja tylko {0} wpisy ", liczbakontaktow);
				return;
			}
			Console.Clear();
			Console.WriteLine("   Dane kontaktowe   ");
			Console.WriteLine(kontakty[numer].DaneOS());
			
		}
	}
	
}
