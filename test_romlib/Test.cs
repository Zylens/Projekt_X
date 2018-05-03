using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using romlib;

namespace test_romlib
{
    public class Test
    {
        [TestFixture]
        public class RomLibTest
        {
            [Test, Category("Akzeptanztest")]
            public void Test_zahlen()
            {
                var ergebnis = RomLib.NumberInRom(3500);
                Assert.AreEqual("MMMD", ergebnis);
            }
            [Test, Category("Gerüsttest")]
            public void Anzahl_zahlen()
            {
                var ergebnis = RomLib.statement(0);
                Assert.AreEqual("Hier ist was falschgelaufen!", ergebnis);
            }
            [Test, Category("Gerüsttest2")]
            public void Anzahl_zahlen2()
            {
                var ergebnis = RomLib.statement(30);
                Assert.AreEqual("XXX", ergebnis);
            }
        }
    }
}
