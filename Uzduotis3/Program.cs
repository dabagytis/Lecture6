using System;

namespace Lecture6
{
    public class Program
    {
        // 3. Temperatūros vertinimas
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura (C):");
            int temp = int.Parse(Console.ReadLine());
            string arSilta = ArSilta(temp);

            Console.WriteLine($"{temp}C temperaturos, {arSilta}");
        }

        public static string ArSilta(int temp)
        {
            if (temp < 0)
            {
                return "salta";
            }
            else if (temp >= 0 && temp <= 20)
            {
                return "silta";
            }
            else
            {
                return "karsta";
            }
        }
    }
}