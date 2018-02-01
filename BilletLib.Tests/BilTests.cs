using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billetsystem.BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetsystem.BilletLib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void BilPrisTest()
        {
            var bil = new Bil();
            Assert.AreEqual(240, bil.Pris());
        }

        [TestMethod()]
        public void BilKøretøjTest()
        {
            var bil = new Bil();
            Assert.AreEqual("Bil", bil.Køretøj());
        }
    }
}