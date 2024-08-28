using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsarevTARpv23_CSharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //I.osa Andmetüübid Alamfunktsioonid, If, Random, Case
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus1 = Funktsioonid.Liitmine(a, b);
            Console.WriteLine(vastus1);
            double arv = 5.123456;
            vastus1=Funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus1);
            char taht = 'A';
            if (vastus1 == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus1);
            }
/*----------------------------------------------------------------------*/
            Console.WriteLine("Arv1: ");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arv2: ");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tehe: ");
            char tehe = char.Parse(Console.ReadLine());
            if (tehe == '+')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 + arv2);
            }
            else if (tehe == '-')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
            }
            else if (tehe == '*')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 * arv2);
            }
            else if (tehe == '/')
            {
                Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 / arv2);
            }
/*--------------------------------------------------------------------------*/
            Console.WriteLine("Tere tulemast!\nMis on sinu nimi?");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere " + eesnimi);
            //&&-and, ||-or, !-not 
            if (eesnimi.ToUpper() == "JUKU")
            {
                Console.WriteLine("Lähme kinno!\nKui vana sa oled?");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus < 0 || vanus > 100)
                {
                    Console.WriteLine("Viga!");
                }
                else if (vanus <= 6)
                {
                    Console.WriteLine("Tasuta pilet!");
                }
                else if (vanus <= 15)
                {
                    Console.WriteLine("Lastepilet!");
                }
                else if (vanus <= 65)
                {
                    Console.WriteLine("Täispilet!");
                }
                else if (vanus <= 100)
                {
                    Console.WriteLine("Sooduspilet!");
                }
                /*-----------------------------------------------------------------------*/
                try
                {
                    Console.WriteLine("Mis on sinu pikkus?");
                    double pikkus = Double.Parse(Console.ReadLine());
                    string vastus = Funktsioonid.Pikkuse_analuus(pikkus);
                    Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus);
                }
                catch (Exception e)
                {
                    Console.Write(e.ToString());
                }
                /*-----------------------------------------------------------------------*/
                for (int i = 0; i < 7; i++)
                {
                    Random random = new Random();
                    int paev_nr = random.Next(-2, 10);
                    string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                    Console.WriteLine("Päeva nr: {0}. See on {1}", paev_nr, paeva_nimetus);
                }
                /*---------------------------------------------------------------------*/
                /*//1            
                string[] nimed = new string[5] { "Anna", "Inna", "Oksana", "Pavel", "Karl" };
                nimed[0] = "Marina";
                for (int i = 0; i < nimed.Length; i++)
                {
                    Console.WriteLine(nimed[i]);
                }
                //2
                foreach (string nimi in nimed)
                {
                    Console.WriteLine(nimi);
                }
                //3
                int n = 0;
                while (n<nimed.Length);
                {
                    Console.WriteLine(nimed[n]);
                    n++;
                }
                //4
                do
                {
                    Console.WriteLine(nimed[n-1]);
                    n--;
                }
                while (n>0); */ //!=
                /*-----------------------------------------------------------------------*/
                /*
                Random rand = new Random();
                int N = rand.Next(-100, 101);
                int M = rand.Next(-100, 101);
                Console.WriteLine($"Arvude {N} ja {M} ruudud:");
                Funktsioonid.ArvudeRuudud(N, M);
                */
                Random rand = new Random();
                int N = rand.Next(-100, 101);
                int M = rand.Next(-100, 101);
                int[] arvud;
                Console.WriteLine(N);
                Console.WriteLine(M);
                if (N < M)
                {
                    arvud = Funktsioonid.Arvude_massiiv(N, M);
                }
                else
                {
                    arvud = Funktsioonid.Arvude_massiiv(M, N);
                }
                foreach (int i in arvud)
                {
                    Console.WriteLine(item * item);
                }
            }
        }     
    }
}
