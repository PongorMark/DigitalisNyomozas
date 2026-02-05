using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Ugy
	{
		private int id;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Szemely> szemelyeklistaja;
		private List<Bizonyitek> bizonyitekoklistaja;

		public Ugy(int id, string cim, string leiras, string allapot, List<Szemely> szemelyeklistaja, List<Bizonyitek> bizonyitekoklistaja)
		{
			this.id = id;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyeklistaja = szemelyeklistaja;
			this.bizonyitekoklistaja = bizonyitekoklistaja;
		}

		public int Id { get => id; set => id = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Szemely> Szemelyeklistaja { get => szemelyeklistaja; set => szemelyeklistaja = value; }
		internal List<Bizonyitek> Bizonyitekoklistaja { get => bizonyitekoklistaja; set => bizonyitekoklistaja = value; }

		public override string ToString()
		{
			return $"{this.cim}: {this.id}, {this.Leiras}, {this.allapot}, {string.Join(", ", szemelyeklistaja)}, {string.Join(", ", bizonyitekoklistaja)}";
		}
	}
}
