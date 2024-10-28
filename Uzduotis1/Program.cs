using System;

namespace Lecture6
{
    public class Program
    {
        // 1. Patikrinti pilnametystę
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu:");
            int amzius = int.Parse(Console.ReadLine());

            Console.WriteLine(ArPilnametis(amzius));
        }

        public static string ArPilnametis(int amzius)
        {
            if (amzius >= 18)
            {
                return $"Amzius {amzius}, pilnametis";
            }
            else if(amzius < 18)
            {
                return $"Amzius {amzius}, nepilnametis";
            }
            else
            {
                return "Nevalidus skaicius";
            }
        }
    }
}