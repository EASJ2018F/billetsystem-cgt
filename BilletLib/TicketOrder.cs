using System;
using System.Runtime.Serialization;

namespace BilletLib
{
    /// <summary>
    /// TicketOrder represents an incoming request to issue a Ticket.
    /// </summary>
    [Serializable]
    [DataContract]
    public class TicketOrder
    {
        /// <summary>
        /// The time when the ticket was ordered.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The license plate number of the vehicle the Ticket is for.
        /// </summary>
        [DataMember]
        public string LicensePlate { get; set; }

        /// <summary>
        /// The type of vehicle the ticket is for.
        /// Allowable values are defined by the ITicketIssuer implementation.
        /// </summary>
        [DataMember]
        public string VehicleType { get; set; }

        /// <summary>
        /// Whether or not the vehicle is equipped with a BroBizz device.
        /// </summary>
        [DataMember]
        public bool BroBizz { get; set; }
    }
}