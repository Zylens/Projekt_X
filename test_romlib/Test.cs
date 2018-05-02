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
                var ergebnis = RomLib.statement(7);
                Assert.AreEqual("VII", ergebnis);

            }
        }
    }
}
