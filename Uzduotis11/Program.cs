using System;
using Uzduotis11;

namespace Lecture6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Knyga knyga = new Knyga();
            Console.WriteLine("Iveskite knygos pavadinima:");
            knyga.Pavadinimas = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite knygos autoriu:");
            knyga.Autorius = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite knygos puslapiu skaiciu:");
            knyga.PuslapiuSkaicius = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ar esate perskaite sia knyga? (taip/ne)");
            while (true)
            {
                string ats1 = Console.ReadLine();
                if (ats1 == "taip")
                {
                    knyga.ArPerskaityta = true;
                    break;
                }
                else if (ats1 == "ne")
                {
                    knyga.ArPerskaityta = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Nevalidus atsakymas, bandykite dar karta");
                }
            }
            Console.WriteLine();
            Console.WriteLine(knyga.GautiAprasyma());
            Console.WriteLine();

            Console.WriteLine("Ar norite perskaityti sia knyga? (taip/ne)");
            while (true)
            {
                string ats2 = Console.ReadLine();
                if (ats2 == "taip")
                {
                    Console.WriteLine();
                    Console.WriteLine(knyga.PerskaitytiKnyga());
                    break;
                }
                else if (ats2 == "ne")
                {
                    Console.WriteLine();
                    Console.WriteLine("Na ir gerai, neskaitykit");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Nevalidus atsakymas, bandykite dar karta");
                }
            }
        }
    }
}