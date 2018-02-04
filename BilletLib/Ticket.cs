using System;

namespace BilletLib
{
    public class Ticket
    {
        public DateTime Timestamp { get; }
        public string LicensePlate { get; }
        public string VehicleType { get; }
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