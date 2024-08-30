using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsarevTARpv23_CSharp
{
    internal class Inimene 
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Inimene() { }
        public Inimene(string nimi, int vanus = 2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }        
}
