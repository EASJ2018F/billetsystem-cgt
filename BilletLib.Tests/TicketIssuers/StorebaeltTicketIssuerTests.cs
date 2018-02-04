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
    public class StorebaeltTicketIssuerTests
    {
        [TestMethod()]
        public void IssueTicketCarTest()
        {
            var issuer = new StorebaeltTicketIssuer();

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
            Assert.AreEqual(240, ticket.Price);
        }

        [TestMethod()]
        public void IssueTicketMotorcycleTest()
        {
            var issuer = new StorebaeltTicketIssuer();

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
            Assert.AreEqual(125, ticket.Price);
        }

        [TestMethod()]
        public void IssueTicketBroBizzDiscountTest()
        {
            var issuer = new StorebaeltTicketIssuer();

            var order = new TicketOrder
            {
                Timestamp = new DateTime(2018, 2, 2), // Friday
                VehicleType = "car",
                BroBizz = true,
            };

            var ticket = issuer.IssueTicket(order);

            Assert.AreEqual(228, ticket.Price);
        }

        [TestMethod()]
        public void IssueTicketCarWeekendDiscountTest()
        {
            var issuer = new StorebaeltTicketIssuer();

            var order = new TicketOrder
            {
                Timestamp = new DateTime(2018, 2, 3), // Saturday
                VehicleType = "car",
                BroBizz = false,
            };

            var ticket = issuer.IssueTicket(order);

            Assert.AreEqual(192, ticket.Price);
        }

        [TestMethod()]
        public void IssueTicketMotorcycleNoWeekendDiscountTest()
        {
            var issuer = new StorebaeltTicketIssuer();

            var order = new TicketOrder
            {
                Timestamp = new DateTime(2018, 2, 3), // Saturday
                VehicleType = "motorcycle",
                BroBizz = false,
            };

            var ticket = issuer.IssueTicket(order);

            Assert.AreEqual(125, ticket.Price);
        }

        [TestMethod()]
        public void IssueTicketWeekendBroBizzDiscountTest()
        {
            var issuer = new StorebaeltTicketIssuer();

            var order = new TicketOrder
            {
                Timestamp = new DateTime(2018, 2, 3), // Saturday
                VehicleType = "car",
                BroBizz = true,
            };

            var ticket = issuer.IssueTicket(order);

            Assert.AreEqual(182.4M, ticket.Price);
        }
    }
}