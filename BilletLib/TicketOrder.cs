using System;

namespace BilletLib
{
    public class TicketOrder
    {
        public DateTime Timestamp { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public bool BroBizz { get; set; }
    }
}