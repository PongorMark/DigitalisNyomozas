namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
			User u1 = new User("Gipsz Jakab", 1, "Nyomozó");
			Szemely s1 = new Szemely("Trab Antal",67, "Látta a tetteseket, ahogy megkezdték a rablást.");
            Ugy U1 = new Ugy(1, "Louvre ékszerrablás", "3 láthatósági mellénybe öltözött karbantartónak álcázott tolvaj ellopott sok felbecsülhetetlen értékű ékszert, miközben a múzeum NYITVA volt", "folyamatban");
            UgyAllapot UA1 = new UgyAllapot("lezárt");
            Gyanusitott g1 = new Gyanusitott("Nagy Árpád", 30, "szabad");

            Console.WriteLine($"Felhasználó: {u1}");
			Console.WriteLine($"Személy: {s1}");
			Console.WriteLine($"Ügy: {U1}");
			Console.WriteLine($"Módosított ügy állapot: {UA1}");
			Console.WriteLine($"Gyanúsított: {g1}");
		}
    }
}
