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
            //I.osa Andmetüübid Alamfunktsioonid, If
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus = Funktsioonid.Liitmine(a, b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus=Funktsioonid.Liitmine(a, (int)arv);
            Console.WriteLine(vastus);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);
            }
            else
            {
                Console.WriteLine(vastus);
            }
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
            }
        }
    }
}
