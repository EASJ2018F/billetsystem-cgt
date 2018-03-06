using System;

namespace BilletLib
{
    /// <summary>
    /// TicketOrder represents an incoming request to issue a Ticket.
    /// </summary>
    public class TicketOrder
    {
        /// <summary>
        /// The time when the ticket was ordered.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The license plate number of the vehicle the Ticket is for.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// The type of vehicle the ticket is for.
        /// Allowable values are defined by the ITicketIssuer implementation.
        /// </summary>
        public string VehicleType { get; set; }

        /// <summary>
        /// Whether or not the vehicle is equipped with a BroBizz device.
        /// </summary>
        public bool BroBizz { get; set; }
    }
}