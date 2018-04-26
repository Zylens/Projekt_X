using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt_x;


namespace Console_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int obergrenze;
            int untergrenze;
            Console.WriteLine("Bitte geben sie die Untergrenze ein");
            untergrenze = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben sie die Obergrenze ein");
            obergrenze = Convert.ToInt32(Console.ReadLine());
            var dict = Projekt_LD.Start_Zahlen_testen(untergrenze, obergrenze);
            Projekt_LD.output(dict, untergrenze, obergrenze);
        }

    }
}
