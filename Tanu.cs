using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Tanu
	{
		private string nev;
		private string vallomas;
		private string datum;
public Tanu(string nev, string vallomas, string datum)
		{
			this.nev = nev;
			this.vallomas = vallomas;
			this.datum = datum;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Vallomas { get => vallomas; set => vallomas = value; }
		public string Datum { get => datum; set => datum = value; }

		public override string ToString()
		{
			return $"{this.nev}: {this.vallomas}, {this.datum}";
		}
	}
}
