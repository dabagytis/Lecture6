using System;

namespace Lecture6
{
    public class Program
    {
        // 5. Rasti nelyginių skaičių sumą iki ribos
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int riba = int.Parse(Console.ReadLine());

            Console.WriteLine($"Visu nelyginiu skaiciu iki {riba} suma yra {Nelyginiai(riba)}");
        }

        public static int Nelyginiai(int riba)
        {
            int suma = 0;
            for(int i = 1; i <= riba; i++)
            {
                if (i % 2 != 0)
                {
                    suma = suma + i;
                }
            }
            return suma;
        }
    }
}