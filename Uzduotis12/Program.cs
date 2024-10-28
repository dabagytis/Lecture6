using System;
using Uzduotis12;

namespace Lecture6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankoSaskaita bankoSaskaita = new BankoSaskaita();
            Console.WriteLine("Iveskite savininko varda ir pavarde:");
            bankoSaskaita.SavininkoVardas = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite saskaitos numeri:");
            bankoSaskaita.SaskaitosNumeris = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Iveskite saskaitos balansa (eur):");
            bankoSaskaita.Balansas = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(bankoSaskaita.GautiInformacija());
            Console.WriteLine();

            Console.WriteLine("Ar norite ideti, ar nusiimti pinigu?");
            string pliusminus = Console.ReadLine();

            while (true)
            {
                if (pliusminus == "ideti")
                {
                    Console.WriteLine("Iveskite pinigu suma (eur):");
                    double pridetiPinigu = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(pridetiPinigu >= 0)
                    {
                        Console.WriteLine(bankoSaskaita.IdetiPinigus(pridetiPinigu));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nevalidi pinigu suma, bandykite dar karta");
                        continue;
                    }
                }
                else if (pliusminus == "nusiimti")
                {
                    Console.WriteLine("Iveskite pinigu suma (eur):");
                    double nuimtiPinigu = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if(nuimtiPinigu >= 0)
                    {
                        Console.WriteLine(bankoSaskaita.NusiimtiPinigus(nuimtiPinigu));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nevalidi pinigu suma, bandykite dar karta");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Klaida");
                    break;
                }
            }
        }
    }
}