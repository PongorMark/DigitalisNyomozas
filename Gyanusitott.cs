using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
    internal class Gyanusitott
    {
        private Szemely szemely;
        private int gyanuSzint;
        private string statusz;

        public Gyanusitott(Szemely szemely, int gyanuSzint, string statusz)
        {
            this.szemely = szemely;
            this.gyanuSzint = gyanuSzint;
            this.statusz = statusz;
        }

        public Szemely Szemely { get => szemely; set => szemely = value; }
        public int GyanuSzint { get => gyanuSzint; set => gyanuSzint = value; }
        public string Statusz { get => statusz; set => statusz = value; }

        public override string ToString()
        {
            return $"{szemely.Nev} | Gyanúsítottság: {gyanuSzint}% | Státusz: {statusz}";
        }
    }
}
