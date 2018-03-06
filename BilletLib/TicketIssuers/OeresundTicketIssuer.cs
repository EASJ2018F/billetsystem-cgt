using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.TicketIssuers
{
    /// <summary>
    /// OeresundTicketIssuer is an ITicketIssuer implementation for Øresundbroen.
    /// </summary>
    public class OeresundTicketIssuer : ITicketIssuer
    {
        private const string VehicleCar = "car";
        private const string VehicleMotorcycle = "motorcycle";

        private Dictionary<string, decimal> _vehicleTypeToTicketPrice = new Dictionary<string, decimal>
        {
            { VehicleCar, 410 },
            { VehicleMotorcycle, 210 },
        };
        private Dictionary<string, decimal> _vehicleTypeToTicketPriceBroBizz = new Dictionary<string, decimal>
        {
            { VehicleCar, 161 },
            { VehicleMotorcycle, 73 },
        };

        /// <summary>
        /// IssueTicket issues a ticket for Øresundbroen.
        /// Permitted vehicle types for the TicketOrder are: "car", "motorcycle".
        /// </summary>
        public Ticket IssueTicket(TicketOrder o)
        {
            if (o == null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            // Get base price
            // Throws key error on unknown vehicle type
            decimal price;
            if (!o.BroBizz)
            {
                price = _vehicleTypeToTicketPrice[o.VehicleType];
            }
            else
            {
                price = _vehicleTypeToTicketPriceBroBizz[o.VehicleType];
            }

            // Issue ticket
            return new Ticket(o, price);
        }
    }
}
