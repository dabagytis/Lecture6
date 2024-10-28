using System;

namespace Lecture6
{
    public class Program
    {
        // 4. Skaičių pakėlimas kvadratu iki duotos ribos
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int riba = int.Parse(Console.ReadLine());

            Console.WriteLine(Squares(riba));
        }
        public static string Squares(int riba)
        {
            double square = 0;
            string sequence = "";
            for(int i = 1; i <= riba; i++)
            {
                square = Math.Pow(i, 2);
                sequence = sequence + $"{square} ";
            }
            return sequence;
        }
    }
}