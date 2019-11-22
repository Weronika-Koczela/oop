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

			public Osoba(string imie, string nazwisko)
			{
				imie = _imie;
				nazwisko = _nazwisko;
			}
			private string _imie;
			private string _nazwisko;
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

			public void UstawDane(string imie, string nazwisko)
			{
				_imie = imie;
				_nazwisko = nazwisko;

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
				return _imie + " " + _nazwisko;
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
}

