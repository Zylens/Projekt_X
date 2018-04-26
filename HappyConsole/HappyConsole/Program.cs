using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using happynrlib;

namespace HappyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            Console.WriteLine("Bitte geben sie eine Zahl ein:");
            zahl = Convert.ToInt32(Console.ReadLine());
            HappyNrLib.pushthispieceof(zahl);
        }
    }
}
