using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projekt_x
{
    
    public class Projekt_LD
    {
        static IDictionary<int, string> dict = new Dictionary<int, string>();
        public static Dictionary<int, string> Start_Zahlen_testen(int untergrenze, int obergrenze)
        {
            var zahl = Zahlen_testen(untergrenze, obergrenze);
            return zahl;
        }
        internal static Dictionary<int, string> Zahlen_testen (int untergrenze, int obergrenze)
        {
            var dic = new Dictionary<int, string>();
            
            for (int z = untergrenze; z <= obergrenze; z++)
            {
                //test area
                dic.Add(z, Convert.ToString(z));
            }

            dic = prove(dic,untergrenze,obergrenze);

            return dic;
        }
        public static Dictionary<int, string> prove(Dictionary<int, string> dic, int u,int o )
        {
            int untergrenze = u;
            int obergrenze = o;
            for (int z = untergrenze; z <= obergrenze; z++)
            {
                if (!((z % 3) != 0))
                {
                    dic[z] = "Fizz";
                }
                if (!((z % 5) != 0))
                {
                    dic[z] = "Buzz";
                }
                if ((!((z % 3) != 0)) && (!((z % 5) != 0)))
                {
                    dic[z] = "FizzBuzz";
                }
            }


            var dicfinal = dic;

            return dicfinal;
        }


    }
}
