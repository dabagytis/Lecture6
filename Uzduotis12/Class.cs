using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis12
{
    public class BankoSaskaita
    {
        public string SavininkoVardas { get; set; }
        public int SaskaitosNumeris { get; set; }
        public double Balansas { get; set; }

        public BankoSaskaita()
        {

        }

        public BankoSaskaita(string savininkoVardas, int saskaitosNumeris, double balansas)
        {
            SavininkoVardas = savininkoVardas;
            SaskaitosNumeris = saskaitosNumeris;
            Balansas = balansas;
        }

        // Norint pateikti tekstinius pranesimus, pasirinkau sukurti string funkcijas, nors uzduotyje nurodytos double
        public string IdetiPinigus(double pridetiPinigu)
        {
            Balansas = Balansas + pridetiPinigu;
            return $"Idejote {pridetiPinigu}eur. Saskaitos balansas - {Balansas}eur";
        }

        public string NusiimtiPinigus(double nuimtiPinigu)
        {
            if(Balansas >= nuimtiPinigu)
            {
                Balansas = Balansas - nuimtiPinigu;
                return $"Nusiemete {nuimtiPinigu}eur. Saskaitos balansas - {Balansas}eur";
            }
            else
            {
                return "Saskaitoje tiek pinigu nera";
            }
        }

        public string GautiInformacija()
        {
            return $"Saskaitos savininkas - {SavininkoVardas}, saskaitos balansas = {Balansas}eur";
        }
    }
}
