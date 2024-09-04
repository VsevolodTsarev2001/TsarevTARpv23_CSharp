using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------Listid ja sõnastikud. Meetodid ja näidised teine osa ülesanne 3
namespace TsarevTARpv23_CSharp
{

    public enum Sugu
    {
        mees,
        naine
    }
    public enum Eluviis
    {
        Istuv = 1,
        Vähene,
        Mõõdukas,
        Kõrge,
        Väga_kõrge
    }
    internal class Inimene 
    {

        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Sugu Sugu { get; set; }
        public int Pikkus { get; set; }
        public double Kaal {  get; set; }
        public Eluviis Eluviis { get; set; }
        public Inimene() { }
        public Inimene(string nimi, int vanus = 2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public Inimene(string nimi, int vanus, Sugu sugu = Sugu.mees)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
        }
        public Inimene(string nimi, int vanus, Sugu sugu = Sugu.mees, Eluviis eluviis = Eluviis.Istuv)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Eluviis = eluviis;
        }
        public double HB_vorrand( Eluviis eluviis)
        {
            double SBI = 0;
            if (Sugu == 0)
            {
                SBI = 66 + (13.7 * Kaal) + (5 * Pikkus) - (6.8 * Vanus);
            }
            else
            {
                SBI = 655 + (9.6 * Kaal) + (1.8 * Pikkus) - (4.7 * Vanus);
            }
            switch (eluviis)
            {
                case Eluviis.Istuv:
                    SBI = SBI * 1.2;
                    break;
                case Eluviis.Vähene:
                    SBI = SBI * 1.375; 
                    break;
                case Eluviis.Mõõdukas:
                    SBI = SBI * 1.55;
                    break;
                case Eluviis.Kõrge:
                    SBI = SBI * 1.725;
                    break;
                case Eluviis.Väga_kõrge:
                    SBI = SBI * 1.9;
                    break;
                default:
                    break;
            }
            return SBI;
        }
    }        
}
