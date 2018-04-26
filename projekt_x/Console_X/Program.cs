using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projekt_x;
using happynrlib;


namespace Console_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            Console.WriteLine("Bitte geben sie eine Zahl ein:");
            zahl = Convert.ToInt32(Console.ReadLine());
            Happynrlib.pushthispieceof(zahl);

            //int obergrenze;
            //int untergrenze;
            //Console.WriteLine("Bitte geben sie die Untergrenze ein");
            //untergrenze = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitte geben sie die Obergrenze ein");
            //obergrenze = Convert.ToInt32(Console.ReadLine());
            //var dict = Projekt_LD.Start_Zahlen_testen(untergrenze, obergrenze);
            //Projekt_LD.output(dict,untergrenze,obergrenze);
        }

    }
}
