using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsarevTARpv23_CSharp
{
    public class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        // Loo Arvuta() funktsioon, mis sõltub 3 parameetrist:tehe, arv1, arv2. Kasuta if konstruktsioon. Tulemus kuva ekraanile
        public static string Arvuta(int arv1, int arv2, char tehe)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            double j = Convert.ToDouble(table.Compute(arv1.ToString() + tehe.ToString() + arv2.ToString(), String.Empty));

            j = Math.Round(j, 0);
            string vastus = "";
            string nur = "nurr ";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus = vastus + nur;
            }
            return vastus;
        }
        public static string Pikkuse_analuus(double pikkus)
        {
            string analuus;
            if (pikkus<1.6)
            {
                analuus = "Lühike kasvu inimene";
            }
            else if (pikkus<1.8)
            {
                analuus = "Keskmine kasvu inimene";
            }
            else
            {
                analuus = "Pikka kasvu inimene";
            }
            return analuus;
        }
        //päeva number -> päeva nimetus
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;
            }
            return paev;
        }
        /*
        public static void ArvudeRuudud(int n, int m)
        {
            if (n > m)
            {
                int temp = n;
                n = m;
                m = temp;
            }

            int[] arvud = new int[m - n + 1];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = n + i;
            }

            foreach (int arv in arvud)
            {
                Console.WriteLine($"Arv: {arv}, ruut: {arv * arv}");
            }
            */
        public static int[] Arvude_massiiv(int N, int M) 
        {
            int arv;
            int[] arvud = new int[M-N];
            for (int i = 0; i < M-N; i++)
            {
                Console.WriteLine("{0} nimi :", i + 1);
                arv = N;
                arvud[i] = arv;
                N++;
            }
            return arvud;
        }
    }
}
