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
            zahl = prove(zahl, untergrenze, obergrenze);
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

            return dic;
        }
        public static Dictionary<int, string> prove(Dictionary<int, string> dic, int untergrenze, int obergrenze)
        {
  
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


            

            return dic;
        }

        public static void output(Dictionary<int, string> dic, int untergrenze, int obergrenze)
        {
            for (int z = untergrenze; z <= obergrenze; z++)
            {
                Console.WriteLine(dic[z]);
            }
            Console.ReadLine();
        }
    }
}
