using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class UgyAllapot
	{
		private string aktualisStatusz;

		public UgyAllapot(string aktualisStatusz)
		{
			this.aktualisStatusz = aktualisStatusz;
		}

		public string AktualisStatusz { get => aktualisStatusz; set => aktualisStatusz = value; }
	}
}
