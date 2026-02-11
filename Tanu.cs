using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
    internal class Tanu
    {
        private Szemely szemely;
        private string vallomas;
        private DateTime datum;

        public Tanu(Szemely szemely, string vallomas, DateTime datum)
        {
            this.szemely = szemely;
            this.vallomas = vallomas;
            this.datum = datum;
        }

        public Szemely Szemely { get => szemely; set => szemely = value; }
        public string Vallomas { get => vallomas; set => vallomas = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public override string ToString()
        {
            return $"{szemely.Nev} vallomása: \"{vallomas}\" ({datum.ToShortDateString()})";
        }
    }
}
