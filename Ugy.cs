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
        private List<Idovonal> idovonalLista = new List<Idovonal>();
        internal List<Idovonal> IdovonalLista { get => idovonalLista; set => idovonalLista = value; }


        public Ugy(int id, string cim, string leiras, string allapot,
            List<Szemely> szemelyeklistaja, List<Bizonyitek> bizonyitekoklistaja)
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
        public List<Szemely> Szemelyeklistaja { get => szemelyeklistaja; set => szemelyeklistaja = value; }
        public List<Bizonyitek> Bizonyitekoklistaja { get => bizonyitekoklistaja; set => bizonyitekoklistaja = value; }

        public override string ToString()
        {
            return $"{cim} (ID: {id}) - {leiras} | Állapot: {allapot}\nSzemélyek: {string.Join(", ", szemelyeklistaja)}\nBizonyítékok: {string.Join(", ", bizonyitekoklistaja)}";
        }
    }
}

