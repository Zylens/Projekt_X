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
            var ergebnis= Projekt_LD.Start_Zahlen_testen(2,15);
            Assert.AreEqual(new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },ergebnis.ToArray());
        }
        [Test, Category("Gerüsttest")]
        public void Anzahl_zahlen()
        {
            var ergebnis = Projekt_LD.Zahlen_testen(-1, 100);
            Assert.AreEqual(102, ergebnis.Count());

        }

    }

}
