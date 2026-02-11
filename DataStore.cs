using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
    internal class DataStore
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Szemely> Persons { get; set; } = new List<Szemely>();
        public List<Gyanusitott> Suspects { get; set; } = new List<Gyanusitott>();
        public List<Tanu> Witnesses { get; set; } = new List<Tanu>();
        public List<Bizonyitek> Evidences { get; set; } = new List<Bizonyitek>();
        public List<Ugy> Cases { get; set; } = new List<Ugy>();
        public List<Idovonal> TimelineEvents { get; set; } = new List<Idovonal>();
    }
}
