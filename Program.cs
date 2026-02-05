namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
			User u1 = new User("Gipsz Jakab", 1, "Nyomozó");
			Szemely s1 = new Szemely("Trab Antal",67, "szemtanú");
            Ugy U1 = new Ugy(1, "Louvre ékszerrablás", "3 láthatósági mellénybe öltözött karbantartónak álcázott tolvaj ellopott sok felbecsülhetetlen értékű ékszert, miközben a múzeum NYITVA volt", "folyamatban");
            UgyAllapot UA1 = new UgyAllapot("lezárt");
            Gyanusitott g1 = new Gyanusitott("Nagy Árpád", 30, "szabad");
            Tanu t1 = new Tanu("Zsíros B. Ödön", "Látta a tetteseket, ahogy megkezdték a rablást.", "2025. 10. 25.");
            Bizonyitek b1 = new Bizonyitek(1, "fotó", "A szemtanú fényképeket készített az ékszerek hűlt helyéről.", 5);
            Idovonal i1 = new Idovonal("2025. 10. 19. , 9:30", "A rablás kezdete");
			Idovonal i2 = new Idovonal("2025. 10. 19. , 9:37", "A rablás vége");
			Idovonal i3 = new Idovonal("2025. 10. 19. , 9:38", "Menekülés elektromos rollerekkel");

			Console.WriteLine($"Felhasználó: {u1}");
			Console.WriteLine($"Személy: {s1}");
			Console.WriteLine($"Ügy: {U1}");
			Console.WriteLine($"Módosított ügy állapot: {UA1}");
			Console.WriteLine($"Gyanúsított: {g1}");
			Console.WriteLine($"Tanú: {t1}");
			Console.WriteLine($"Bizonyíték: {b1}");
			Console.WriteLine($"idővonal: {i1}, {i2}, {i3}");
		}
    }
}
