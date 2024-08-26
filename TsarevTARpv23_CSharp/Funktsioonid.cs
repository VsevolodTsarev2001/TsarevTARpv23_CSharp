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
    }

}
