using System;

namespace övning_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antalTal = int.Parse(Console.ReadLine());

            int[] talArray = new int[antalTal];

            Console.WriteLine($"Skriv in {antalTal} heltal");
            for (int i = 0; i < antalTal; i++)
            {
                talArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Här är talen du skrev in:");
            for (int i = 0; i < talArray.Length; i++)
            {
                Console.WriteLine($"Tal {i + 1}: {talArray[i]}");
            }
        }
    }
}
