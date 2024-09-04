using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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
            //Listid ja sõnastikud. Meetodid ja näidised - ülessane 4

            //Listid ja sõnastikud. Meetodid ja näidised - Ülessane 2
            List<int> numbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(random.Next(0,101));
            }
            //päärisnumbrid
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            //paritu numbrid
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            //Uus nimekiri, kus kõigepealt lähevad ebaühtlased, seejärel paaris

            List<int> sortNumbers=evenNumbers.Concat(oddNumbers).ToList();

            Console.WriteLine("Sorteeritud numbers: ");
            sortNumbers.ForEach(n => Console.WriteLine(n + " "));
            //III.osa OOP
            //----------Listid ja sõnastikud. Meetodid ja näidised finish ülesanne 3-------------//

            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr 1";
            inimene1.Vanus = 352;
            inimene1.Sugu = Sugu.mees;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 100;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            inimene2.Sugu = Sugu.naine;
            inimene2.Pikkus = 160;
            inimene2.Kaal = 70;
            Inimene inimene3 = new Inimene("Marina", 18, Sugu.naine);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18, Sugu.naine));
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " on" + inimene.Vanus + "aasta vana"+".Ta on "+ inimene.Sugu+" SBI="+ inimene.HB_vorrand(inimene.Eluviis));
            }
            
           /* List<Toode> tooded = new List<Toode>
            {
                new Toode("Pirn", 72),
                new Toode("Tictak", 115),
                new Toode("Kana", 150),
                new Toode("TukTuk", 210),
                new Toode("Leib", 265)
            };


            Console.WriteLine("Sisesta aktiivsustase (1-5):\n" +
                "1: Istuv eluviis\n" +
                "2: Vähene aktiivsus\n" +
                "3: Mõõdukas aktiivsus\n" +
                "4: Kõrge aktiivsus\n" +
                "5: Väga kõrge aktiivsus");

            int aktiivsus = int.Parse(Console.ReadLine());


            Inimene user = inimene1;

            double aktiivsusTegur = 1.2;
            switch (aktiivsus)
            {
                case 1: aktiivsusTegur = 1.2; break;
                case 2: aktiivsusTegur = 1.375; break;
                case 3: aktiivsusTegur = 1.55; break;
                case 4: aktiivsusTegur = 1.725; break;
                case 5: aktiivsusTegur = 1.9; break;
                default: Console.WriteLine("Vale sisestus!"); return;
            }


            double kaloriVajadus = user.HB_vorrand(inimene1.Eluviis) * aktiivsusTegur;
            Console.WriteLine($"Päevane kaloriarv on: {kaloriVajadus} kcal");

            foreach (Toode toode in tooded)
            {
                double kogus = kaloriVajadus / toode.Kaloried;
                Console.WriteLine($"Sa võid süüa {kogus:F2} grammi {toode.ToodeNimetus}");
            }*/
            //------variant.2 ülesanne 3
            List<Toode> tooded = new List<Toode>
            {
                new Toode("Õun", 52),
                new Toode("Banaan", 89),
                new Toode("Kanafilee", 165),
                new Toode("Kartul", 77),
                new Toode("Leib", 265)
            };

            // Get user input for their details
            Console.WriteLine("Sisesta oma nimi:");
            string nimi = Console.ReadLine();

            Console.WriteLine("Sisesta oma vanus:");
            int vanus = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta oma sugu (mees/naine):");
            Sugu sugu = (Sugu)Enum.Parse(typeof(Sugu), Console.ReadLine().ToLower());

            Console.WriteLine("Sisesta oma pikkus (cm):");
            int pikkus = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta oma kaal (kg):");
            double kaal = double.Parse(Console.ReadLine());

            // Get user input for activity level
            Console.WriteLine("Sisesta aktiivsustase (1-5):\n" +
                "1: Istuv eluviis\n" +
                "2: Vähene aktiivsus\n" +
                "3: Mõõdukas aktiivsus\n" +
                "4: Kõrge aktiivsus\n" +
                "5: Väga kõrge aktiivsus");

            int aktiivsus = int.Parse(Console.ReadLine());

            Eluviis eluviis = Eluviis.Istuv;
            switch (aktiivsus)
            {
                case 1: eluviis = Eluviis.Istuv; break;
                case 2: eluviis = Eluviis.Vähene; break;
                case 3: eluviis = Eluviis.Mõõdukas; break;
                case 4: eluviis = Eluviis.Kõrge; break;
                case 5: eluviis = Eluviis.Väga_kõrge; break;
                default: Console.WriteLine("Vale sisestus!"); return;
            }

            // Create an instance of Inimene with the provided data
            Inimene user = new Inimene(nimi, vanus, sugu, eluviis) { Pikkus = pikkus, Kaal = kaal };

            // Calculate daily caloric need
            double kaloriVajadus = user.HB_vorrand(user.Eluviis);
            Console.WriteLine($"Päevane kaloriarv on: {kaloriVajadus} kcal");

            // Display the amount of each food item the user can consume
            foreach (Toode toode in tooded)
            {
                double kogus = kaloriVajadus / toode.Kaloried;
                Console.WriteLine($"Sa võid süüa {kogus:F2} grammi {toode.ToodeNimetus}");
            }
            //----------------------------------------------------------------------------------//
            Auto auto1 = new Auto("681MRP", Color.NavajoWhite, inimene1);
            Auto auto2 = new Auto("765JKS", Color.Red, inimene1);
            Auto auto3 = new Auto("245THK", Color.Bisque, inimene1);
            auto1.KelleOmaAuto();
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene3);
            register.Add(auto3, inimene3);
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.Regnumber} - {item.Value.Nimi}");
            }
            foreach (KeyValuePair<Auto,Inimene> pair in register)
            {
                Console.WriteLine(pair.Key.Regnumber + "-" + pair.Value.Nimi);
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
                    int vanus1 = int.Parse(Console.ReadLine());
                    if (vanus1 < 0 || vanus1 > 100)
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus1 <= 6)
                    {
                        Console.WriteLine("Tasuta pilet!");
                    }
                    else if (vanus1 <= 15)
                    {
                        Console.WriteLine("Lastepilet!");
                    }
                    else if (vanus1 <= 65)
                    {
                        Console.WriteLine("Täispilet!");
                    }
                    else if (vanus1 <= 100)
                    {
                        Console.WriteLine("Sooduspilet!");
                    }
                    /*-----------------------------------------------------------------------*/
                    try
                    {
                        Console.WriteLine("Mis on sinu pikkus?");
                        double pikkus1 = Double.Parse(Console.ReadLine());
                        string vastus = Funktsioonid.Pikkuse_analuus(pikkus1);
                        Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus1, vastus);
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
