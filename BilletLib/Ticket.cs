using System;

namespace BilletLib
{
    /// <summary>
    /// Ticket represents an issued ticket.
    /// </summary>
    [Serializable]
    public class Ticket
    {
        /// <summary>
        /// The time when the ticket was ordered.
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// The license plate number of the vehicle the Ticket is for.
        /// </summary>
        public string LicensePlate { get; }

        /// <summary>
        /// The type of vehicle the ticket is for.
        /// Allowable values are defined by the ITicketIssuer implementation.
        /// </summary>
        public string VehicleType { get; }

        /// <summary>
        /// The final price that must be paid for the ticket.
        /// </summary>
        public decimal Price { get; }

        public Ticket(TicketOrder o, decimal price)
        {
            Timestamp = o.Timestamp;
            LicensePlate = o.LicensePlate;
            VehicleType = o.VehicleType;
            Price = price;
        }
    }
}