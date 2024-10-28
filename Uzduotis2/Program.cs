using System;

namespace Lecture6
{
    public class Program
    {
        // 2. Sudėti iki duoto skaičiaus
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Sudetis(skaicius));
        }
        public static int Sudetis(int skaicius)
        {
            int suma = 0;
            for(int i = 1; i <= skaicius; i++)
            {
                suma = suma + i;
            }
            return suma;
        }
    }
}