using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happynrlib
{
    public class Happynrlib
    {
        internal static bool IsNumberHappy(int number)
        {
            int digit;
            int sum = 0;
            bool unhappy = false;
            while (number != 1 && unhappy == false)
            {
                while (number != 0 && unhappy == false)
                {
                    digit = number % 10;
                    sum += digit * digit;
                    number = number / 10;
                }
                number = sum;
                if (number == 4)
                {
                    unhappy = true;
                    return true;
                }
                
                sum = 0;
            }
            return false;
            
        }

        internal static string statement(int number)
        {
            string result = "Hier ist was falschgelaufen!";
            if (!(Happynrlib.IsNumberHappy(number)))
            {
                result="Die Zahl ist glücklich";
            }
            else
            {
                result="Die Zahl ist nicht glücklich";
            }
            return result;
        }
        public static void pushthispieceof(int number)
        {
            Console.WriteLine(statement(number));
            Console.ReadKey();
        }

    }
}
