using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
	class Program
	{
		enum ListaKontaktow { WyswietlWszystkie = 1, WyswietlSzczegoly, Wyjscie }
		private static void Petla()
		{
			bool wyjscie = false;
		Kontakty kontakty = new Kontakty();
			Console.WriteLine("Ile kontaktow chcesz dodac ");
			int odp;
			int.TryParse(Console.ReadLine(), out odp);
			kontakty.LiczbaKontaktow = odp;
			kontakty.PobierzKontakt();
			ListaKontaktow lista;
			while (!wyjscie)
			{
				Console.WriteLine("Wybierz opcje: \n 1. Wyswietl liste kontaków \n 2. Wyswietl szczegoly kontaktu \n 3. Wyjscie");
				bool opcja = Enum.TryParse<ListaKontaktow>(Console.ReadLine(), out lista);
				switch (lista)
				{
					case ListaKontaktow.WyswietlWszystkie:
						kontakty.WyswietlWszystkieKontakty();
						Console.ReadKey();
						Console.Clear();
						break;
					case ListaKontaktow.WyswietlSzczegoly:
						Console.WriteLine("Wybierz numer kontaku");
						int nr;
						int.TryParse(Console.ReadLine(), out nr);
						kontakty.WyswietlSzczegoly(nr-1);
						Console.ReadKey();
						Console.Clear();
						break;
					case ListaKontaktow.Wyjscie:
						wyjscie = true;
						break;
					default:
						Console.WriteLine("Wybrałeś złą opcję, spróbuj ponownie");
						Console.ReadKey();
						Console.Clear();
						break;
				}

			}


		}
		static void Main(string[] args)
		{
			Petla();
		}
	}
}
