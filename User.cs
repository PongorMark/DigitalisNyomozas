using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class User
	{
		private string nev;
		private int id;
		private string szerepkor;

		public User(string nev, int id, string szerepkor)
		{
			this.nev = nev;
			this.id = id;
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Id { get => id; set => id = value; }
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }

		public override string ToString()
		{
			return $"{this.nev}: {this.id}, {this.szerepkor}";
		}
	}
}
