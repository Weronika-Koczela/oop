using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	public class Sort

	{ 
		public void SortPerson(List<Osoba> tab)
		{
			int k;
			for (int i = 0; i < (tab.Count - 1); i++)
			{
				Osoba temp = tab[i];
				k = i;
				for (int j = i + 1; j < tab.Count; j++)
					if (tab[j].CompareTo(temp) < 0)
					{
						k = j;
						temp = tab[j];
					}

				tab[k] = tab[i];
				tab[i]= temp;
			}
		}
	}
}
