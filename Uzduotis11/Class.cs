using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis11
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int PuslapiuSkaicius { get; set; }
        public bool ArPerskaityta { get; set; }

        public Knyga()
        {

        }

        public Knyga(string pavadinimas, string autorius, int puslapiuSkaicius, bool arPerskaityta)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            PuslapiuSkaicius = puslapiuSkaicius;
            ArPerskaityta = arPerskaityta;
        }

        /*public bool PerskaitytiKnyga()
        {
            ArPerskaityta = true;
            return ArPerskaityta;
        }*/

        public string PerskaitytiKnyga()
        {
            ArPerskaityta = true;
            return $"Dziugu, jus perskaitete pateikta knyga!";
        }

        public string GautiAprasyma()
        {
            return $"Knygos informacija: Pavadinimas \"{Pavadinimas}\", Autorius {Autorius}, psl. skaicius - {PuslapiuSkaicius}.";
        }
    }
}
