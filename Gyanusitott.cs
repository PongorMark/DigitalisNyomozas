using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Gyanusitott
	{
		private string nev;
		private int gyanuSzint;
		private string statusz;

		public Gyanusitott(string nev, int gyanuSzint, string statusz)
		{
			this.nev = nev;
			this.gyanuSzint = gyanuSzint;
			this.statusz = statusz;
		}

		public string Nev { get => nev; set => nev = value; }
		public int GyanuSzint { get => gyanuSzint; set => gyanuSzint = value; }
		public string Statusz { get => statusz; set => statusz = value; }

		public override string ToString()
		{
			return $"{this.nev}: {this.gyanuSzint} {this.statusz}";
		}
	}
}
