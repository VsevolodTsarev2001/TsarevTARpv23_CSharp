using System;
using System.Collections;
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
            Random random = new Random();
            //III.osa OOP
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene inimene3 = new Inimene("Marina", 18);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on" + inimene.Vanus + "aasta vana");
            }



                //II.osa listid ja sõnastikud
                ArrayList arrayList = new ArrayList();
                arrayList.Add("Esimene");
                arrayList.Add("Teine");
                arrayList.Add("Kolmas");
                Console.WriteLine("Otsing: ");
                string vas = Console.ReadLine();
                if (vas != null && arrayList.Contains(vas))
                {
                    Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) + ".kohal");
                }
                else
                {
                    Console.WriteLine("Kokku oli " + arrayList.Count + " elemente, vaid otsitav puudub");
                }
                arrayList.Clear();
                arrayList.Insert(1, "Anna");
                arrayList.Insert(0, "Inna");







                List<string> abc = new List<string>();
                try
                {
                    foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                    {
                        abc.Add(rida);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Fail ei saa leida!");
                }
                foreach (string e in abc)
                {
                    Console.WriteLine(e);
                }
                //I.osa Andmetüübid Alamfunktsioonid, If, Random, Case
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Hello, World!");
                string nimetus = "Python";
                Console.WriteLine("Hello, {0}", nimetus);
                Funktsioonid.Tere(nimetus);
                Console.Write("Sisesta esimene arv: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Sisesta teine arv: ");
                int b = int.Parse(Console.ReadLine());
                int vastus1 = Funktsioonid.Liitmine(a, b);
                Console.WriteLine(vastus1);
                double arv = 5.123456;
                vastus1 = Funktsioonid.Liitmine(a, (int)arv);
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
                    /*-----------------------------------1------------------------------------*/
                    /*
                    Random rand = new Random();
                    int N = rand.Next(-100, 101);
                    int M = rand.Next(-100, 101);
                    Console.WriteLine($"Arvude {N} ja {M} ruudud:");
                    Funktsioonid.ArvudeRuudud(N, M);
                    */
                    Console.OutputEncoding = Encoding.UTF8;
                    int N = random.Next(-10, 101);
                    int M = random.Next(-10, 101);
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
                    foreach (int item in arvud)
                    {
                        Console.WriteLine(item * item);
                    }
                    /*---------------------------5--------------------------------*/
                    int arvutiArv = random.Next(1, 50);

                    int kasutajaArv;
                    int katsed = 0;
                    bool arvatiOigesti = false;

                    Console.WriteLine("Programm on mõelnud välja arvu vahemikus 1 kuni 50, sul on 5 katset.");

                    while (katsed < 5 && !arvatiOigesti)
                    {
                        Console.Write("Sisesta oma arvatav arv: ");
                        kasutajaArv = int.Parse(Console.ReadLine());
                        katsed++;

                        if (kasutajaArv == arvutiArv)
                        {
                            Console.WriteLine("Õige! Sa arvasid arvu ära.");
                        }
                        else if (kasutajaArv < arvutiArv)
                        {
                            Console.WriteLine("Liiga väike!");
                        }
                        else
                        {
                            Console.WriteLine("Liiga suur!");
                        }

                        if (arvatiOigesti = false)
                        {
                            Console.WriteLine($"Kahjuks ei arvanud sa õiget arvu ära. Programm mõtles välja arvu {arvutiArv}.");
                        }

                        /*-------------------------------------2---------------------------------*/
                        int[] ar = new int[5];
                        int summa = 0;
                        int korrutis = 1;

                        for (int i = 0; i < ar.Length; i++)
                        {
                            Console.Write($"Sisesta arv {i + 1}: ");
                            ar[i] = int.Parse(Console.ReadLine());
                            summa += ar[i];
                            korrutis *= ar[i];
                        }

                        double keskmine = (double)summa / ar.Length;

                        Console.WriteLine($"Arvude summa: {summa}");
                        Console.WriteLine($"Aritmeetiline keskmine: {keskmine}");
                        Console.WriteLine($"Arvude korrutis: {korrutis}");
                    }
                    /*-------------------------------6-------------------------------------------*/
                    int[] neliArvu = new int[4];
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write("Sisesta arv {0}: ", i + 1);
                        neliArvu[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(neliArvu);
                    Array.Reverse(neliArvu);
                    string suurimArv = string.Join("", neliArvu);
                    Console.WriteLine("Suurim võimalik neliarvuline arv: " + int.Parse(suurimArv));
                }
            }
        }
    }
