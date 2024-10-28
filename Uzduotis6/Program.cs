using System;

namespace Lecture6
{
    public class Program
    {
        // 6. Atspausdinti skaičius atbuline tvarka
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            int riba = int.Parse(Console.ReadLine());

            Console.WriteLine(AtbulineTvarka(riba));
        }

        public static string AtbulineTvarka(int riba)
        {
            string sequence = "";
            for(int i = riba; i >= 1; i--)
            {
                sequence = sequence + $"{i} ";
            }
            return sequence;
        }
    }
}