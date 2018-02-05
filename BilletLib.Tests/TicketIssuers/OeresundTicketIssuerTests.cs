using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib.TicketIssuers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.TicketIssuers.Tests
{
    [TestClass()]
    public class OeresundTicketIssuerTests
    {
        // Looks fine but i cant see unit-test in Test explore
        [TestMethod()]
        public void IssueTicketCarTest()
        {
            var issuer = new OeresundTicketIssuer();

            var order = new TicketOrder
            {
                Timestamp = new DateTime(2018, 2, 2), // Friday
                LicensePlate = "XX 12 345",
                VehicleType = "car",
                BroBizz = false,
            };

            var ticket = issuer.IssueTicket(order);

            Assert.AreEqual(order.Timestamp, ticket.Timestamp);
            Assert.AreEqual(order.LicensePlate, ticket.LicensePlate);
            Assert.AreEqual(order.VehicleType, ticket.VehicleType);
            Assert.AreEqual(410, ticket.Price);
        }

        [TestMethod()]
        public void IssueTicketMotorcycleTest()
        {
            var issuer = new OeresundTicketIssuer();

            var order = new TicketOrder
            {
                Timestamp = new DateTime(2018, 2, 2), // Friday
                LicensePlate = "XX 12 345",
                VehicleType = "motorcycle",
                BroBizz = false,
            };

            var ticket = issuer.IssueTicket(order);

            Assert.AreEqual(order.Timestamp, ticket.Timestamp);
            Assert.AreEqual(order.LicensePlate, ticket.LicensePlate);
            Assert.AreEqual(order.VehicleType, ticket.VehicleType);
            Assert.AreEqual(210, ticket.Price);
        }
    }
}