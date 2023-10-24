using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatKosikAlex
{
    class Bolygo
    {
        public string BolygoNev { get; set; }
        public int BolygoSzam { get; set; }
        public double BolygoTerfogat { get; set; }

        public Bolygo(string r)
        {
            string[] v = r.Split(';');
            BolygoNev = v[0];
            BolygoSzam = int.Parse(v[1]);
            BolygoTerfogat = double.Parse(v[2].Replace(".",","));
        }
    }
}
