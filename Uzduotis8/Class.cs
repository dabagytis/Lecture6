using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis8
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Metai { get; set; }
        public double KuroLikutis { get; set; }

        public Automobilis()
        {

        }
        public Automobilis(string marke, string modelis, int metai, double kuroLikutis)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            KuroLikutis = kuroLikutis;
        }

        public double PildytiKura(double kuras)
        {
            KuroLikutis = KuroLikutis + kuras;
            return KuroLikutis;
        }

        public string Vaziuoti(double atstumas)
        {
            if (atstumas > KuroLikutis * 10)
            {
                return $"Nuvaziuotas atstumas - {KuroLikutis * 10}km. Nebeliko kuro.";
            }
            else
            {
                KuroLikutis = KuroLikutis - atstumas / 10;
                return $"Nuvaziuotas atstumas - {atstumas}km. Liko {KuroLikutis}L kuro";
            }
        }
    }
}
