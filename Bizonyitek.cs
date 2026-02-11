using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
    internal class Bizonyitek
    {
        private int id;
        private string tipus;
        private string leiras;
        private int megbizhatosag;

        public Bizonyitek(int id, string tipus, string leiras, int megbizhatosag)
        {
            this.id = id;
            this.tipus = tipus;
            this.leiras = leiras;
            this.megbizhatosag = megbizhatosag;
        }

        public int Id { get => id; set => id = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }

        public override string ToString()
        {
            return $"{id}: {tipus} - {leiras} (Megbízhatóság: {megbizhatosag}/5)";
        }
    }
}
