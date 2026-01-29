using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Bizonyitekkezelo
	{
		private string hozzaadas;
		private string torles;

		public Bizonyitekkezelo(string hozzaadas, string torles)
		{
			this.hozzaadas = hozzaadas;
			this.torles = torles;
		}

		public string Hozzaadas { get => hozzaadas; set => hozzaadas = value; }
		public string Torles { get => torles; set => torles = value; }
	}
}
