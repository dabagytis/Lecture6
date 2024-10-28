using System;

namespace Lecture6
{
    public class Program
    {
        // 7. Rasti daliklius iki ribos
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int riba = int.Parse(Console.ReadLine());

            Console.WriteLine(Dalikliai(riba));
        }

        public static string Dalikliai(int riba)
        {
            string sequence = "";
            for (int i = 1; i <= riba; i++)
            {
                if (riba % i == 0)
                {
                    sequence = sequence + $"{i} ";
                }
            }
            return sequence;
        }
    }
}