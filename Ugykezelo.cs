using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Ugykezelo
	{
		private string letrehozas;
		private string listazas;
		private string Hozzarendeles;

		public Ugykezelo(string letrehozas, string listazas, string hozzarendeles)
		{
			this.letrehozas = letrehozas;
			this.listazas = listazas;
			Hozzarendeles = hozzarendeles;
		}

		public string Letrehozas { get => letrehozas; set => letrehozas = value; }
		public string Listazas { get => listazas; set => listazas = value; }
		public string Hozzarendeles1 { get => Hozzarendeles; set => Hozzarendeles = value; }
	}
}
