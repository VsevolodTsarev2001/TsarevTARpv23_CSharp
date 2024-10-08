﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsarevTARpv23_CSharp
{
    public class Funktsioonid
    {
        //Listid ja sõnastikud. Meetodid ja näidised - Ülesanne 1
        public static void Ull()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Sisesta numbrid");
            string numbstr = Console.ReadLine();
            string[] numblist = numbstr.Split(" ");
            int[] newlist = new int[numblist.Length];

            for (int i = 0; i < numblist.Length; i++)
            {
                int a;
                if (i == 0)
                {
                    a = int.Parse(numblist[numblist.Length - 1]) + int.Parse(numblist[i + 1]);
                }
                else if (i == numblist.Length - 1)
                {
                    a = int.Parse(numblist[i-1]) + int.Parse(numblist[i + 1]);
                }
                else
                {
                    a = int.Parse(numblist[i - 1] + int.Parse(numblist[i + 1]));                
                }

                newlist[i] = a;
            }
            Console.WriteLine("New list of sums: ");
            Console.WriteLine(string.Join(" ", newlist));
        }
        /*-------------------------------------------------------------------------------*/
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
        /*--------------------------------4------------------------------*/
        public static void OstaElevant()
        {
            string kasutajaSisend;

            do
            {
                Console.WriteLine("Osta elevant ära!");

                kasutajaSisend = Console.ReadLine();
            }
            while (!string.Equals(kasutajaSisend, "elevant", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Kasutaja sisestas Elevant. Programm lõpetab.");
        }
        /*------------------------------5-------------------------------------*/
        public static void NimedJaVanused()
        {
            string[] nimed = new string[5];
            int[] vanused = new int[5];
            int summaarneVanus = 0;

            for (int i = 0; i < nimed.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. nimi: ");
                nimed[i] = Console.ReadLine();
                Console.Write($"Sisesta {nimed[i]} vanus: ");
                vanused[i] = int.Parse(Console.ReadLine());
                summaarneVanus += vanused[i];
            }

            double keskmineVanus = (double)summaarneVanus / vanused.Length;
            int vanimVanus = vanused.Max();
            int noorimVanus = vanused.Min();
            string vanimInimene = nimed[Array.IndexOf(vanused, vanimVanus)];
            string noorimInimene = nimed[Array.IndexOf(vanused, noorimVanus)];

            Console.WriteLine($"Summaarne vanus: {summaarneVanus}");
            Console.WriteLine($"Aritmeetiline keskmine: {keskmineVanus}");
            Console.WriteLine($"Vanim inimene on {vanimInimene}, vanus: {vanimVanus}");
            Console.WriteLine($"Noorim inimene on {noorimInimene}, vanus: {noorimVanus}");
        }
    }
}
