using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using projekt_x;

namespace projekt_x_test
{
     [TestFixture]
    public class Projekt_LD_test
    {
        [Test, Category("Akzeptanztest")]
        public void Test_zahlen()
        {
            var ergebnis= Projekt_LD.Start_Zahlen_testen(1,16);
            Assert.AreEqual(new Dictionary<int, string> { { 1, "1" }, { 2, "2" }, { 3, "Fizz" }, { 4, "4" }, { 5, "Buzz" }, { 6, "Fizz" }, { 7, "7" }, { 8, "8" }, { 9, "Fizz" }, { 10, "Buzz" }, { 11, "11" }, { 12, "Fizz" }, { 13, "13" }, { 14, "14" }, { 15, "FizzBuzz" }, { 16, "16" } },ergebnis.ToArray());
        }
        [Test, Category("Gerüsttest")]
        public void Anzahl_zahlen()
        {
            var ergebnis = Projekt_LD.Zahlen_testen(1, 100);
            Assert.AreEqual(100, ergebnis.Count());

        }

    }

}
