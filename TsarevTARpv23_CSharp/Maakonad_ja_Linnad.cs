using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;
//ülesanne 4
namespace TsarevTARpv23_CSharp
{
    internal class Maakonad_ja_Linnad
    {
        // Meetod, mis kirjutab maakonna ja linna andmed faili
        public void KirjutaAndmedFaili()
        {
            try
            {
                using (StreamWriter text = new StreamWriter(@"..\..\..\Maakonad_ja_Linnad.txt", true))
                {
                    Console.WriteLine("Sisesta maakonna nimetus: ");
                    string maakond = Console.ReadLine();
                    Console.WriteLine("Sisesta linna nimetus: ");
                    string linn = Console.ReadLine();
                    string lause = maakond + "-" + linn;
                    text.WriteLine(lause);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }

        // Meetod, mis loeb ja kuvab andmed failist
        public void LoeJaKuvaFailist()
        {
            try
            {
                using (StreamReader text = new StreamReader(@"..\..\..\Maakonad_ja_Linnad.txt"))
                {
                    string laused = text.ReadToEnd();
                    Console.WriteLine("Failis on järgmine informatsioon:\n");
                    Console.WriteLine(laused);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
        }

        // Meetod, mis loeb andmed failist ja paneb need sõnastikku
        public Dictionary<string, string> LaeAndmedSonastikku()
        {
            Dictionary<string, string> maakond_linn = new Dictionary<string, string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\Maakonad_ja_Linnad.txt"))
                {
                    string key = rida.Split('-')[0]; // Maakond
                    string value = rida.Split('-')[1]; // Linn
                    maakond_linn.Add(key, value);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

            return maakond_linn;
        }

        // Meetod, mis kuvab sõnastiku sisu
        public void KuvaSonastik(Dictionary<string, string> maakond_linn)
        {
            foreach (KeyValuePair<string, string> keyValue in maakond_linn)
            {
                Console.WriteLine(keyValue.Key + " pealinn on " + keyValue.Value);
            }
        }

        // Peamine meetod, mis käivitab rakenduse
        public void Run()
        {
            KirjutaAndmedFaili();
            LoeJaKuvaFailist();
            Dictionary<string, string> maakond_linn = LaeAndmedSonastikku();
            KuvaSonastik(maakond_linn);

            ConsoleKeyInfo nupp;
            do
            {
                Console.WriteLine("Vajuta Backspace, et lõpetada.");
                nupp = Console.ReadKey();
            }
            while (nupp.Key != ConsoleKey.Backspace);
        }
    }
}

