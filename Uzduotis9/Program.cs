using System;
using Uzduotis9;

namespace Lecture6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Studentas studentas = new Studentas();
            Console.WriteLine("Iveskite varda:");
            studentas.Vardas = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite pavarde:");
            studentas.Pavarde = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite amziu:");
            studentas.Amzius = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Iveskite dabartini pazymiu vidurki:");
            studentas.Vidurkis = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Studentas {studentas.Vardas} {studentas.Pavarde}, amzius - {studentas.Amzius}m.");
            Console.WriteLine($"Dabartinis pažymių vidurkis - {studentas.Vidurkis}. Iveskite nauja pazymi:");
            double pazymys = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Naujas vidurkis - {studentas.pridetiPazymi(pazymys)}. {studentas.arPerejoISekanciaKlase()}");
        }
    }
}