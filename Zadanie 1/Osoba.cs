using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
	class Osoba
	{
		public Osoba()
		{

		}

		public Osoba(string imie, string nazwisko)
		{

		}
		private string imie;
		private string nazwisko;
		private Adres adres;
		public Adres Adres => adres;
		public void UstawDane(string imie, string nazwisko, Adres adres)
		{
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.adres = adres;

		}


		public string DaneOS()
		{
			return  imie + " " + nazwisko + "\n Adres" + Adres;

		}

		public string PrzedstawSie()
		{
			return "Nazywam się " + imie + " " + nazwisko + "\n" + Adres;

		}

		public override string ToString()
		{
			return imie + " " + nazwisko;
		}

		public string PobierzImie()
		{
			return imie + " " + nazwisko;
		}
	}
}
