using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
	class Adres
	{
		private string ulica_;
		private string kodPocztowy_;
		private string miasto_;
		private string kraj_;
		private string numerDomu_;
		private string numerMieszkania_;
		

		public string UstawDane(string kraj, string miasto, string kodPocztowy, string ulica, string numerDomu, string numerMieszkania)
		{
			kraj_ = kraj;
			miasto_ = miasto;
			kodPocztowy_ = kodPocztowy;
			ulica_ = ulica;
			numerDomu_ = numerDomu;
			numerMieszkania_ = numerMieszkania;
			return ulica + " " + numerDomu + "/" + numerMieszkania + "\n " + kodPocztowy + " " + miasto + "\n" + kraj;
			


		}
		public override string ToString()
		{
			return ulica_ + " " + numerDomu_ + "/" + numerMieszkania_ + "\n " + kodPocztowy_ + " " + miasto_ + "\n" + kraj_;

		}
	}
}
