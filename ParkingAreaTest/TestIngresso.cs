using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingAreaTest
{
    [TestClass]
    public class TestIngresso
    {
        [TestMethod]
        public void controllo_orario()
        {
            MockPark mp = new MockPark();
            MockIngresso mi = new MockIngresso(mp.PostiDisponibili, mp.OrarioAperture, mp.OrarioChiusura);

            DateTime dt1 = new DateTime(2018, 6, 14, 10, 0, 1);
            DateTime dt2 = new DateTime(2018, 6, 14, 8, 50, 1);
            DateTime dt3 = new DateTime(2018, 6, 13, 5, 0, 1);

            Assert.AreEqual(false, mi.AccettaVeicolo("QWE123", dt3));
            Assert.AreEqual(false, mi.AccettaVeicolo("QWE123", dt1));
            Assert.AreEqual(true, mi.AccettaVeicolo("QWE123", dt2));
        }

        [TestMethod2]
        public void count_posti_liberi
        {

        }
    }

    
    
}
