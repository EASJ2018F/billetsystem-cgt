using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.TicketIssuers
{
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

            // Apply 5 % BroBizz discount
            if (o.BroBizz)
            {
                price *= 0.95M;
            }

            // Issue ticket
            return new Ticket(o, price);
        }
    }
}
