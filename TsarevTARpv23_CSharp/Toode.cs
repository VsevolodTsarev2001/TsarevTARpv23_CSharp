﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Listid ja sõnastikud. Meetodid ja näidised - esimine osa ülesanne 3
namespace TsarevTARpv23_CSharp
{
    internal class Toode
    {
        public string ToodeNimetus {  get; set; }

        public int Kaloried { get; set; }

        public Toode() { }

        public Toode(string toodeNimetus, int kaloried)
        {
            ToodeNimetus = toodeNimetus;
            Kaloried = kaloried;
        }
    }
}
