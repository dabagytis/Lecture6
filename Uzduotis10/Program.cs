using System;
using Uzduotis10;

namespace Lecture6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Apskritimas apskritimas = new Apskritimas();
            Console.WriteLine("Iveskite apskritimo spinduli (cm)");
            apskritimas.Spindulys = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Kuomet apskritimo spindulys {apskritimas.Spindulys}cm, apskritimo plotas yra ~{apskritimas.skaiciuotiPlota()}cm2, o perimetras - ~{apskritimas.skaiciuotiPerimetra()}cm");
        }
    }
}