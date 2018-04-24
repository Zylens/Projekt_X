using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_x
{
    public class Projekt_LD
    {
        public static List<int> Start_Zahlen_testen(int untergrenze, int obergrenze)
        {
            var zahl = Zahlen_testen(untergrenze, obergrenze);
            return zahl;
        }
        internal static List<int> Zahlen_testen (int untergrenze, int obergrenze)
        {
            var zahlen = new List<int>();
            for (int z = untergrenze; z <= obergrenze; z++)
            {

                zahlen.Add(z);
            }

            return zahlen;


        }

    }
}
