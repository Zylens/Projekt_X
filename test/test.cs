using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using happynrlib;

namespace test
{
    public class Test
    {
        [TestFixture]
        public class Happynrlibtest
        {
            [Test, Category("Akzeptanztest")]
            public void Test_zahlen()
            {
                var ergebnis = HappyNrLib.IsNumberHappy(7);
                Assert.AreEqual(false, ergebnis);
            }
            [Test, Category("Gerüsttest")]
            public void Anzahl_zahlen()
            {
                var ergebnis = HappyNrLib.statement(7);
                Assert.AreEqual("Die Zahl ist glücklich", ergebnis);

            }
        }
    }
}
