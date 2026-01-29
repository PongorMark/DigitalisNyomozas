using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Donteshozo
	{
		private int gyanusitottsagiModositas;
		private string figyelmeztetes;

		public Donteshozo(int gyanusitottsagiModositas, string figyelmeztetes)
		{
			this.gyanusitottsagiModositas = gyanusitottsagiModositas;
			this.figyelmeztetes = figyelmeztetes;
		}

		public int GyanusitottsagiModositas { get => gyanusitottsagiModositas; set => gyanusitottsagiModositas = value; }
		public string Figyelmeztetes { get => figyelmeztetes; set => figyelmeztetes = value; }
	}
}
