using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.TicketIssuers
{
    public class StorebaeltTicketIssuer : ITicketIssuer
    {
        private Dictionary<string, decimal> _vehicleTypeToTicketPrice = new Dictionary<string, decimal>
        {
            { "car", 240 },
            { "motorcycle", 125 },
        };

        public Ticket IssueTicket(TicketOrder o)
        {
            if (o == null)
            {
                throw new ArgumentNullException(nameof(o));
            }

            // Get base price
            // Throws key error on unknown vehicle type
            var price = _vehicleTypeToTicketPrice[o.VehicleType];

            // Apply 20 % weekend discount for cars
            var day = o.Timestamp.DayOfWeek;
            if (o.VehicleType == "car" && (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday))
            {
                price *= 0.8M;
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
