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
    public class BaseKøretøjTests
    {
        [TestMethod()]
        public void BaseKøretøjNummerpladeLængdeOKTest()
        {
            new BaseKøretøjImpl { Nummerplade = "" };
            new BaseKøretøjImpl { Nummerplade = "1234567" };
        }

        [TestMethod(), ExpectedException(typeof(ArgumentException))]
        public void BaseKøretøjNummerpladeForLangTest()
        {
            new BaseKøretøjImpl { Nummerplade = "12345678" };
        }
    }

    /// <summary>
    /// Simple BaseKøretøj implementation with no custom behavior.
    /// A helper for BaseKøretøjTests so that we are able to test
    /// a BaseKøretøj that does not have custom behavior.
    /// </summary>
    public class BaseKøretøjImpl : BaseKøretøj
    {
        public override string Køretøj()
        {
            throw new NotImplementedException();
        }

        public override int Pris()
        {
            throw new NotImplementedException();
        }
    }
}