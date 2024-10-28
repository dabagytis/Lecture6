using System;
using Uzduotis8;

namespace Lecture6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis();
            Console.WriteLine("Iveskite automobilio marke:");
            automobilis.Marke = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite automobilio modeli:");
            automobilis.Modelis = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite metus:");
            automobilis.Metai = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Iveskite kuro likuti(L):");
            automobilis.KuroLikutis = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Automobilis: {automobilis.Marke} {automobilis.Modelis}, {automobilis.Metai}");
            Console.WriteLine($"Iveskite, kiek norite pildyti kuro. Jusu likutis: {automobilis.KuroLikutis}L");
            double kuras = double.Parse(Console.ReadLine());

            while (true)
            {
                if (kuras >= 0)
                {
                    Console.WriteLine($"Pasirinkote papildyti {kuras}L kuro, dabar turite {automobilis.PildytiKura(kuras)}L");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Ivestas nevalidus kuro kiekis, bandykite dar karta");
                    kuras = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Iveskite, koki atstuma norite vaziuoti (km):");
            double atstumas = double.Parse(Console.ReadLine());

            while (true)
            {
                if (atstumas >= 0)
                {
                    Console.WriteLine(automobilis.Vaziuoti(atstumas));
                    break;
                }
                else
                {
                    Console.WriteLine("Ivestas nevalidus atstumas, bandykite dar karta");
                    atstumas = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }
    }
}