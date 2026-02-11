using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
    internal class Idovonal
    {
        private DateTime datum;
        private string leiras;

        public Idovonal(DateTime datum, string leiras)
        {
            this.datum = datum;
            this.leiras = leiras;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public string Leiras { get => leiras; set => leiras = value; }

        public override string ToString()
        {
            return $"{datum}: {leiras}";
        }
    }
}

