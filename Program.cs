

using System.Diagnostics;

namespace LineairZoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Maak een array met 10.000 willekeurige getallen
            int[] getallen = new int[10000];
            Random random = new Random();

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = random.Next(1, 100001);
            }

            // 2. Sorteer de array van laag naar hoog
            Array.Sort(getallen);

            // 3. Vraag aan de gebruiker welk getal gezocht moet worden
            Console.WriteLine("Welk getal wil je zoeken in de array (tussen 1 en 100000)?");
            int target = Convert.ToInt32(Console.ReadLine());

            // 4. Start de timer en voer het lineair zoeken uit
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool gevonden = LinearSearch(getallen, target);

            stopwatch.Stop();

            // 5. Resultaat tonen op het scherm
            Console.WriteLine("\n--- RESULTAAT ---");
            Console.WriteLine("Is het getal " + target + " gevonden? " + gevonden);
            Console.WriteLine("Looptijd (runtime): " + stopwatch.Elapsed.TotalMilliseconds + " ms");

            // Scherm openhouden tot je op Enter drukt
            Console.WriteLine("\nDruk op enter om af te sluiten...");
            Console.ReadLine();
        }

        // Functie voor lineair zoeken
        static bool LinearSearch(int[] array, int target)
        {
            foreach (int element in array)
            {
                if (element == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}