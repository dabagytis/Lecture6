using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis9
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int Amzius { get; set; }
        public double Vidurkis { get; set; }

        public Studentas()
        {

        }
        public Studentas(string vardas, string pavarde, int amzius, double vidurkis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Vidurkis = vidurkis;
        }
        // Skaičiavimas atliekamas su prielaida, kad studento pradinį vidurkį sudaro 5 pažymiai
        public double pridetiPazymi(double pazymys)
        {
            int pazymiuSkaicius = 5;
            Vidurkis = Math.Round((Vidurkis * pazymiuSkaicius + pazymys) / (pazymiuSkaicius + 1));
            return Vidurkis;
        }

        /*public bool arPerejoISekanciaKlase()
        {
            if (Vidurkis >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public string arPerejoISekanciaKlase()
        {
            if (Vidurkis >= 5)
            {
                return "Vidurkis teigiamas, perejote i sekancia klase!";
            }
            else
            {
                return "Deja, vidurkis neigiamas, neperejote i sekancia klase...";
            }
        }
    }
}
