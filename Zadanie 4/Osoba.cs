using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ConsoleApp4
{
	[Serializable]
	[XmlRoot("OSOBA")]
	public class Osoba : IComparable<Osoba>
	{
			public Osoba()
			{

			}

			public Osoba(string imie, string nazwisko, int wiek, string miasto)
			{
				_imie = imie;
				_nazwisko = nazwisko;
				_wiek = wiek;
				_miasto = miasto;
			}
			private string _imie;
			private string _nazwisko;
		private int _wiek;
		private string _miasto;
		[XmlAttribute ("Imie")]
			public string Imie
			{
				get => _imie;
				set => _imie = value;
			}
		[XmlAttribute ("Nazwisko")]
			public string Nazwisko
			{
				get => _nazwisko;
				set => _nazwisko = value;
			}
			public int Wiek
			{
			get => _wiek;
			set => _wiek = value;
			}
		public string Miasto { get => _miasto; set => _miasto = value; }

		public void UstawDane(string imie, string nazwisko, int wiek)
			{
				_imie = imie;
				_nazwisko = nazwisko;
				_wiek = wiek;
			}


			public string DaneOS()
			{
				return _imie + " " + _nazwisko + "\n ";

			}

			public string PrzedstawSie()
			{
				return "Nazywam się " + _imie + " " + _nazwisko + "\n";

			}

			public override string ToString()
			{
				return $"{_imie} {_nazwisko}, {_wiek}, {_miasto}";
			}

			public string PobierzImie()
			{
				return _imie + " " + _nazwisko;
			}

			public int CompareTo(Osoba other)
			{
			int wynik = Nazwisko.CompareTo(other.Nazwisko);
			if (wynik == 0 )
				wynik=Imie.CompareTo(other.Imie);
			return wynik;
			}

		
	}
	class SortByFirstName : IComparer<Osoba>
	{
		public int Compare(Osoba x, Osoba y)
		{
			if (x.Imie == null || y.Imie == null)
				return -1;
			return x.Imie.CompareTo(y.Imie);
		}

	}
	class SortByAge : IComparer<Osoba>
	{
		public int Compare(Osoba x, Osoba y)
		{
			if (x.Wiek.CompareTo(y.Wiek) == 0)
				return 0;
			else if (x.Wiek.CompareTo(y.Wiek) > 0)
				return -1;
			else
				return 1;
		}
	}
}

