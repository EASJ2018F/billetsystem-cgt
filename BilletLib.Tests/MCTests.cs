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
    public class MCTests
    {
        [TestMethod()]
        public void MCPrisTest()
        {
            var mc = new MC();
            Assert.AreEqual(125, mc.Pris());
        }

        [TestMethod()]
        public void MCKøretøjTest()
        {
            var mc = new MC();
            Assert.AreEqual("MC", mc.Køretøj());
        }
    }
}