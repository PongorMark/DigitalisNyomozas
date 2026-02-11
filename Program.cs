using System;
using System.Collections.Generic;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore store = new DataStore();

            // Tesztadatok
            User u1 = new User("Gipsz Jakab", 1, "Nyomozó");
            store.Users.Add(u1);

            Szemely s1 = new Szemely("Trab Antal", 67, "szemtanú");
            Szemely s2 = new Szemely("Kiss Félix", 26, "tolvaj");
            store.Persons.Add(s1);
            store.Persons.Add(s2);

            Bizonyitek b1 = new Bizonyitek(1, "fotó", "A szemtanú fényképeket készített az ékszerek hűlt helyéről.", 5);
            store.Evidences.Add(b1);

            Ugy U1 = new Ugy(1, "Louvre ékszerrablás",
                "3 láthatósági mellénybe öltözött karbantartónak álcázott tolvaj ellopott sok felbecsülhetetlen értékű ékszert, miközben a múzeum NYITVA volt",
                "Folyamatban", new List<Szemely> { s1, s2 }, new List<Bizonyitek> { b1 });
            store.Cases.Add(U1);

            // Egyszerű menü
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== DIGITÁLIS NYOMOZÁS ===");
                Console.WriteLine("1. Ügyek listázása");
                Console.WriteLine("2. Személyek listázása");
                Console.WriteLine("3. Bizonyítékok listázása");
                Console.WriteLine("4. Kilépés");
                Console.Write("Választás: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\n--- Ügyek ---");
                        Console.WriteLine("1. Ügyek listázása");
                        Console.WriteLine("2. Új ügy felvétele");
                        Console.Write("Választás: ");
                        string ugyInput = Console.ReadLine();

                        switch (ugyInput)
                        {
                            case "1":
                                Console.WriteLine("\n--- Ügyek listája ---");
                                foreach (var ugy in store.Cases)
                                    Console.WriteLine(ugy);
                                break;
                            case "2":
                                Console.WriteLine("\n--- Új ügy felvétele ---");
                                Console.Write("Cím: ");
                                string cim = Console.ReadLine();
                                Console.Write("Leírás: ");
                                string leiras = Console.ReadLine();
                                Console.Write("Állapot (nyitott/folyamatban/lezárt): ");
                                string allapot = Console.ReadLine();

                                int nextId = store.Cases.Count + 1;
                                Ugy ujUgy = new Ugy(nextId, cim, leiras, allapot, new List<Szemely>(), new List<Bizonyitek>());
                                store.Cases.Add(ujUgy);

                                Console.WriteLine($"\nSikeresen felvéve az új ügy: {ujUgy}");
                                break;
                            default:
                                Console.WriteLine("Érvénytelen választás.");
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Személyek ---");
                        foreach (var szemely in store.Persons)
                            Console.WriteLine(szemely);
                        break;
                    case "3":
                        Console.WriteLine("\n--- Bizonyítékok ---");
                        foreach (var bizonyitek in store.Evidences)
                            Console.WriteLine(bizonyitek);
                        break;
                    case "4":
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("Érvénytelen választás.");
                        break;
                }

                Console.WriteLine("\nNyomj egy gombot a folytatáshoz...");
                Console.ReadKey();
            }
        }
    }
}
