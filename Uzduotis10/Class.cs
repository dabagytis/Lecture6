using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis10
{
    public class Apskritimas
    {
        public double Spindulys { get; set; }

        public Apskritimas()
        {

        }

        public Apskritimas(double spindulys)
        {
            Spindulys = spindulys;
        }

        public double skaiciuotiPlota()
        {
            double plotas = Math.Round(Math.PI * Math.Pow(Spindulys, 2), 2);
            return plotas;
        }

        public double skaiciuotiPerimetra()
        {
            double perimetras = Math.Round(2 * Math.PI * Spindulys, 2);
            return perimetras;
        }
    }
}
